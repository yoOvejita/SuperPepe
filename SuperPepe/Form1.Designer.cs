namespace SuperPepe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCompilado = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.txtSLM = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(107, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 15);
            this.lblCodigo.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Compilar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCompilado
            // 
            this.lblCompilado.AutoSize = true;
            this.lblCompilado.Location = new System.Drawing.Point(107, 45);
            this.lblCompilado.Name = "lblCompilado";
            this.lblCompilado.Size = new System.Drawing.Size(0, 15);
            this.lblCompilado.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ejecutar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContenido.Location = new System.Drawing.Point(16, 70);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(322, 295);
            this.txtContenido.TabIndex = 5;
            this.txtContenido.Text = "";
            // 
            // txtSLM
            // 
            this.txtSLM.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSLM.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSLM.ForeColor = System.Drawing.Color.Lime;
            this.txtSLM.Location = new System.Drawing.Point(350, 70);
            this.txtSLM.Name = "txtSLM";
            this.txtSLM.Size = new System.Drawing.Size(132, 295);
            this.txtSLM.TabIndex = 6;
            this.txtSLM.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 405);
            this.Controls.Add(this.txtSLM);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblCompilado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "SuperPepe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCompilado;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.RichTextBox txtSLM;
    }
}
