using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AntonioGabriel3c1_02.Code.BLL; 
using AntonioGabriel3c1_02.Code.DTO; 

namespace AntonioGabriel3c1_02.UI
{
    public partial class frm_login : Form
    {
        LOGINBLL LOGINBBL = new LOGINBLL();
        LOGINDTO LOGINDTO = new LOGINDTO();

       
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGINDTO.Email = txt_email.Text;
            LOGINDTO.Senha = txt_senha.Text;


            
            if (LOGINBBL.RealizarLogin(LOGINDTO) == true)
            {

                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Olha se ta tudo certo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
