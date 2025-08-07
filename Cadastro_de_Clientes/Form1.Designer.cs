namespace Cadastro_de_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelMenssagem1 = new System.Windows.Forms.Label();
            this.labelMenssagem2 = new System.Windows.Forms.Label();
            this.labelMenssagem3 = new System.Windows.Forms.Label();
            this.labelMenssagem4 = new System.Windows.Forms.Label();
            this.labelMenssagem0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite seu Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite seu E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite sua Idade";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(247, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(500, 35);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(303, 114);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(444, 35);
            this.textBoxSobrenome.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(252, 167);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(500, 35);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdade.Location = new System.Drawing.Point(247, 227);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(500, 35);
            this.textBoxIdade.TabIndex = 4;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.Location = new System.Drawing.Point(725, 326);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(260, 40);
            this.buttonEnviar.TabIndex = 5;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFechar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFechar.Image")));
            this.buttonFechar.Location = new System.Drawing.Point(731, 406);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(254, 109);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // labelMenssagem1
            // 
            this.labelMenssagem1.AutoSize = true;
            this.labelMenssagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenssagem1.Location = new System.Drawing.Point(70, 383);
            this.labelMenssagem1.Name = "labelMenssagem1";
            this.labelMenssagem1.Size = new System.Drawing.Size(0, 29);
            this.labelMenssagem1.TabIndex = 7;
            // 
            // labelMenssagem2
            // 
            this.labelMenssagem2.AutoSize = true;
            this.labelMenssagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenssagem2.Location = new System.Drawing.Point(302, 383);
            this.labelMenssagem2.Name = "labelMenssagem2";
            this.labelMenssagem2.Size = new System.Drawing.Size(0, 29);
            this.labelMenssagem2.TabIndex = 8;
            // 
            // labelMenssagem3
            // 
            this.labelMenssagem3.AutoSize = true;
            this.labelMenssagem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenssagem3.Location = new System.Drawing.Point(70, 432);
            this.labelMenssagem3.Name = "labelMenssagem3";
            this.labelMenssagem3.Size = new System.Drawing.Size(0, 29);
            this.labelMenssagem3.TabIndex = 9;
            // 
            // labelMenssagem4
            // 
            this.labelMenssagem4.AutoSize = true;
            this.labelMenssagem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenssagem4.Location = new System.Drawing.Point(486, 406);
            this.labelMenssagem4.Name = "labelMenssagem4";
            this.labelMenssagem4.Size = new System.Drawing.Size(0, 29);
            this.labelMenssagem4.TabIndex = 10;
            // 
            // labelMenssagem0
            // 
            this.labelMenssagem0.AutoSize = true;
            this.labelMenssagem0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenssagem0.Location = new System.Drawing.Point(70, 326);
            this.labelMenssagem0.Name = "labelMenssagem0";
            this.labelMenssagem0.Size = new System.Drawing.Size(0, 29);
            this.labelMenssagem0.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 513);
            this.Controls.Add(this.labelMenssagem0);
            this.Controls.Add(this.labelMenssagem4);
            this.Controls.Add(this.labelMenssagem3);
            this.Controls.Add(this.labelMenssagem2);
            this.Controls.Add(this.labelMenssagem1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label labelMenssagem1;
        private System.Windows.Forms.Label labelMenssagem2;
        private System.Windows.Forms.Label labelMenssagem3;
        private System.Windows.Forms.Label labelMenssagem4;
        private System.Windows.Forms.Label labelMenssagem0;
    }
}

