namespace FormularioBDD2102A_106
{
    partial class Impuestos
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblIngresos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGastos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblImpRenta = new System.Windows.Forms.Label();
            this.LblIdContr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos";
            // 
            // LblIngresos
            // 
            this.LblIngresos.AutoSize = true;
            this.LblIngresos.Location = new System.Drawing.Point(122, 51);
            this.LblIngresos.Name = "LblIngresos";
            this.LblIngresos.Size = new System.Drawing.Size(0, 13);
            this.LblIngresos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gastos";
            // 
            // LblGastos
            // 
            this.LblGastos.AutoSize = true;
            this.LblGastos.Location = new System.Drawing.Point(122, 98);
            this.LblGastos.Name = "LblGastos";
            this.LblGastos.Size = new System.Drawing.Size(0, 13);
            this.LblGastos.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Formulario 106";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Impuesto a la renta";
            // 
            // LblImpRenta
            // 
            this.LblImpRenta.AutoSize = true;
            this.LblImpRenta.Location = new System.Drawing.Point(213, 173);
            this.LblImpRenta.Name = "LblImpRenta";
            this.LblImpRenta.Size = new System.Drawing.Size(0, 13);
            this.LblImpRenta.TabIndex = 7;
            // 
            // LblIdContr
            // 
            this.LblIdContr.AutoSize = true;
            this.LblIdContr.Location = new System.Drawing.Point(390, 285);
            this.LblIdContr.Name = "LblIdContr";
            this.LblIdContr.Size = new System.Drawing.Size(0, 13);
            this.LblIdContr.TabIndex = 9;
            this.LblIdContr.Visible = false;
            // 
            // Impuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 331);
            this.Controls.Add(this.LblIdContr);
            this.Controls.Add(this.LblImpRenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblGastos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblIngresos);
            this.Controls.Add(this.label1);
            this.Name = "Impuestos";
            this.Text = "Impuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIngresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGastos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblImpRenta;
        private System.Windows.Forms.Label LblIdContr;
    }
}