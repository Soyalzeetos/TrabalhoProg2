using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabalhoPortari
{
    
    public partial class Form1 : Form
    {
        List<Aluno> listaDeAlunos = new List<Aluno>();
        string[,] gradeDisciplinas = {
        { "Teoria Geral da Administração (TGA)", "Gestão Financeira e Orçamentária", "Marketing Estratégico", "Gestão de Pessoas", "Logística e Cadeia de Suprimentos" },
        { "Ciência e Fertilidade do Solo", "Fisiologia Vegetal", "Fitopatologia", "Topografia e Georreferenciamento", "Irrigação e Drenagem" },
        { "Cálculo Diferencial e Integral", "Resistência dos Materiais", "Mecânica dos Solos e Fundações", "Materiais de Construção Civil", "Hidráulica e Saneamento Básico" },
        { "Teorias do Jornalismo", "Redação e Técnicas de Reportagem", "Fotojornalismo", "Jornalismo Digital e Multimídia", "Ética e Legislação Jornalística" },
        { "Teoria da Literatura", "Literatura Brasileira", "Literatura Portuguesa", "Literatura Comparada", "Crítica Literária e Análise Textual" },
        { "Psicologia do Desenvolvimento", "Neuropsicologia", "Psicopatologia", "Psicologia Social", "Teorias e Técnicas Psicoterápicas" },
        { "Algoritmos e Estruturas de Dados", "Engenharia de Software", "Banco de Dados", "Redes e Segurança da Informação", "Governança e Gestão de Projetos" }
    };
        CheckBox[] caixasDisciplinas;
        public Form1()
        {
            InitializeComponent();
            caixasDisciplinas = new CheckBox[] { subject1, subject2, subject3, subject4, subject5 };
        }
        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceCurso = cursoInput.SelectedIndex;

            if (indiceCurso == -1) return;

            for (int i = 0; i < caixasDisciplinas.Length; i++)
            {
                caixasDisciplinas[i].Text = gradeDisciplinas[indiceCurso, i];
                caixasDisciplinas[i].Checked = false;
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                MessageBox.Show("Por favor, insira o nome do aluno.", "Erro");
                return;
            }
            string genero = "";
            if (radioMasc.Checked)
            {
                genero = "Masculino";
            }
            else if (radioFem.Checked)
            {
                genero = "Feminino";
            }
            else
            {
                MessageBox.Show("Por favor, selecione o gênero do aluno.", "Erro");
                return;
            }
            if (cursoInput.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o curso do aluno.", "Erro");
                return;
            }

            List<string> disciplinasMarcadas = new List<string>();
            foreach (CheckBox chk in caixasDisciplinas)
            {
                if (chk.Checked)
                {
                    disciplinasMarcadas.Add(chk.Text);
                }
            }

            string textoDisciplinas = disciplinasMarcadas.Count > 0
                ? string.Join(", ", disciplinasMarcadas)
                : "Nenhuma";

            Aluno novo = new Aluno();
            novo.Nome = nameInput.Text;
            novo.DataNascimento = inputData.Text;
            novo.Curso = cursoInput.SelectedItem?.ToString() ?? "Não selecionado";
            novo.Genero = genero;
            novo.Disciplinas = textoDisciplinas;
            novo.dataCadastro = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            novo.resumoExtenso = novo.GerarResumoExtenso();

            listaDeAlunos.Add(novo);
            listaAlunos.Items.Add(novo);
        }
        public class Aluno
        {
            public string Nome { get; set; }
            public string DataNascimento { get; set; }
            public string Curso { get; set; }
            public string Genero { get; set; }
            public string Disciplinas { get; set; }
            public string resumoExtenso { get; set; }
            public string dataCadastro { get; set; }
            public string GerarResumoExtenso()
            {
                int idade = DateTime.Now.Year - DateTime.Parse(DataNascimento).Year;
                if (DateTime.Now.Month < DateTime.Parse(DataNascimento).Month || (DateTime.Now.Month == DateTime.Parse(DataNascimento).Month && DateTime.Now.Day < DateTime.Parse(DataNascimento).Day))
                {
                    idade--;
                }
                String[] resumoExtenso = {
                    $"Nome: {Nome}",
                    $"Data de Nascimento: {DataNascimento}",
                    $"Idade: {idade} anos",
                    $"Curso: {Curso}",
                    $"Gênero: {Genero}",
                    $"Disciplinas: {Disciplinas}",
                    $"Data de Cadastro: {dataCadastro}"
                };
                return string.Join(Environment.NewLine, resumoExtenso);
            }
            
            public override string ToString()
            {
                return $"{Nome} - {DataNascimento} - {Curso} - {Genero} - [{Disciplinas}] - Cad: {dataCadastro}";
            }
            public string ParaLinhaArquivo()
            {
                return $"{Nome};{DataNascimento};{Curso};{Genero};{Disciplinas};{dataCadastro}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cursoInput.SelectedIndex = -1;
            nameInput.Clear();
            inputData.Value = DateTime.Now;
            radioFem.Checked = false;
            radioMasc.Checked = false;

            for (int i = 0; i < caixasDisciplinas.Length; i++)
            {
                caixasDisciplinas[i].Text = "Escolha a disciplina";
                caixasDisciplinas[i].Checked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void exibirDetalhes(object sender, EventArgs e)
        {
            if (listaAlunos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um aluno na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Aluno alunoSelecionado = (Aluno)listaAlunos.SelectedItem;
            detailsAlunos.Clear();
            detailsAlunos.AppendText(alunoSelecionado.resumoExtenso + Environment.NewLine + Environment.NewLine);
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DeletarAluno(object sender, EventArgs e)
        {
            if (listaAlunos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno na lista para remover.", "Aviso");
                return;
            }
            DialogResult confirmacao = MessageBox.Show(
                "Tem a certeza de que deseja remover o aluno selecionado?",
                "Confirmar Remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                Aluno alunoParaRemover = (Aluno)listaAlunos.SelectedItem;
                listaDeAlunos.Remove(alunoParaRemover);
                listaAlunos.Items.Remove(alunoParaRemover);
                detailsAlunos.Clear();
            }
        }

        private void DefinirFonte(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                detailsAlunos.Font = fontDialog1.Font;
            }
        }

        private void mudarCor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                detailsAlunos.ForeColor = colorDialog1.Color;
            }
        }

        private void SalvarLista(object sender, EventArgs e)
        {
            if (listaDeAlunos.Count == 0)
            {
                MessageBox.Show("Não há alunos cadastrados para salvar!", "Aviso");
                return;
            }

            SaveFileDialog janelaSalvar = new SaveFileDialog();
            janelaSalvar.Filter = "Arquivo de Texto (*.txt)|*.txt";
            janelaSalvar.Title = "Salvar Cadastros de Alunos";
            janelaSalvar.FileName = "alunos_cadastrados.txt";

            if (janelaSalvar.ShowDialog() == DialogResult.OK)
            {
                List<string> linhasParaGravar = new List<string>();

                foreach (Aluno a in listaDeAlunos)
                {
                    linhasParaGravar.Add(a.ParaLinhaArquivo());
                }

                File.WriteAllLines(janelaSalvar.FileName, linhasParaGravar);

                MessageBox.Show("Cadastros salvos com sucesso!", "Sucesso");
            }
        }

        private void carregardados(object sender, EventArgs e)
        {
            OpenFileDialog janelaAbrir = new OpenFileDialog();
            janelaAbrir.Filter = "Arquivo de Texto (*.txt)|*.txt";
            janelaAbrir.Title = "Abrir Cadastros de Alunos";
            if (janelaAbrir.ShowDialog() == DialogResult.OK)
            {
                listaDeAlunos.Clear();
                listaAlunos.Items.Clear();
                detailsAlunos.Clear();
                string[] linhasDoArquivo = File.ReadAllLines(janelaAbrir.FileName);
                foreach (string linha in linhasDoArquivo)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;
                    string[] pedacos = linha.Split(';');
                    if (pedacos.Length == 6)
                    {
                        Aluno alunoCarregado = new Aluno();
                        alunoCarregado.Nome = pedacos[0];
                        alunoCarregado.DataNascimento = pedacos[1];
                        alunoCarregado.Curso = pedacos[2];
                        alunoCarregado.Genero = pedacos[3];
                        alunoCarregado.Disciplinas = pedacos[4];
                        alunoCarregado.dataCadastro = pedacos[5];
                        alunoCarregado.resumoExtenso = alunoCarregado.GerarResumoExtenso(); 
                        listaDeAlunos.Add(alunoCarregado);
                        listaAlunos.Items.Add(alunoCarregado);
                    }
                }

                MessageBox.Show("Cadastros carregados com sucesso!", "Sucesso");
            }
        }
    }
}
