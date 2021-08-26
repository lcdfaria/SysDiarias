using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SysDiarias {
    class BD_SQLite {

        public SQLiteConnection conn = new SQLiteConnection("Data Source=dbservidores.sqlite; Version=3;");

        public void conectar() {
            conn.Open();
        }

        public void desconectar() {
            conn.Close();
        }
    }

}
