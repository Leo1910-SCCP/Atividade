namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        List <Pessoas> Dados = new List <Pessoas> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            

             
            ListaDados.Items.Add($"{TxtNome.Text}======={txtIdade.Text}");
            



        }
    }
}
