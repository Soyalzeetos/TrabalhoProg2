# 🎓 Cadastro de Alunos — Windows Forms (C#)

Aplicação desktop desenvolvida em **C#** utilizando a tecnologia **Windows Forms** para consolidação dos conceitos de interface gráfica, manipulação de coleções em memória (`List`), estruturas multidimensionais (matrizes) e persistência de dados em arquivos de texto (`System.IO`).

---

## 📌 Funcionalidades Obrigatórias

- **Adicionar Aluno:** Cadastro com validação de campos (Nome, Data de Nascimento, Curso, Gênero e Disciplinas cursadas), gerando um resumo textual automático por item na `ListBox`.
- **Disciplinas Dinâmicas:** Seleção de curso via `ComboBox` atualiza automaticamente as opções de disciplinas nos `CheckBoxes` por meio de indexação matricial.
- **Visualizar Detalhes:** Apresentação da ficha completa do aluno selecionado no componente `RichTextBox`.
- **Salvar Cadastros (`SaveFileDialog`):** Exportação de toda a lista de alunos da memória para arquivo `.txt` estruturado com separadores.
- **Abrir Cadastros (`OpenFileDialog`):** Leitura de arquivo `.txt`, desserialização das linhas e reconstrução dos objetos na `ListBox`.
- **Limpar Campos:** Restauração de todos os campos de entrada para o padrão inicial, preservando as listagens.
- **Sair do Sistema:** Encerramento seguro da aplicação com confirmação via `MessageBox`.

---

## ⭐ Funcionalidades Extras

- **Cálculo Dinâmico de Idade:** Determinação automática da idade em anos a partir da data informada no nascimento.
- **Data e Hora de Cadastro:** Registro do momento exato do cadastro (`dd/MM/yyyy HH:mm:ss`), mantido fixo na persistência do arquivo.
- **Remoção de Aluno:** Exclusão do aluno selecionado tanto da interface quanto da coleção em memória com confirmação via `MessageBox`.
- **Customização Visual:** Ajuste de fontes e cores do painel de detalhes utilizando `FontDialog` e `ColorDialog`.

---

## 🏫 Grades Curriculares Mapeadas

O sistema implementa uma matriz `[7, 5]` para alternar as disciplinas de acordo com a seleção do curso:

| Curso | Disciplinas Disponíveis |
| :--- | :--- |
| **Administração** | TGA, Gestão Financeira e Orçamentária, Marketing Estratégico, Gestão de Pessoas, Logística e Cadeia de Suprimentos |
| **Agronomia** | Ciência e Fertilidade do Solo, Fisiologia Vegetal, Fitopatologia, Topografia e Georreferenciamento, Irrigação e Drenagem |
| **Engenharia Civil** | Cálculo Diferencial e Integral, Resistência dos Materiais, Mecânica dos Solos e Fundações, Materiais de Construção Civil, Hidráulica e Saneamento Básico |
| **Jornalismo** | Teorias do Jornalismo, Redação e Técnicas de Reportagem, Fotojornalismo, Jornalismo Digital e Multimídia, Ética e Legislação Jornalística |
| **Literatura** | Teoria da Literatura, Literatura Brasileira, Literatura Portuguesa, Literatura Comparada, Crítica Literária e Análise Textual |
| **Psicologia** | Psicologia do Desenvolvimento, Neuropsicologia, Psicopatologia, Psicologia Social, Teorias e Técnicas Psicoterápicas |
| **Sistemas de Informação** | Algoritmos e Estruturas de Dados, Engenharia de Software, Banco de Dados, Redes e Segurança da Informação, Governança e Gestão de Projetos |

---

## 💾 Estrutura do Arquivo de Dados (`.txt`)

O salvamento e a leitura utilizam o formato delimitado por ponto e vírgula (`;`):

```text
Nome;DataNascimento;Curso;Gênero;Disciplinas;DataCadastro
