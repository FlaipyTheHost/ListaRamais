using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaRamais
{
    class ConnectionString
    {
        private string datasource;
        private string user;
        private string password;
        public String conexao;

        public ConnectionString(string datasource, string user, string password)
        {
            this.datasource = datasource;
            this.user = user;
            this.password = password;
            this.conexao = "Data Source=" + datasource + ";Persist Security Info=True;User ID=" + user + ";Password=" + password + ";Unicode=True";

        }
    }
}
