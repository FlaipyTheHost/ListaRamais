using System;
<<<<<<< HEAD
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
using MaterialSkin.Controls;
using MaterialSkin;

namespace ListaRamais
{
    public partial class ListaRamais : MaterialForm
    {
<<<<<<< HEAD
        #region DADOS DA CONEXAO
        private string datasource = "Data Source=BancoDemonstrativo.db"; // Aqui é onde vai o arquivo do banco SQLite
        private SQLiteConnection cx;
=======

        #region DADOS DA CONEXAO
        ConnectionString con;
        OracleConnection cx;
        OracleTransaction ot;
        #endregion

        #region CONEXAO COM BANCO
        private string datasource = "ENDEREÇO";
        private string user = "USUARIO";
        private string password = "SENHA";
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        #endregion

        private readonly MaterialSkinManager materialSkinManager;

        public ListaRamais()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.LightGreen200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
<<<<<<< HEAD


            cx = new SQLiteConnection(datasource);
=======
            con = new ConnectionString(datasource, user, password);
            cx = new OracleConnection(con.conexao);
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            txtTela.Text = "";
            buscarRamal();
        }

        void buscarRamal()
        {
            try
            {
                cx.Open();
                StringBuilder sb = new StringBuilder();
<<<<<<< HEAD
                sb.Append("SELECT RAMAL, NOME, SETOR, FILIAL FROM FUNCIONARIOS WHERE NOME LIKE '%" + txtPesquisa.Text + "%' OR SETOR LIKE '%" + txtPesquisa.Text + "%' OR RAMAL LIKE '%" + txtPesquisa.Text + "%' OR FILIAL LIKE '%" + txtPesquisa.Text + "%'");
                SQLiteCommand cd = new SQLiteCommand(sb.ToString(), cx);

                SQLiteDataReader dr = cd.ExecuteReader();
=======
                sb.Append(" SELECT RAMAL, NOME, SETOR, FILIAL FROM TABRAMAL WHERE NOME LIKE '%" + txtPesquisa.Text + "%' OR SETOR LIKE '%" + txtPesquisa.Text + "%' OR RAMAL LIKE '%" + txtPesquisa.Text + "%' OR FILIAL LIKE '%" + txtPesquisa.Text + "%'  ");
                OracleCommand cd = new OracleCommand(sb.ToString(), cx);

                OracleDataReader dr = cd.ExecuteReader();
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtTela.Text += (dr["FILIAL"].ToString() + " - " + dr["RAMAL"].ToString() + " - " + dr["SETOR"].ToString() + " - " + dr["NOME"].ToString() + "\n");
                    }
                }
<<<<<<< HEAD
                else
                {
                    txtTela.Text = "";
                }
=======
                else { txtTela.Text = ""; }
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cx.Close();
            }
<<<<<<< HEAD
=======

>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Conversor de maiusculas
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

<<<<<<< HEAD
        private void ListaRamais_Resize(object sender, EventArgs e)
=======
        private void JonnasPhone_Resize(object sender, EventArgs e)
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        {
            //Se for minimizado irá para a SystemTray
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                Notificacao.Visible = true;
            }
        }

        private void Notificacao_Click(object sender, EventArgs e)
        {//Maximizador
            Show();
            this.WindowState = FormWindowState.Normal;
        }

<<<<<<< HEAD
        private void ListaRamais_Load(object sender, EventArgs e)
=======
        private void JonnasPhone_Load(object sender, EventArgs e)
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        {
            ancorar();
        }

        private void ancorar()
        {   //Coloca o programa no canto inferiror direito da tela
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            // Usar 'Screen.AllScreens[1].WorkingArea' para tela secundária
            this.Left = workingArea.Left + workingArea.Width - this.Size.Width;
            this.Top = workingArea.Top + workingArea.Height - this.Size.Height;
        }

<<<<<<< HEAD
        private void ListaRamais_Deactivate(object sender, EventArgs e)
=======
        private void JonnasPhone_Deactivate(object sender, EventArgs e)
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        {   //Caso clique fora do programa ele irá minimizar para SystemTray
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbSobre_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Deactivate -= ListaRamais_Deactivate;
            MessageBox.Show("Este programa é um software livre: você pode redistribuí-lo e/ou modificá-lo sob os termos da GNU General Public License conforme publicada por a Free Software Foundation, seja a versão 3 da Licença, ou (a seu critério) qualquer versão posterior.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Deactivate += ListaRamais_Deactivate;

=======
            MessageBox.Show("Este programa é um software livre: você pode redistribuí-lo e/ou modificá-lo sob os termos da GNU General Public License conforme publicada por a Free Software Foundation, seja a versão 3 da Licença, ou (a seu critério) qualquer versão posterior.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
>>>>>>> 1c749e0a6f1e9f468c4801dc2672add22c48f5b9
        }

        private void Notificacao_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
