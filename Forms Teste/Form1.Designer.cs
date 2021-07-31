
namespace Forms_Teste
{
    partial class Form1
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
            this.btn_consultar = new System.Windows.Forms.Button();
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(163, 29);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 0;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(12, 29);
            this.tb_cep.MaxLength = 8;
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(145, 20);
            this.tb_cep.TabIndex = 1;
            // 
            // tb_resultado
            // 
            this.tb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_resultado.Location = new System.Drawing.Point(254, 9);
            this.tb_resultado.Multiline = true;
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.ReadOnly = true;
            this.tb_resultado.Size = new System.Drawing.Size(358, 300);
            this.tb_resultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe um CEP:";
            // 
            // lb_aviso
            // 
            this.lb_aviso.AutoSize = true;
            this.lb_aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_aviso.ForeColor = System.Drawing.Color.Red;
            this.lb_aviso.Location = new System.Drawing.Point(10, 61);
            this.lb_aviso.Name = "lb_aviso";
            this.lb_aviso.Size = new System.Drawing.Size(0, 13);
            this.lb_aviso.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.lb_aviso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.btn_consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Consulta de CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox tb_cep;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_aviso;
    }
}

