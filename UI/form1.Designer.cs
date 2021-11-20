namespace AntonioGabriel3c1_02
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_produto = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cadadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(51, 49);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            // 
            // lbl_produto
            // 
            this.lbl_produto.AutoSize = true;
            this.lbl_produto.Location = new System.Drawing.Point(324, 49);
            this.lbl_produto.Name = "lbl_produto";
            this.lbl_produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_produto.TabIndex = 1;
            this.lbl_produto.Text = "Produto";
            this.lbl_produto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(625, 49);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.Text = "Descrição";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(32, 124);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cadadastrar
            // 
            this.btn_cadadastrar.Location = new System.Drawing.Point(581, 124);
            this.btn_cadadastrar.Name = "btn_cadadastrar";
            this.btn_cadadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadadastrar.TabIndex = 4;
            this.btn_cadadastrar.Text = "Cadastrar";
            this.btn_cadadastrar.UseVisualStyleBackColor = true;
            this.btn_cadadastrar.Click += new System.EventHandler(this.btn_cadadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(327, 124);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 205);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(12, 75);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 7;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(614, 75);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(100, 20);
            this.txt_descricao.TabIndex = 8;
            this.txt_descricao.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(302, 75);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(100, 20);
            this.txt_produto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadadastrar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_produto);
            this.Controls.Add(this.lbl_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_produto;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cadadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_produto;
    }
}

