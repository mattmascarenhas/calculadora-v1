namespace Calculadora {
    partial class Calculadora {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtResultado = new TextBox();
            btnPonto = new Button();
            btnIgual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btnPorcentagem = new Button();
            btnLimpar = new Button();
            btnLimparTudo = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnDivisao = new Button();
            btnMulticacao = new Button();
            btn0 = new Button();
            txtResultado2 = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.AutoCompleteSource = AutoCompleteSource.FileSystem;
            txtResultado.BackColor = SystemColors.ActiveCaptionText;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Segoe UI", 70F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.ForeColor = Color.PaleTurquoise;
            txtResultado.Location = new Point(11, 61);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(374, 125);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnPonto
            // 
            btnPonto.BackColor = Color.Gray;
            btnPonto.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnPonto.ForeColor = SystemColors.Control;
            btnPonto.Location = new Point(11, 521);
            btnPonto.Margin = new Padding(5);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(86, 71);
            btnPonto.TabIndex = 1;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = false;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Gray;
            btnIgual.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnIgual.ForeColor = SystemColors.Control;
            btnIgual.Location = new Point(201, 522);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(182, 69);
            btnIgual.TabIndex = 4;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(  64,   64,   64);
            btn1.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn1.ForeColor = SystemColors.Control;
            btn1.Location = new Point(11, 442);
            btn1.Margin = new Padding(5);
            btn1.Name = "btn1";
            btn1.Size = new Size(86, 71);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(  64,   64,   64);
            btn2.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn2.ForeColor = SystemColors.Control;
            btn2.Location = new Point(108, 442);
            btn2.Margin = new Padding(5);
            btn2.Name = "btn2";
            btn2.Size = new Size(86, 71);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(  64,   64,   64);
            btn3.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn3.ForeColor = SystemColors.Control;
            btn3.Location = new Point(203, 442);
            btn3.Margin = new Padding(5);
            btn3.Name = "btn3";
            btn3.Size = new Size(86, 71);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(  64,   64,   64);
            btn9.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn9.ForeColor = SystemColors.Control;
            btn9.Location = new Point(203, 282);
            btn9.Margin = new Padding(5);
            btn9.Name = "btn9";
            btn9.Size = new Size(86, 71);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(  64,   64,   64);
            btn8.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn8.ForeColor = SystemColors.Control;
            btn8.Location = new Point(107, 282);
            btn8.Margin = new Padding(5);
            btn8.Name = "btn8";
            btn8.Size = new Size(86, 71);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(  64,   64,   64);
            btn5.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn5.ForeColor = SystemColors.Control;
            btn5.Location = new Point(107, 361);
            btn5.Margin = new Padding(5);
            btn5.Name = "btn5";
            btn5.Size = new Size(86, 71);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(  64,   64,   64);
            btn6.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn6.ForeColor = SystemColors.Control;
            btn6.Location = new Point(203, 361);
            btn6.Margin = new Padding(5);
            btn6.Name = "btn6";
            btn6.Size = new Size(86, 71);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(  64,   64,   64);
            btn7.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn7.ForeColor = SystemColors.Control;
            btn7.Location = new Point(11, 282);
            btn7.Margin = new Padding(5);
            btn7.Name = "btn7";
            btn7.Size = new Size(86, 71);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(  64,   64,   64);
            btn4.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn4.ForeColor = SystemColors.Control;
            btn4.Location = new Point(11, 361);
            btn4.Margin = new Padding(5);
            btn4.Name = "btn4";
            btn4.Size = new Size(86, 71);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.Gray;
            btnPorcentagem.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnPorcentagem.ForeColor = SystemColors.Control;
            btnPorcentagem.Location = new Point(203, 201);
            btnPorcentagem.Margin = new Padding(5);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(86, 71);
            btnPorcentagem.TabIndex = 18;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.Font = new Font("Segoe UI", 41F, FontStyle.Bold, GraphicsUnit.World);
            btnLimpar.ForeColor = SystemColors.Control;
            btnLimpar.Location = new Point(107, 201);
            btnLimpar.Margin = new Padding(5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 71);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "AC";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnLimparTudo
            // 
            btnLimparTudo.BackColor = Color.Gray;
            btnLimparTudo.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnLimparTudo.ForeColor = SystemColors.Control;
            btnLimparTudo.Location = new Point(11, 201);
            btnLimparTudo.Margin = new Padding(5);
            btnLimparTudo.Name = "btnLimparTudo";
            btnLimparTudo.Size = new Size(86, 71);
            btnLimparTudo.TabIndex = 16;
            btnLimparTudo.Text = "C";
            btnLimparTudo.UseVisualStyleBackColor = false;
            btnLimparTudo.Click += btnLimparTudo_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.Gray;
            btnSoma.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnSoma.ForeColor = SystemColors.Control;
            btnSoma.Location = new Point(299, 201);
            btnSoma.Margin = new Padding(5);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(86, 71);
            btnSoma.TabIndex = 22;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Gray;
            btnSubtracao.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnSubtracao.ForeColor = SystemColors.Control;
            btnSubtracao.Location = new Point(299, 282);
            btnSubtracao.Margin = new Padding(5);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(86, 71);
            btnSubtracao.TabIndex = 21;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Gray;
            btnDivisao.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnDivisao.ForeColor = SystemColors.Control;
            btnDivisao.Location = new Point(299, 361);
            btnDivisao.Margin = new Padding(5);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(86, 71);
            btnDivisao.TabIndex = 20;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMulticacao
            // 
            btnMulticacao.BackColor = Color.Gray;
            btnMulticacao.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btnMulticacao.ForeColor = SystemColors.Control;
            btnMulticacao.Location = new Point(299, 442);
            btnMulticacao.Margin = new Padding(5);
            btnMulticacao.Name = "btnMulticacao";
            btnMulticacao.Size = new Size(86, 71);
            btnMulticacao.TabIndex = 19;
            btnMulticacao.Text = "X";
            btnMulticacao.UseVisualStyleBackColor = false;
            btnMulticacao.Click += btnMulticacao_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(  64,   64,   64);
            btn0.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.World);
            btn0.ForeColor = SystemColors.Control;
            btn0.Location = new Point(107, 522);
            btn0.Margin = new Padding(5);
            btn0.Name = "btn0";
            btn0.Size = new Size(86, 71);
            btn0.TabIndex = 23;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // txtResultado2
            // 
            txtResultado2.BackColor = SystemColors.ActiveCaptionText;
            txtResultado2.BorderStyle = BorderStyle.None;
            txtResultado2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado2.ForeColor = Color.PaleTurquoise;
            txtResultado2.Location = new Point(11, 25);
            txtResultado2.Name = "txtResultado2";
            txtResultado2.Size = new Size(374, 36);
            txtResultado2.TabIndex = 24;
            txtResultado2.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(392, 601);
            Controls.Add(txtResultado2);
            Controls.Add(btn0);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtracao);
            Controls.Add(btnDivisao);
            Controls.Add(btnMulticacao);
            Controls.Add(btnPorcentagem);
            Controls.Add(btnLimpar);
            Controls.Add(btnLimparTudo);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "Calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnPonto;
        private Button btnIgual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn9;
        private Button btn8;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn4;
        private Button btnPorcentagem;
        private Button btnLimpar;
        private Button btnLimparTudo;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnDivisao;
        private Button btnMulticacao;
        private Button btn0;
        private TextBox txtResultado2;
    }
}