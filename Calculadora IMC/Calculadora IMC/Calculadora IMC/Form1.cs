namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        // Método para adicionar números aos campos de texto de Peso ou Altura
        private void addNumber(object sender, EventArgs e)
        {
            // Verifica se o campo 'txtPeso' está em foco (cor de fundo vermelha)
            if (txtPeso.BackColor == Color.Red)
            {
                // Verifica se o botão pressionado não é uma vírgula ou se o campo 'txtPeso' já contém uma vírgula
                // Evita que o usuário insira mais de uma vírgula no campo
                if ((sender as Button).Text != "," || !txtPeso.Text.Contains(","))
                {
                    // Adiciona o texto do botão pressionado ao campo 'txtPeso'
                    // 'sender' é o botão que foi clicado, então pega o texto do botão e adiciona ao campo de texto
                    txtPeso.Text += (sender as Button).Text;
                }
            }
            else
            {
                // Se o campo ativo for 'txtAltura' (quando 'txtPeso' não está em foco)
                // Verifica se o botão pressionado não é uma vírgula ou se o campo 'txtAltura' já contém uma vírgula
                // Evita que o usuário insira mais de uma vírgula no campo
                if ((sender as Button).Text != "," || !txtAltura.Text.Contains(","))
                {
                    // Adiciona o texto do botão pressionado ao campo 'txtAltura'
                    txtAltura.Text += (sender as Button).Text;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Evento que ocorre quando o campo 'txtPeso' recebe foco (o usuário clica ou seleciona o campo)
        private void txtPeso_Enter(object sender, EventArgs e)
        {
            // Quando o campo 'txtPeso' recebe foco, o fundo do campo 'txtPeso' é alterado para vermelho
            // Isso é feito para indicar ao usuário que o campo está ativo e pronto para receber dados
            txtPeso.BackColor = Color.Red;

            // Simultaneamente, o fundo do campo 'txtAltura' é alterado para branco
            // Isso é feito para indicar que o campo 'txtAltura' está inativo e não será editado
            txtAltura.BackColor = Color.White;
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
        // Evento que ocorre quando o campo 'txtAltura' recebe foco (o usuário clica ou seleciona o campo)
        private void txtAltura_Enter(object sender, EventArgs e)
        {
            // Quando o campo 'txtAltura' recebe foco, o fundo do campo 'txtAltura' é alterado para vermelho
            // Isso é feito para indicar ao usuário que o campo está ativo e pronto para receber dados
            txtAltura.BackColor = Color.Red;

            // Simultaneamente, o fundo do campo 'txtPeso' é alterado para branco
            // Isso é feito para indicar que o campo 'txtPeso' está inativo e não será editado
            txtPeso.BackColor = Color.White;
        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {

        }
        // Evento que ocorre quando o botão "Limpar" (button12) é clicado
        private void button12_Click(object sender, EventArgs e)
        {
            // Verifica se o campo 'txtPeso' está em foco (ou seja, com fundo vermelho)
            if (txtPeso.BackColor == Color.Red)
            {
                // Se estiver, limpa o conteúdo do campo 'txtPeso'
                txtPeso.ResetText();
            }

            // Verifica se o campo 'txtAltura' está em foco (com fundo vermelho)
            if (txtAltura.BackColor == Color.Red)
            {
                // Se estiver, limpa o conteúdo do campo 'txtAltura'
                txtAltura.ResetText();
            }
        }
        // Evento que ocorre quando o botão 'btnCalcularIMC' é clicado
        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            // Declaração das variáveis que serão usadas no cálculo
            float peso, altura, IMC;
            string situacao;

            // Converte o texto dos campos 'txtPeso' e 'txtAltura' para números de ponto flutuante
            peso = float.Parse(txtPeso.Text);
            altura = float.Parse(txtAltura.Text);

            // Calcula o IMC utilizando a fórmula: IMC = peso / (altura^2)
            IMC = peso / (float)(Math.Pow(altura, 2));

            // Exibe o IMC calculado no campo 'txtIMC', formatado com 2 casas decimais
            txtIMC.Text = IMC.ToString("N2");

            // Classificação do IMC de acordo com os valores predefinidos
            if (IMC < 19.1)
            {
                situacao = "Abaixo do Peso";
            }
            else if (IMC >= 19.1 && IMC < 25.8)
            {
                situacao = "Peso Normal";
            }
            else if (IMC >= 25.8 && IMC < 32.3)
            {
                situacao = "Acima do peso";
            }
            else
            {
                situacao = "Obeso";
            }

            // Exibe a situação do IMC no label 'lblSituacao'
            lblSituacao.Text = situacao.ToString();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}