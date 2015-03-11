namespace Calculadora
{
    partial class calculadora
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
            this.textoPrimeiroValor = new System.Windows.Forms.TextBox();
            this.textoSegundoValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exibicaoResultado = new System.Windows.Forms.Label();
            this.botaoSomar = new System.Windows.Forms.Button();
            this.botaoSubtrair = new System.Windows.Forms.Button();
            this.botaoMultiplicar = new System.Windows.Forms.Button();
            this.botaoDividir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoPrimeiroValor
            // 
            this.textoPrimeiroValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPrimeiroValor.Location = new System.Drawing.Point(12, 130);
            this.textoPrimeiroValor.Name = "textoPrimeiroValor";
            this.textoPrimeiroValor.Size = new System.Drawing.Size(130, 50);
            this.textoPrimeiroValor.TabIndex = 0;
            // 
            // textoSegundoValor
            // 
            this.textoSegundoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSegundoValor.Location = new System.Drawing.Point(12, 224);
            this.textoSegundoValor.Name = "textoSegundoValor";
            this.textoSegundoValor.Size = new System.Drawing.Size(130, 50);
            this.textoSegundoValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primeiro valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoDividir);
            this.groupBox1.Controls.Add(this.botaoMultiplicar);
            this.groupBox1.Controls.Add(this.botaoSubtrair);
            this.groupBox1.Controls.Add(this.botaoSomar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(168, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // exibicaoResultado
            // 
            this.exibicaoResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exibicaoResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibicaoResultado.Location = new System.Drawing.Point(12, 20);
            this.exibicaoResultado.Name = "exibicaoResultado";
            this.exibicaoResultado.Size = new System.Drawing.Size(353, 64);
            this.exibicaoResultado.TabIndex = 5;
            this.exibicaoResultado.Text = "     ";
            // 
            // botaoSomar
            // 
            this.botaoSomar.Location = new System.Drawing.Point(21, 45);
            this.botaoSomar.Name = "botaoSomar";
            this.botaoSomar.Size = new System.Drawing.Size(75, 42);
            this.botaoSomar.TabIndex = 0;
            this.botaoSomar.Text = "+";
            this.botaoSomar.UseVisualStyleBackColor = true;
            this.botaoSomar.Click += new System.EventHandler(this.botaoSomar_Click);
            // 
            // botaoSubtrair
            // 
            this.botaoSubtrair.Location = new System.Drawing.Point(102, 45);
            this.botaoSubtrair.Name = "botaoSubtrair";
            this.botaoSubtrair.Size = new System.Drawing.Size(75, 42);
            this.botaoSubtrair.TabIndex = 1;
            this.botaoSubtrair.Text = "-";
            this.botaoSubtrair.UseVisualStyleBackColor = true;
            // 
            // botaoMultiplicar
            // 
            this.botaoMultiplicar.Location = new System.Drawing.Point(21, 93);
            this.botaoMultiplicar.Name = "botaoMultiplicar";
            this.botaoMultiplicar.Size = new System.Drawing.Size(75, 42);
            this.botaoMultiplicar.TabIndex = 2;
            this.botaoMultiplicar.Text = "*";
            this.botaoMultiplicar.UseVisualStyleBackColor = true;
            // 
            // botaoDividir
            // 
            this.botaoDividir.Location = new System.Drawing.Point(102, 93);
            this.botaoDividir.Name = "botaoDividir";
            this.botaoDividir.Size = new System.Drawing.Size(75, 42);
            this.botaoDividir.TabIndex = 3;
            this.botaoDividir.Text = "/";
            this.botaoDividir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 322);
            this.Controls.Add(this.exibicaoResultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoSegundoValor);
            this.Controls.Add(this.textoPrimeiroValor);
            this.Name = "Form1";
            this.Text = "Calculadora - C# :: Janynne Gomes";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoPrimeiroValor;
        private System.Windows.Forms.TextBox textoSegundoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label exibicaoResultado;
        private System.Windows.Forms.Button botaoDividir;
        private System.Windows.Forms.Button botaoMultiplicar;
        private System.Windows.Forms.Button botaoSubtrair;
        private System.Windows.Forms.Button botaoSomar;
    }
}

