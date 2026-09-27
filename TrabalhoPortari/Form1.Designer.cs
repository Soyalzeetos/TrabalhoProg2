namespace TrabalhoPortari
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameInput = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.inputData = new System.Windows.Forms.DateTimePicker();
            this.Genero = new System.Windows.Forms.Label();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cursoInput = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Disciplina = new System.Windows.Forms.Label();
            this.subject5 = new System.Windows.Forms.CheckBox();
            this.subject4 = new System.Windows.Forms.CheckBox();
            this.subject3 = new System.Windows.Forms.CheckBox();
            this.subject2 = new System.Windows.Forms.CheckBox();
            this.subject1 = new System.Windows.Forms.CheckBox();
            this.detailsAlunos = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.carregar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listaAlunos = new System.Windows.Forms.ListBox();
            this.Detalhes = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.leaveButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(75, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(331, 20);
            this.nameInput.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(15, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Nome:";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nascimento.Location = new System.Drawing.Point(15, 46);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(159, 17);
            this.Nascimento.TabIndex = 3;
            this.Nascimento.Text = "Data de Nascimento:";
            // 
            // inputData
            // 
            this.inputData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputData.Location = new System.Drawing.Point(180, 46);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(226, 20);
            this.inputData.TabIndex = 4;
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(15, 79);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(67, 17);
            this.Genero.TabIndex = 5;
            this.Genero.Text = "Genero:";
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFem.Location = new System.Drawing.Point(18, 99);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(77, 19);
            this.radioFem.TabIndex = 7;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Feminino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMasc.Location = new System.Drawing.Point(18, 124);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(82, 19);
            this.radioMasc.TabIndex = 8;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // cursoInput
            // 
            this.cursoInput.AllowDrop = true;
            this.cursoInput.FormattingEnabled = true;
            this.cursoInput.Items.AddRange(new object[] {
            "Administração",
            "Agronomia",
            "Engenharia Civil",
            "Jornalismo",
            "Literatura",
            "Psicologia",
            "Sistemas de Informação"});
            this.cursoInput.Location = new System.Drawing.Point(495, 11);
            this.cursoInput.Name = "cursoInput";
            this.cursoInput.Size = new System.Drawing.Size(264, 21);
            this.cursoInput.TabIndex = 10;
            this.cursoInput.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Disciplina);
            this.panel1.Controls.Add(this.subject5);
            this.panel1.Controls.Add(this.subject4);
            this.panel1.Controls.Add(this.subject3);
            this.panel1.Controls.Add(this.subject2);
            this.panel1.Controls.Add(this.subject1);
            this.panel1.Location = new System.Drawing.Point(439, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 110);
            this.panel1.TabIndex = 11;
            // 
            // Disciplina
            // 
            this.Disciplina.AutoSize = true;
            this.Disciplina.Location = new System.Drawing.Point(3, 0);
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.Size = new System.Drawing.Size(55, 13);
            this.Disciplina.TabIndex = 5;
            this.Disciplina.Text = "Disciplina:";
            // 
            // subject5
            // 
            this.subject5.AutoSize = true;
            this.subject5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject5.Location = new System.Drawing.Point(20, 80);
            this.subject5.Name = "subject5";
            this.subject5.Size = new System.Drawing.Size(121, 17);
            this.subject5.TabIndex = 4;
            this.subject5.Text = "Escolha a Disciplina";
            this.subject5.UseVisualStyleBackColor = true;
            // 
            // subject4
            // 
            this.subject4.AutoSize = true;
            this.subject4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject4.Location = new System.Drawing.Point(20, 65);
            this.subject4.Name = "subject4";
            this.subject4.Size = new System.Drawing.Size(121, 17);
            this.subject4.TabIndex = 3;
            this.subject4.Text = "Escolha a Disciplina";
            this.subject4.UseVisualStyleBackColor = true;
            // 
            // subject3
            // 
            this.subject3.AutoSize = true;
            this.subject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject3.Location = new System.Drawing.Point(20, 50);
            this.subject3.Name = "subject3";
            this.subject3.Size = new System.Drawing.Size(121, 17);
            this.subject3.TabIndex = 2;
            this.subject3.Text = "Escolha a Disciplina";
            this.subject3.UseVisualStyleBackColor = true;
            // 
            // subject2
            // 
            this.subject2.AutoSize = true;
            this.subject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject2.Location = new System.Drawing.Point(20, 35);
            this.subject2.Name = "subject2";
            this.subject2.Size = new System.Drawing.Size(121, 17);
            this.subject2.TabIndex = 1;
            this.subject2.Text = "Escolha a Disciplina";
            this.subject2.UseVisualStyleBackColor = true;
            // 
            // subject1
            // 
            this.subject1.AutoSize = true;
            this.subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject1.Location = new System.Drawing.Point(20, 20);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(121, 17);
            this.subject1.TabIndex = 0;
            this.subject1.Text = "Escolha a Disciplina";
            this.subject1.UseVisualStyleBackColor = true;
            // 
            // detailsAlunos
            // 
            this.detailsAlunos.Enabled = false;
            this.detailsAlunos.Location = new System.Drawing.Point(438, 218);
            this.detailsAlunos.Name = "detailsAlunos";
            this.detailsAlunos.ReadOnly = true;
            this.detailsAlunos.Size = new System.Drawing.Size(320, 162);
            this.detailsAlunos.TabIndex = 13;
            this.detailsAlunos.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lista de cadastros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Detalhes:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(654, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 27);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Adicionar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carregar
            // 
            this.carregar.Location = new System.Drawing.Point(444, 168);
            this.carregar.Name = "carregar";
            this.carregar.Size = new System.Drawing.Size(104, 27);
            this.carregar.TabIndex = 18;
            this.carregar.Text = "Carregar";
            this.carregar.UseVisualStyleBackColor = true;
            this.carregar.Click += new System.EventHandler(this.carregardados);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(339, 168);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(104, 27);
            this.botaoSalvar.TabIndex = 19;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.SalvarLista);
            // 
            // listaAlunos
            // 
            this.listaAlunos.FormattingEnabled = true;
            this.listaAlunos.Location = new System.Drawing.Point(18, 220);
            this.listaAlunos.Name = "listaAlunos";
            this.listaAlunos.Size = new System.Drawing.Size(388, 160);
            this.listaAlunos.TabIndex = 20;
            // 
            // Detalhes
            // 
            this.Detalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalhes.Location = new System.Drawing.Point(283, 385);
            this.Detalhes.Name = "Detalhes";
            this.Detalhes.Size = new System.Drawing.Size(122, 27);
            this.Detalhes.TabIndex = 22;
            this.Detalhes.Text = "Detalhes";
            this.Detalhes.UseVisualStyleBackColor = true;
            this.Detalhes.Click += new System.EventHandler(this.exibirDetalhes);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(155, 386);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(122, 27);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Deletar";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.DeletarAluno);
            // 
            // leaveButton
            // 
            this.leaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveButton.Location = new System.Drawing.Point(18, 385);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(122, 27);
            this.leaveButton.TabIndex = 24;
            this.leaveButton.Text = "Sair";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.Leave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(438, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 27);
            this.button4.TabIndex = 25;
            this.button4.Text = "Fonte";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DefinirFonte);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(616, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 27);
            this.button5.TabIndex = 26;
            this.button5.Text = "Cor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.mudarCor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Detalhes);
            this.Controls.Add(this.listaAlunos);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.carregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailsAlunos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cursoInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioMasc);
            this.Controls.Add(this.radioFem);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.DateTimePicker inputData;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cursoInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox subject4;
        private System.Windows.Forms.CheckBox subject3;
        private System.Windows.Forms.CheckBox subject2;
        private System.Windows.Forms.CheckBox subject1;
        private System.Windows.Forms.Label Disciplina;
        private System.Windows.Forms.CheckBox subject5;
        private System.Windows.Forms.RichTextBox detailsAlunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button carregar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listaAlunos;
        private System.Windows.Forms.Button Detalhes;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

