using System;
using System.Linq.Expressions;
using System.Windows.Forms;

//importa a biblioteca do MYSQL
using MySql.Data.MySqlClient;

namespace CRUD

{
    public partial class Form1 : Form
    {

        // Variavel que armazenara a conexao com o banco de dados   

        MySqlConnection Conexao;

        // String de conexao com o banco de dados

        String connString = "datasource=localhost;username=root;password=;database=agenda";

        public Form1()
        {
            InitializeComponent();

            txtListView.View = View.Details;
            txtListView.Columns.Add("ID", 50);
            txtListView.Columns.Add("Nome", 150);
            txtListView.Columns.Add("Email", 150);
            txtListView.Columns.Add("Telefone", 100);
        }

      

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {

                //criar a conexão com o MySQL
                Conexao = new MySqlConnection(connString);
                //criar a conexão para inserir os dados 
                string sql = "INSERT INTO contatos (nome, telefone, email) VALUES ('" + txtNome.Text + "','" + txtTelefone.Text + "','" + txtEmail.Text + "')";
                //criar o comando SQL
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                //abrir a conexao
                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato salvo com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o contato!!!\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechando a conexao
                Conexao.Close();

            }


        }
        private void btnConsultar_Click_1(object sender, EventArgs e)
        {

            try
            {

                string query = "'" + txtLocalizar.Text + "'";


                Conexao = new MySqlConnection(connString);

                string sql = "SELECT  * FROM contatos WHERE nome LIKE" + query + "OR email like" + query;

                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                Conexao.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                txtListView.Items.Clear();

                //Lê os dados retornados

                while (reader.Read())
                {
                    string[] row =
                        {
                        reader["id"].ToString(),
                        reader["nome"].ToString(),
                        reader["telefone"].ToString(),
                        reader["email"].ToString()

                    };

                    //Cria um novo ListViewItem com os dados 

                    var linha_listview = new ListViewItem(row);

                    //Adiciona o ListViewItem  à lista
                    txtListView.Items.Add(linha_listview);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar registro no banco: " + ex.Message);
            }
            finally
            {
                //Fechar a conexão
                if (Conexao != null)
                {
                    Conexao.Close();
                }
            }


        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(connString);

                string sql = "UPDATE contatos SET nome = @nome,email=@email, telefone=@telefone WHERE id =@id";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@id", txtId.Text);

                Conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Contato atualizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o contato!!!\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechando a conexao
                Conexao.Close();


            }


        }

        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(connString);

                string sql = "DELETE FROM contatos WHERE id = @id";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@id", txtId.Text);

                Conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Contato atualizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o contato!!!\n\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechando a conexao
                Conexao.Close();


            }
        }

        

    }
}
