using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Aula13CadastroUsuarios
{
    public partial class Form1 : Form
    {
         List <Pessoa>Listapessoas=new List <Pessoa> ();
        //VARIÁVEIS GLOBAIS
        //MÉTODO CONSTRUTOR

        public Form1()
        {
            InitializeComponent();
        }
        
        public void atualizaInterface()
        {
            listView1.Clear ();
            for (int i = 0; i < Listapessoas.Count; i++)
            {
                listView1.Items.Add(Listapessoas[i].nome);
                listView1.Items.Add(Listapessoas[i].idade.ToString());
                listView1.Items.Add(Listapessoas[i].cidade);
                listView1.Items.Add(Listapessoas[i].rua);
                
                
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome=txtNome.Text;
            int idade=int.Parse(txtIdade.Text);
            string rua=txtRua.Text;
            string cidade=txtCidade.Text;

            Pessoa pessoa=new Pessoa(nome,idade,rua,cidade);
            Listapessoas.Add(pessoa);
            atualizaInterface();
        }
    }
}