namespace Calculadora
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
            this.resultado = new System.Windows.Forms.TextBox();
            this.limpa = new System.Windows.Forms.Button();
            this.op_divisao = new System.Windows.Forms.Button();
            this.op_multiplicacao = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.op_subtracao = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.op_soma = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.op_igual = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.Location = new System.Drawing.Point(13, 32);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(370, 23);
            this.resultado.TabIndex = 0;
            // 
            // limpa
            // 
            this.limpa.Location = new System.Drawing.Point(298, 115);
            this.limpa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.limpa.Name = "limpa";
            this.limpa.Size = new System.Drawing.Size(88, 48);
            this.limpa.TabIndex = 1;
            this.limpa.Text = "C";
            this.limpa.UseVisualStyleBackColor = true;
            this.limpa.Click += new System.EventHandler(this.limpa_Click);
            // 
            // op_divisao
            // 
            this.op_divisao.BackColor = System.Drawing.Color.Gold;
            this.op_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_divisao.Location = new System.Drawing.Point(298, 61);
            this.op_divisao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.op_divisao.Name = "op_divisao";
            this.op_divisao.Size = new System.Drawing.Size(88, 48);
            this.op_divisao.TabIndex = 4;
            this.op_divisao.Text = "/";
            this.op_divisao.UseVisualStyleBackColor = false;
            this.op_divisao.Click += new System.EventHandler(this.op_divisao_Click);
            // 
            // op_multiplicacao
            // 
            this.op_multiplicacao.BackColor = System.Drawing.Color.Gold;
            this.op_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_multiplicacao.Location = new System.Drawing.Point(203, 61);
            this.op_multiplicacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.op_multiplicacao.Name = "op_multiplicacao";
            this.op_multiplicacao.Size = new System.Drawing.Size(88, 48);
            this.op_multiplicacao.TabIndex = 8;
            this.op_multiplicacao.Text = "X";
            this.op_multiplicacao.UseVisualStyleBackColor = false;
            this.op_multiplicacao.Click += new System.EventHandler(this.op_multiplicacao_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(203, 115);
            this.btn9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(88, 48);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(108, 115);
            this.btn8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 48);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(14, 115);
            this.btn7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(88, 48);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // op_subtracao
            // 
            this.op_subtracao.BackColor = System.Drawing.Color.Gold;
            this.op_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_subtracao.Location = new System.Drawing.Point(108, 61);
            this.op_subtracao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.op_subtracao.Name = "op_subtracao";
            this.op_subtracao.Size = new System.Drawing.Size(88, 48);
            this.op_subtracao.TabIndex = 12;
            this.op_subtracao.Text = "-";
            this.op_subtracao.UseVisualStyleBackColor = false;
            this.op_subtracao.Click += new System.EventHandler(this.op_subtracao_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(203, 169);
            this.btn6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(88, 48);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(108, 169);
            this.btn5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 48);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(14, 169);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 48);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // op_soma
            // 
            this.op_soma.BackColor = System.Drawing.Color.Gold;
            this.op_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_soma.Location = new System.Drawing.Point(14, 61);
            this.op_soma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.op_soma.Name = "op_soma";
            this.op_soma.Size = new System.Drawing.Size(88, 48);
            this.op_soma.TabIndex = 16;
            this.op_soma.Text = "+";
            this.op_soma.UseVisualStyleBackColor = false;
            this.op_soma.Click += new System.EventHandler(this.op_soma_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(203, 223);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 48);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(108, 223);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 48);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 223);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 48);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // op_igual
            // 
            this.op_igual.BackColor = System.Drawing.Color.ForestGreen;
            this.op_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_igual.Location = new System.Drawing.Point(298, 169);
            this.op_igual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.op_igual.Name = "op_igual";
            this.op_igual.Size = new System.Drawing.Size(88, 156);
            this.op_igual.TabIndex = 20;
            this.op_igual.Text = "=";
            this.op_igual.UseVisualStyleBackColor = false;
            this.op_igual.Click += new System.EventHandler(this.op_igual_Click);
            // 
            // virgula
            // 
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(203, 277);
            this.virgula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(88, 48);
            this.virgula.TabIndex = 19;
            this.virgula.Text = ".";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(14, 277);
            this.btn0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(182, 48);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.Location = new System.Drawing.Point(0, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(100, 23);
            this.lblOperacao.TabIndex = 0;
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(0, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(100, 23);
            this.lblResultado.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(15, 7);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(117, 14);
            this.lblResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 330);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.op_igual);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.op_soma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.op_subtracao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.op_multiplicacao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.op_divisao);
            this.Controls.Add(this.limpa);
            this.Controls.Add(this.resultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button limpa;
        private System.Windows.Forms.Button op_divisao;
        private System.Windows.Forms.Button op_multiplicacao;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button op_subtracao;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button op_soma;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button op_igual;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResult;
    }
}

