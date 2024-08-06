namespace calculadoravuelto
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_montoingresado = new System.Windows.Forms.Label();
            this.lbl_valorproducto = new System.Windows.Forms.Label();
            this.btn_vuelto = new System.Windows.Forms.Button();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lbl_montoingresado
            // 
            this.lbl_montoingresado.AutoSize = true;
            this.lbl_montoingresado.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoingresado.ForeColor = System.Drawing.Color.White;
            this.lbl_montoingresado.Location = new System.Drawing.Point(93, 45);
            this.lbl_montoingresado.Name = "lbl_montoingresado";
            this.lbl_montoingresado.Size = new System.Drawing.Size(90, 15);
            this.lbl_montoingresado.TabIndex = 2;
            this.lbl_montoingresado.Text = "Monto Ingresado:";
            this.lbl_montoingresado.Click += new System.EventHandler(this.lbl_montoingresado_Click);
            // 
            // lbl_valorproducto
            // 
            this.lbl_valorproducto.AutoSize = true;
            this.lbl_valorproducto.Font = new System.Drawing.Font("Trebuchet MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorproducto.ForeColor = System.Drawing.Color.White;
            this.lbl_valorproducto.Location = new System.Drawing.Point(93, 95);
            this.lbl_valorproducto.Name = "lbl_valorproducto";
            this.lbl_valorproducto.Size = new System.Drawing.Size(99, 15);
            this.lbl_valorproducto.TabIndex = 3;
            this.lbl_valorproducto.Text = "Valor del producto:";
            // 
            // btn_vuelto
            // 
            this.btn_vuelto.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vuelto.Location = new System.Drawing.Point(92, 150);
            this.btn_vuelto.Name = "btn_vuelto";
            this.btn_vuelto.Size = new System.Drawing.Size(100, 23);
            this.btn_vuelto.TabIndex = 4;
            this.btn_vuelto.Text = "Calcular vuelto";
            this.btn_vuelto.UseVisualStyleBackColor = true;
            this.btn_vuelto.Click += new System.EventHandler(this.btn_vuelto_Click);
            // 
            // lbl_resul
            // 
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.Location = new System.Drawing.Point(43, 192);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(0, 13);
            this.lbl_resul.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 349);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.btn_vuelto);
            this.Controls.Add(this.lbl_valorproducto);
            this.Controls.Add(this.lbl_montoingresado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de vuelto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_montoingresado;
        private System.Windows.Forms.Label lbl_valorproducto;
        private System.Windows.Forms.Button btn_vuelto;
        private System.Windows.Forms.Label lbl_resul;
    }
}

