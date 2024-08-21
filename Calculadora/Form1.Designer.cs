
namespace Calculadora
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
            this.LabelN1 = new System.Windows.Forms.Label();
            this.LabelN2 = new System.Windows.Forms.Label();
            this.RDBsumar = new System.Windows.Forms.RadioButton();
            this.RDBrestar = new System.Windows.Forms.RadioButton();
            this.RDBmultiplicar = new System.Windows.Forms.RadioButton();
            this.RDBdividir = new System.Windows.Forms.RadioButton();
            this.Numero1Text = new System.Windows.Forms.TextBox();
            this.Numero2Text = new System.Windows.Forms.TextBox();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.ResultadoText = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelN1
            // 
            this.LabelN1.AutoSize = true;
            this.LabelN1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelN1.Location = new System.Drawing.Point(42, 52);
            this.LabelN1.Name = "LabelN1";
            this.LabelN1.Size = new System.Drawing.Size(67, 19);
            this.LabelN1.TabIndex = 0;
            this.LabelN1.Text = "Numero1";
            this.LabelN1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelN2
            // 
            this.LabelN2.AutoSize = true;
            this.LabelN2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelN2.Location = new System.Drawing.Point(42, 87);
            this.LabelN2.Name = "LabelN2";
            this.LabelN2.Size = new System.Drawing.Size(67, 19);
            this.LabelN2.TabIndex = 1;
            this.LabelN2.Text = "Numero2";
            // 
            // RDBsumar
            // 
            this.RDBsumar.AutoSize = true;
            this.RDBsumar.Location = new System.Drawing.Point(257, 53);
            this.RDBsumar.Name = "RDBsumar";
            this.RDBsumar.Size = new System.Drawing.Size(59, 19);
            this.RDBsumar.TabIndex = 2;
            this.RDBsumar.TabStop = true;
            this.RDBsumar.Text = "Sumar";
            this.RDBsumar.UseVisualStyleBackColor = true;
            // 
            // RDBrestar
            // 
            this.RDBrestar.AutoSize = true;
            this.RDBrestar.Location = new System.Drawing.Point(257, 78);
            this.RDBrestar.Name = "RDBrestar";
            this.RDBrestar.Size = new System.Drawing.Size(57, 19);
            this.RDBrestar.TabIndex = 3;
            this.RDBrestar.TabStop = true;
            this.RDBrestar.Text = "Restar";
            this.RDBrestar.UseVisualStyleBackColor = true;
            // 
            // RDBmultiplicar
            // 
            this.RDBmultiplicar.AutoSize = true;
            this.RDBmultiplicar.Location = new System.Drawing.Point(257, 100);
            this.RDBmultiplicar.Name = "RDBmultiplicar";
            this.RDBmultiplicar.Size = new System.Drawing.Size(82, 19);
            this.RDBmultiplicar.TabIndex = 4;
            this.RDBmultiplicar.TabStop = true;
            this.RDBmultiplicar.Text = "Multiplicar";
            this.RDBmultiplicar.UseVisualStyleBackColor = true;
            // 
            // RDBdividir
            // 
            this.RDBdividir.AutoSize = true;
            this.RDBdividir.Location = new System.Drawing.Point(257, 125);
            this.RDBdividir.Name = "RDBdividir";
            this.RDBdividir.Size = new System.Drawing.Size(59, 19);
            this.RDBdividir.TabIndex = 5;
            this.RDBdividir.TabStop = true;
            this.RDBdividir.Text = "Dividir";
            this.RDBdividir.UseVisualStyleBackColor = true;
            // 
            // Numero1Text
            // 
            this.Numero1Text.Location = new System.Drawing.Point(116, 49);
            this.Numero1Text.Name = "Numero1Text";
            this.Numero1Text.Size = new System.Drawing.Size(100, 23);
            this.Numero1Text.TabIndex = 6;
            this.Numero1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Numero2Text
            // 
            this.Numero2Text.Location = new System.Drawing.Point(116, 87);
            this.Numero2Text.Name = "Numero2Text";
            this.Numero2Text.Size = new System.Drawing.Size(100, 23);
            this.Numero2Text.TabIndex = 7;
            this.Numero2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelResultado
            // 
            this.LabelResultado.AutoSize = true;
            this.LabelResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelResultado.Location = new System.Drawing.Point(42, 125);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(69, 19);
            this.LabelResultado.TabIndex = 8;
            this.LabelResultado.Text = "Resultado";
            // 
            // ResultadoText
            // 
            this.ResultadoText.Location = new System.Drawing.Point(116, 124);
            this.ResultadoText.Name = "ResultadoText";
            this.ResultadoText.ReadOnly = true;
            this.ResultadoText.Size = new System.Drawing.Size(100, 23);
            this.ResultadoText.TabIndex = 9;
            this.ResultadoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Red;
            this.BtnCalcular.Location = new System.Drawing.Point(257, 181);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(98, 38);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(386, 231);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.ResultadoText);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.Numero2Text);
            this.Controls.Add(this.Numero1Text);
            this.Controls.Add(this.RDBdividir);
            this.Controls.Add(this.RDBmultiplicar);
            this.Controls.Add(this.RDBrestar);
            this.Controls.Add(this.RDBsumar);
            this.Controls.Add(this.LabelN2);
            this.Controls.Add(this.LabelN1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelN1;
        private System.Windows.Forms.Label LabelN2;
        private System.Windows.Forms.RadioButton RDBsumar;
        private System.Windows.Forms.RadioButton RDBrestar;
        private System.Windows.Forms.RadioButton RDBmultiplicar;
        private System.Windows.Forms.RadioButton RDBdividir;
        private System.Windows.Forms.TextBox Numero1Text;
        private System.Windows.Forms.TextBox Numero2Text;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.TextBox ResultadoText;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

