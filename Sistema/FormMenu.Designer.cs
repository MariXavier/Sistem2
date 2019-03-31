namespace Sistema
{
    partial class FormMenu
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::Sistema.Properties.Resources.exit;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(303, 157);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(237, 84);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFuncionario.Image = global::Sistema.Properties.Resources.iconfinder_folder_job_seeker_employee_unemployee_work_2620522;
            this.btnCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(60, 157);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(237, 84);
            this.btnCadastroFuncionario.TabIndex = 6;
            this.btnCadastroFuncionario.Text = "Cadastro de Funcionários";
            this.btnCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProduto.Image = global::Sistema.Properties.Resources.iconfinder_palet02_62584;
            this.btnCadastroProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProduto.Location = new System.Drawing.Point(303, 67);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(237, 84);
            this.btnCadastroProduto.TabIndex = 5;
            this.btnCadastroProduto.Text = "Cadastro de Produtos";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.Image = global::Sistema.Properties.Resources.user__1_;
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(60, 67);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(237, 84);
            this.btnCadastroCliente.TabIndex = 4;
            this.btnCadastroCliente.Text = "Cadastro de Cliente";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 333);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroFuncionario);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnCadastroCliente);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnCadastroCliente;
    }
}