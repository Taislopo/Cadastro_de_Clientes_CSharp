namespace Cadastro_de_Clientes
{
    partial class Painel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painel));
            this.buttonConsultaCliente = new System.Windows.Forms.Button();
            this.buttonCadastroCliente = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConsultaCliente
            // 
            this.buttonConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultaCliente.Location = new System.Drawing.Point(106, 119);
            this.buttonConsultaCliente.Name = "buttonConsultaCliente";
            this.buttonConsultaCliente.Size = new System.Drawing.Size(231, 78);
            this.buttonConsultaCliente.TabIndex = 0;
            this.buttonConsultaCliente.Text = "Consulta de Clientes";
            this.buttonConsultaCliente.UseVisualStyleBackColor = true;
            this.buttonConsultaCliente.Click += new System.EventHandler(this.buttonConsultaCliente_Click);
            // 
            // buttonCadastroCliente
            // 
            this.buttonCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroCliente.Location = new System.Drawing.Point(430, 119);
            this.buttonCadastroCliente.Name = "buttonCadastroCliente";
            this.buttonCadastroCliente.Size = new System.Drawing.Size(231, 78);
            this.buttonCadastroCliente.TabIndex = 1;
            this.buttonCadastroCliente.Text = "Cadastro de Clientes";
            this.buttonCadastroCliente.UseVisualStyleBackColor = true;
            this.buttonCadastroCliente.Click += new System.EventHandler(this.buttonCadastroCliente_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFechar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFechar.Image")));
            this.buttonFechar.Location = new System.Drawing.Point(249, 247);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(254, 109);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonCadastroCliente);
            this.Controls.Add(this.buttonConsultaCliente);
            this.Name = "Painel";
            this.Text = "Painel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConsultaCliente;
        private System.Windows.Forms.Button buttonCadastroCliente;
        private System.Windows.Forms.Button buttonFechar;
    }
}