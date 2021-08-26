using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SysDiarias {
    class Database {
        public static string MySqlClientString = ("server= localhost;user id=root;password=srv419378;database=dbservidores");
        
        public static void ConexaoBD() {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            try {
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }
            }
            catch (MySqlException erro) {
                MessageBox.Show("Não foi possível conectar com o banco de dados : " + erro.Message, "Erro de Conexão",
MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            finally {
                conn.Dispose();
            }
        }
        public class Manutencao {
            public MySqlConnection conn = new MySqlConnection(MySqlClientString);
            public MySqlCommand cmd = new MySqlCommand();
            public DataTable dt = new DataTable();
            public MySqlDataAdapter da = new MySqlDataAdapter();
            public DataSet ds = new DataSet();
            //Executa a instrução para inserir/deletar e atualizar
            public void ExecutaConsulta(string MySql) {
                try {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = MySql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch {
                    throw;
                }
            }
            //Obtem os registros da tabela
            public DataTable GetRegistros(string MySql) {
                try {
                    dt = new DataTable();
                    da = new MySqlDataAdapter(MySql, conn);
                    da.Fill(dt);
                    return dt;
                }
                catch {
                    throw;
                }
            }
        }

    }
}
