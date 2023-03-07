namespace PagamentoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            if (nome_txtb.TextLength == 0 || cpf_txtb.TextLength == 0 || valorHora_txtb.TextLength == 0 || horasTrabalhas_txtb.TextLength == 0)
                MessageBox.Show("Preencha todos os campos!");
            else
            {
                funcionario.Nome = nome_txtb.Text;
                funcionario.Cpf = cpf_txtb.Text;
                funcionario.ValorHora = double.Parse(valorHora_txtb.Text);
                funcionario.HorasTrabalhadas = double.Parse(horasTrabalhas_txtb.Text);

                funcionario.calcularSalario();

                salario_lbl.Visible = true;
                salario_txtb.Visible = true;

                salario_txtb.Text = funcionario.Salario.ToString();
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salario_lbl.Visible = false;
            salario_txtb.Visible = false;
        }
    }
}