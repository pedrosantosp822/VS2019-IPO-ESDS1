
namespace IPO
{
    partial class frmIPO
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVeiculos = new System.Windows.Forms.Button();
            this.btnInspecoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(430, 99);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "&Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVeiculos
            // 
            this.btnVeiculos.Location = new System.Drawing.Point(12, 117);
            this.btnVeiculos.Name = "btnVeiculos";
            this.btnVeiculos.Size = new System.Drawing.Size(430, 99);
            this.btnVeiculos.TabIndex = 1;
            this.btnVeiculos.Text = "&Veículos";
            this.btnVeiculos.UseVisualStyleBackColor = true;
            // 
            // btnInspecoes
            // 
            this.btnInspecoes.Location = new System.Drawing.Point(12, 222);
            this.btnInspecoes.Name = "btnInspecoes";
            this.btnInspecoes.Size = new System.Drawing.Size(430, 99);
            this.btnInspecoes.TabIndex = 2;
            this.btnInspecoes.Text = "&Inspeções";
            this.btnInspecoes.UseVisualStyleBackColor = true;
            // 
            // frmIPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 336);
            this.Controls.Add(this.btnInspecoes);
            this.Controls.Add(this.btnVeiculos);
            this.Controls.Add(this.btnClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIPO";
            this.Text = "IPO - Inspeções Periódicas Obrigatórias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Button btnInspecoes;
    }
}