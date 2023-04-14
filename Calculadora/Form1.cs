namespace Calculadora {
    public partial class Calculadora : Form {
        public Calculadora() {
            InitializeComponent();
        }

        public double primeiroValor;
        public double segundoValor;
        public string operacao = "";


        private void btnPonto_Click(object sender, EventArgs e) {
            if (txtResultado.Text.Contains(",")) {
            } else {
                txtResultado.Text += ",";
                txtResultado2.Text += ",";
            }

        }

        private void btn1_Click(object sender, EventArgs e) {
            txtResultado.Text += "1";
            txtResultado2.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e) {
            txtResultado.Text += "2";
            txtResultado2.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e) {
            txtResultado.Text += "3";
            txtResultado2.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e) {
            txtResultado.Text += "4";
            txtResultado2.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e) {
            txtResultado.Text += "5";
            txtResultado2.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e) {
            txtResultado.Text += "6";
            txtResultado2.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e) {
            txtResultado.Text += "7";
            txtResultado2.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e) {
            txtResultado.Text += "8";
            txtResultado2.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e) {
            txtResultado.Text += "9";
            txtResultado2.Text += "9";
        }
        private void btn0_Click(object sender, EventArgs e) {
            txtResultado.Text += "0";
            txtResultado2.Text += "0";
        }

        private void btnSoma_Click(object sender, EventArgs e) {
            operacao = "+";
            if (txtResultado2.Text.Contains("+") || txtResultado2.Text.Contains("-") || txtResultado2.Text.Contains("/") || txtResultado2.Text.Contains("*")) {
            } else {
                primeiroValor = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                txtResultado2.Text += "+";
            }
        }
        public static double somar(double a, double b) {
            return a + b;
        }
        public static double subtrair(double a, double b) {
            return a - b;
        }
        public static double dividir(double a, double b) {
            return a / b;
        }
        public static double multiplicar(double a, double b) {
            return a * b;
        }

        private void btnIgual_Click(object sender, EventArgs e) {
            segundoValor = double.Parse(txtResultado.Text);
            if (operacao == "+") {
                txtResultado.Text = somar(primeiroValor, segundoValor).ToString();
            } else if (operacao == "-") {
                txtResultado.Text = subtrair(primeiroValor, segundoValor).ToString();
            } else if (operacao == "*") {
                txtResultado.Text = multiplicar(primeiroValor, segundoValor).ToString();
            } else if (operacao == "/") {
                txtResultado.Text = dividir(primeiroValor, segundoValor).ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtResultado.Text = "";
            txtResultado2.Text = "";

        }

        private void btnLimparTudo_Click(object sender, EventArgs e) {
            if (txtResultado.Text.Length <= 0 || txtResultado2.Text.Length <= 0) {
            } else {
                txtResultado.Text = txtResultado.Text.Remove(txtResultado.Text.Length - 1);
                txtResultado2.Text = txtResultado2.Text.Remove(txtResultado2.Text.Length - 1);
            }

        }

        private void btnSubtracao_Click(object sender, EventArgs e) {
            operacao = "-";
            if (txtResultado2.Text.Contains("+") || txtResultado2.Text.Contains("-") || txtResultado2.Text.Contains("/") || txtResultado2.Text.Contains("*")) {
            } else {
                primeiroValor = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                txtResultado2.Text += "-";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e) {
            operacao = "/";
            if (txtResultado2.Text.Contains("+") || txtResultado2.Text.Contains("-") || txtResultado2.Text.Contains("/") || txtResultado2.Text.Contains("*")) {
            } else {
                primeiroValor = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                txtResultado2.Text += "/";
            }
        }

        private void btnMulticacao_Click(object sender, EventArgs e) {
            operacao = "*";
            if (txtResultado2.Text.Contains("+") || txtResultado2.Text.Contains("-") || txtResultado2.Text.Contains("/") || txtResultado2.Text.Contains("*")) {
            } else {
                primeiroValor = float.Parse(txtResultado.Text);
                txtResultado.Text = "";
                txtResultado2.Text += "*";
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e) {
            if (txtResultado.Text.Length <= 0) {
            } else {
                txtResultado.Text = (float.Parse(txtResultado.Text) / 100).ToString();
                txtResultado2.Text += txtResultado.Text;
                if (txtResultado2.Text.Contains("+") || txtResultado2.Text.Contains("-") || txtResultado2.Text.Contains("/") || txtResultado2.Text.Contains("*")) {
                    txtResultado2.Text = txtResultado2.Text.Substring(txtResultado2.Text.LastIndexOf("+"));
                }
            }
        }
    }
}


