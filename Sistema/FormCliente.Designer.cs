namespace Sistema
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkDiabetico = new System.Windows.Forms.CheckBox();
            this.checkVegano = new System.Windows.Forms.CheckBox();
            this.checkIntoleranteLactose = new System.Windows.Forms.CheckBox();
            this.checkVegetariano = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(361, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDiabetico);
            this.groupBox2.Controls.Add(this.checkVegano);
            this.groupBox2.Controls.Add(this.checkIntoleranteLactose);
            this.groupBox2.Controls.Add(this.checkVegetariano);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(361, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 176);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preferências:";
            // 
            // checkDiabetico
            // 
            this.checkDiabetico.AutoSize = true;
            this.checkDiabetico.Location = new System.Drawing.Point(6, 131);
            this.checkDiabetico.Name = "checkDiabetico";
            this.checkDiabetico.Size = new System.Drawing.Size(95, 24);
            this.checkDiabetico.TabIndex = 3;
            this.checkDiabetico.Text = "Diabético";
            this.checkDiabetico.UseVisualStyleBackColor = true;
            // 
            // checkVegano
            // 
            this.checkVegano.AutoSize = true;
            this.checkVegano.Location = new System.Drawing.Point(6, 67);
            this.checkVegano.Name = "checkVegano";
            this.checkVegano.Size = new System.Drawing.Size(84, 24);
            this.checkVegano.TabIndex = 2;
            this.checkVegano.Text = "Vegano";
            this.checkVegano.UseVisualStyleBackColor = true;
            // 
            // checkIntoleranteLactose
            // 
            this.checkIntoleranteLactose.AutoSize = true;
            this.checkIntoleranteLactose.Location = new System.Drawing.Point(6, 97);
            this.checkIntoleranteLactose.Name = "checkIntoleranteLactose";
            this.checkIntoleranteLactose.Size = new System.Drawing.Size(173, 24);
            this.checkIntoleranteLactose.TabIndex = 1;
            this.checkIntoleranteLactose.Text = "Intolerante à lactose";
            this.checkIntoleranteLactose.UseVisualStyleBackColor = true;
            // 
            // checkVegetariano
            // 
            this.checkVegetariano.AutoSize = true;
            this.checkVegetariano.Location = new System.Drawing.Point(6, 37);
            this.checkVegetariano.Name = "checkVegetariano";
            this.checkVegetariano.Size = new System.Drawing.Size(115, 24);
            this.checkVegetariano.TabIndex = 0;
            this.checkVegetariano.Text = "Vegetariano";
            this.checkVegetariano.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(361, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(240, 46);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "CADASTRO DE CLIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCasado);
            this.groupBox1.Controls.Add(this.rbSolteiro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 90);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(177, 43);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(82, 24);
            this.rbCasado.TabIndex = 12;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Location = new System.Drawing.Point(20, 43);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(81, 24);
            this.rbSolteiro.TabIndex = 11;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Estado:";
            // 
            // comboEstado
            // 
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboEstado.Location = new System.Drawing.Point(244, 262);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(102, 28);
            this.comboEstado.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Cidade:";
            // 
            // comboCidade
            // 
            this.comboCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCidade.FormattingEnabled = true;
            this.comboCidade.Items.AddRange(new object[] {
            "RIO BRANCO",
            "MACAPÁ",
            "MACEIÓ",
            "MANAUS",
            "SALVADOR",
            "FORTALEZA",
            "BRASÍLIA",
            "VITÓRIA",
            "GOIÂNIA",
            "SÃO LUIS",
            "CUIABÁ",
            "CAMPO GRANDE",
            "BELO HORIZONTE",
            "BELÉM",
            "JOÃO PESSOA",
            "CURITIBA",
            "RECIFE",
            "TERESINA",
            "RIO DE JANEIRO",
            "NATAL",
            "PORTO ALEGRE",
            "PORTO VELHO",
            "BOA VISTA",
            "FLORIANÓPOLIS",
            "SÃO PAULO",
            "ARACAJU",
            "PALMAS"});
            this.comboCidade.Location = new System.Drawing.Point(45, 262);
            this.comboCidade.Name = "comboCidade";
            this.comboCidade.Size = new System.Drawing.Size(179, 28);
            this.comboCidade.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Celular:";
            // 
            // maskCelular
            // 
            this.maskCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskCelular.Location = new System.Drawing.Point(210, 193);
            this.maskCelular.Mask = "(99) 00000-0000";
            this.maskCelular.Name = "maskCelular";
            this.maskCelular.Size = new System.Drawing.Size(134, 26);
            this.maskCelular.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Telefone:";
            // 
            // maskTelefone
            // 
            this.maskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskTelefone.Location = new System.Drawing.Point(45, 193);
            this.maskTelefone.Mask = "(99) 0000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(134, 26);
            this.maskTelefone.TabIndex = 29;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(45, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 26);
            this.txtNome.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskCelular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkDiabetico;
        private System.Windows.Forms.CheckBox checkVegano;
        private System.Windows.Forms.CheckBox checkIntoleranteLactose;
        private System.Windows.Forms.CheckBox checkVegetariano;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskCelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}