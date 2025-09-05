namespace Cadastro_de_Clientes
{
    partial class ConsultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCliente));
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GridClientes
            // 
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Location = new System.Drawing.Point(25, 24);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.Size = new System.Drawing.Size(459, 396);
            this.GridClientes.TabIndex = 0;
            // 
            // buttonFechar
            // 
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFechar.Image = ((System.Drawing.Image)(resources.GetObject("buttonFechar.Image")));
            this.buttonFechar.Location = new System.Drawing.Point(510, 229);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(248, 98);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(543, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Listar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.GridClientes);
            this.Name = "ConsultaCliente";
            this.Text = "ConsultaCliente";
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button button1;
    }
}