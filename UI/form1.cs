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


namespace AntonioGabriel3c1_02
{
    public partial class Form1 : Form
    {
        EPABLL ePABLL = new EPABLL();
        EPADTO ePADTO = new EPADTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ePABLL.Listar();
        }

        private void btn_cadadastrar_Click(object sender, EventArgs e)
        {
            ePADTO.Produto = txt_produto.Text;
            ePADTO.Descricao = txt_descricao.Text;

            ePABLL.inserir(ePADTO);



            MessageBox.Show("Cadastrado", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_id.Clear();
            txt_produto.Clear();
            txt_descricao.Clear();
        }


        private void btn_excluir_Click(object sender, EventArgs e)
        {
            
            ePADTO.Id = int.Parse(txt_id.Text);

            
            ePADTO.Excluir(ePADTO);

            
            MessageBox.Show("Excluido", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            ePADTO.Listar();

            
            txt_id.Clear();
           txt_produto.Clear();
            txt_descricao.Clear();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ePADTO.Id = int.Parse(txt_id.Text);
            ePADTO.Produto = txt_produto.Text;
            ePADTO.Descricao = txt_descricao.Text;


            ePABLL.Editar(ePADTO);


            MessageBox.Show("Editado", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ePABLL.Listar();

            txt_id.Clear();
            txt_produto.Clear();
            txt_descricao.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           txt_produto.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_descricao.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}