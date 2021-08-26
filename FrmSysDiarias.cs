using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace SysDiarias
    
{
    public partial class FrmSysDiarias : Form
    {
        Conexao cn = new Conexao();
        SQLiteDataReader dr;

        public double totalDiarias = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Control campo = new Control();


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmSysDiarias()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e) {
            tCtrlPrincipal.SelectedTab = tpDados;
            btnBackup.BackgroundImage = Properties.Resources.btnBackup;
            btnRestore.BackgroundImage = Properties.Resources.btnRestore;
            btImprimir.BackgroundImage = Properties.Resources.btnVisualizarN;
            btSair.BackgroundImage = Properties.Resources.btnSairN;
            lblTransporte.Text = "";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            rchFinalidade.KeyPress += new KeyPressEventHandler(rchFinalidade_KeyPress);

            CarregaComboServidores();
            CarregaComboBancos();
            CarregaComboSecretaria();
            

        }
            
        public bool ValidaCPF(string cpf) {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        protected override void OnPaint(PaintEventArgs e) {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, btnFechar.Width, btnFechar.Height);
            btnFechar.Region = new Region(forma);
        }
        public void CarregaComboBancos() {
            try {
                if (cn.conn.State == ConnectionState.Closed)
                    cn.conectar();
                string sqlBancos = "select * from tbancos";
                SQLiteCommand cmdBancos = new SQLiteCommand(sqlBancos, cn.conn);
                SQLiteDataAdapter mdaBancos = new SQLiteDataAdapter(cmdBancos);
                dr = cmdBancos.ExecuteReader();
                while (dr.Read()) {
                    cmbCadBanco.Items.Add(dr["banco"]);
                }
                dr.Close();
                cn.desconectar();

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao Carregar dados da Tabela Bancos " + ex.Message, "SysDiárias  -  Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool CamposVazios(Control ctrl) {
            if (txtCadNome.Text == "") {
                MessageBox.Show("O Campo Nome está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadNome.Focus();
                return true;
            }
            else if (txtCadCargo.Text == "") {
                MessageBox.Show("O Campo Cargo está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadCargo.Focus();
                return true;
            }
            else if (cmbCadBanco.Text == "") {
                MessageBox.Show("O Campo Banco está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCadBanco.Focus();
                return true;
            }
            else if (txtCadAgencia.Text == "") {
                MessageBox.Show("O Campo Agência está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadAgencia.Focus();
                return true;
            }
            else if (txtCadConta.Text == "") {
                MessageBox.Show("O Campo Conta está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCadConta.Focus();
                return true;
            }
            else if (cmbCadSecretaria.Text == "") {
                MessageBox.Show("O Campo Secretaria está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCadSecretaria.Focus();
                return true;
            }
            else if (!mskCadCpf.MaskCompleted) {
                MessageBox.Show("O Campo CPF está vazio", "SysDiárias  -  Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCadCpf.Focus();
                return true;
            }
            else return false;

        }
        public void CarregaComboSecretaria() {
            try {
                if (cn.conn.State == ConnectionState.Closed)
                    cn.conectar();
                string sqlSecretarias = "select * from tsecretarias order by secretaria";
                SQLiteCommand cmdSecretarias = new SQLiteCommand(sqlSecretarias, cn.conn);
                SQLiteDataAdapter mdaSecretarias = new SQLiteDataAdapter(cmdSecretarias);
                dr = cmdSecretarias.ExecuteReader();
                while (dr.Read()) {
                    cmbCadSecretaria.Items.Add(dr["secretaria"]);
                }
                dr.Close();
                cn.desconectar();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao Carregados dados da Tabela tsecretarias " + ex.Message + " contate o desenvolvedor", "SysDiárias  -  Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CarregaComboServidores() {
            try {
                if (cn.conn.State == ConnectionState.Closed)
                    cn.conectar();
                string sqlServidores = "select * from tservidores order by nome";
                SQLiteCommand cmdServidores = new SQLiteCommand(sqlServidores, cn.conn);
                SQLiteDataAdapter mdaServidores = new SQLiteDataAdapter(cmdServidores);
                DataTable dtServidores = new DataTable();
                cmbNome.DataSource = null;
                cmbNome.Items.Clear();
                mdaServidores.Fill(dtServidores);
                cmbNome.DataSource = dtServidores;
                cmbNome.ValueMember = "idservidor";
                cmbNome.DisplayMember = "nome";
                cmbNome.SelectedIndex = (-1);
                cmbNome.Refresh();
                cn.desconectar();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao Carregados dados da Tabela tservidores " + ex.Message + " contate o desenvolvedor", "SysDiárias  -  Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RchFinalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
        private void BtImprimir_Click(object sender, EventArgs e)
        {
            if (txtValorAlim.Text == "")
            {
                txtValorAlim.Text = "0,00";
                txtTotalAlim.Text = "0,00";
            }
            if (txtValorHosp.Text == "")
            {
                txtValorHosp.Text = "0,00";
                txtTotalHosp.Text = "0,00";
            }

            frmRelatorio relatorio = new frmRelatorio(cmbNome.Text, txtCargo.Text, txtBanco.Text, txtAgencia.Text, txtConta.Text, mskCpf.Text,
                txtSecretaria.Text, txtDestino.Text + "/" + txtEstado.Text, rchFinalidade.Text, dtpSaida.Text, dtpRetorno.Text, txtQtdeAlim.Text, txtValorAlim.Text,
                txtTotalAlim.Text, txtQtdeHosp.Text, txtValorHosp.Text, txtTotalHosp.Text, lblTotalDiarias.Text, cmbTransporte.Text, txtPlaca.Text, mtbHoraSaida.Text, mtbHoraRetorno.Text);

            relatorio.ShowDialog();

        }
        private void txtValorAlim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorAlim.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }

        }
        private void txtValorHosp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorHosp.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }

        }
        private void cmbTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTransporte.SelectedIndex)
            {
                case 0:
                    lblTransporte.Text = "COMPAHIA AÉREA";
                    break;
                case 1:
                    lblTransporte.Text = "NOME DA EMPRESA(VIAÇÃO)";
                    break;
                case 2:
                    lblTransporte.Text = "PLACA DO VEÍCULO";
                    break;
                case 3:
                    lblTransporte.Text = "PLACA DO VEÍCULO";
                    break;
                case 4:
                    lblTransporte.Text = "PLACA DO VEÍCULO";
                    break;
            }

        }
        private void txtValorAlim_Leave(object sender, EventArgs e)
        {
            if (txtTotalHosp.Text == "0" || txtTotalHosp.Text == "")
                totalDiarias = 0;
            else
                totalDiarias = Convert.ToDouble(txtTotalHosp.Text);

            if (txtQtdeAlim.Text != "" && txtValorAlim.Text != "")
            {
                txtTotalAlim.Text = Convert.ToString(Convert.ToDouble(txtQtdeAlim.Text) * Convert.ToDouble(txtValorAlim.Text));
                txtTotalAlim.Text = String.Format("{0: #,##0.00}", double.Parse(txtTotalAlim.Text));
                totalDiarias += Convert.ToDouble(txtTotalAlim.Text);
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
            else
            {
                txtTotalAlim.Text = "";
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma Sair do Programa? todos os dados não salvos serão perdidos!", "SysDiárias  -  Sair do Sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tsslData.Text = DateTime.Today.ToShortDateString();
            tsslHora.Text = DateTime.Now.ToShortTimeString();
        }
        private void txtQtdeAlim_Leave(object sender, EventArgs e)
        {
            if (txtTotalHosp.Text == "0" || txtTotalHosp.Text == "")
                totalDiarias = 0;
            else
                totalDiarias = Convert.ToDouble(txtTotalHosp.Text);

            if (txtTotalAlim.Text != "" && txtValorAlim.Text != "" && txtQtdeAlim.Text != "")
            {
                txtTotalAlim.Text = Convert.ToString(Convert.ToDouble(txtQtdeAlim.Text) * Convert.ToDouble(txtValorAlim.Text));
                txtTotalAlim.Text = String.Format("{0: #,##0.00}", double.Parse(txtTotalAlim.Text));
                totalDiarias += Convert.ToDouble(txtTotalAlim.Text);
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
            else
            {
                txtTotalAlim.Text = "";
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
        }
        private void txtQtdeHosp_Leave(object sender, EventArgs e)
        {
            if (txtTotalAlim.Text == "0" || txtTotalAlim.Text == "")
                totalDiarias = 0;
            else
                totalDiarias = Convert.ToDouble(txtTotalAlim.Text);

            if (txtTotalHosp.Text != "" && txtValorHosp.Text != "" && txtQtdeHosp.Text != "")
            {
                txtTotalHosp.Text = Convert.ToString(Convert.ToDouble(txtQtdeHosp.Text) * Convert.ToDouble(txtValorHosp.Text));
                txtTotalHosp.Text = String.Format("{0: #,##0.00}", double.Parse(txtTotalHosp.Text));
                totalDiarias += Convert.ToDouble(txtTotalHosp.Text);
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
            else
            {
                txtTotalHosp.Text = "";
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
        }
        private void txtValorHosp_Leave(object sender, EventArgs e)
        {
            if (txtTotalAlim.Text == "0" || txtTotalAlim.Text == "")
                totalDiarias = 0;
            else
                totalDiarias = Convert.ToDouble(txtTotalAlim.Text);

            if (txtQtdeHosp.Text != "" && txtValorHosp.Text != "")
            {
                txtTotalHosp.Text = Convert.ToString(Convert.ToDouble(txtQtdeHosp.Text) * Convert.ToDouble(txtValorHosp.Text));
                txtTotalHosp.Text = String.Format("{0: #,##0.00}", double.Parse(txtTotalHosp.Text));
                totalDiarias += Convert.ToDouble(txtTotalHosp.Text);
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
            else
            {
                txtTotalHosp.Text = "";
                lblTotalDiarias.Text = Convert.ToString(totalDiarias);
                lblTotalDiarias.Text = String.Format("R$ {0: #,##0.00}", double.Parse(lblTotalDiarias.Text));
            }
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma sair do Programa? todos os dados não salvos serão perdidos!", "SysDiárias  -  Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        private void PanelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void Label22_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void rchFinalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        private void toolStripStatusLabel3_DoubleClick(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }
        private void txtQtdeAlim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtQtdeAlim.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }

        }
        private void TxtQtdeHosp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtQtdeHosp.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }

        }
        private void mskCadCpf_Leave(object sender, EventArgs e)
        {
            timer2.Interval = 1500;
            timer2.Start();
            if (mskCadCpf.MaskCompleted) {
                if (!ValidaCPF(mskCadCpf.Text)) {
                    MessageBox.Show("O CPF digitado está incorreto favor verificar", "SysDiárias  -  CPF Inválido!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCadCpf.Clear();
                    mskCadCpf.Focus();
                    return;
                }
            }
            else {
                MessageBox.Show("O Campo CPF não pode ser deixado em branco", "SysDiárias  -  Campo Obrigatório!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskCadCpf.Clear();
                mskCadCpf.Focus();
            }
        }
        private void btImprimir_MouseMove(object sender, MouseEventArgs e)
        {
            btImprimir.BackgroundImage = Properties.Resources.btnVisualizarC;
        }
        private void btImprimir_MouseLeave(object sender, EventArgs e)
        {
            btImprimir.BackgroundImage = Properties.Resources.btnVisualizarN;
        }
        private void btSair_MouseMove(object sender, MouseEventArgs e)
        {
            btSair.BackgroundImage = Properties.Resources.btnSairC;
        }
        private void btSair_MouseLeave(object sender, EventArgs e)
        {
            btSair.BackgroundImage = Properties.Resources.btnSairN;
        }
        private void RchFinalidade_Leave(object sender, EventArgs e)
        {
            tCtrlPrincipal.SelectedTab = tpDadosPC;
            txtQtdeAlim.Focus();
        }
        private void CmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbNome.SelectedIndex != -1) {
                if(cn.conn.State == ConnectionState.Closed) {
                    try {
                        cn.conectar();
                        DataRowView drv = ((DataRowView)cmbNome.SelectedItem);
                        txtCargo.Text = Convert.ToString(drv["cargo"]);
                        txtBanco.Text = Convert.ToString(drv["banco"]);
                        txtAgencia.Text = Convert.ToString(drv["agencia"]);
                        txtConta.Text = Convert.ToString(drv["conta"]);
                        txtSecretaria.Text = Convert.ToString(drv["secretaria"]);
                        mskCpf.Text = Convert.ToString(drv["cpf"]);
                    }catch (Exception ex) {
                        MessageBox.Show("Erro e Conexão com o Banco "+ ex.Message, "SysDiárias  -  Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                txtCargo.Text = "";
                txtBanco.Text = "";
                txtAgencia.Text = "";
                txtConta.Text = "";
                txtSecretaria.Text = "";
                mskCpf.Text = "";
            }
            cn.desconectar();
            txtDestino.Focus();
        }
        private void btnSalvar_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnSalvar.Enabled == true)
                btnSalvar.BackgroundImage = Properties.Resources.btnSalvarC;
            else
                btnSalvar.BackgroundImage = Properties.Resources.btnSalvarD;
        }
        private void btnSalvar_MouseLeave(object sender, EventArgs e)
        {
            if (btnSalvar.Enabled == true)
                btnSalvar.BackgroundImage = Properties.Resources.btnSalvarN;
            else
                btnSalvar.BackgroundImage = Properties.Resources.btnSalvarD;
        }
        private void btnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnEditar.Enabled == true)
                btnEditar.BackgroundImage = Properties.Resources.btnEditarC;
            else
                btnEditar.BackgroundImage = Properties.Resources.btnEditarD;
        }
        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            if (btnEditar.Enabled == true)
                btnEditar.BackgroundImage = Properties.Resources.btnEditarN;
            else
                btnEditar.BackgroundImage = Properties.Resources.btnEditarD;
        }
        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnCancelar.Enabled == true)
                btnCancelar.BackgroundImage = Properties.Resources.btnCancelarC;
            else
                btnCancelar.BackgroundImage = Properties.Resources.btnCancelarD;
        }
        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            if (btnCancelar.Enabled == true)
                btnCancelar.BackgroundImage = Properties.Resources.btnCancelarN;
            else
                btnCancelar.BackgroundImage = Properties.Resources.btnCancelarD;
        }
        private void BtnExcluir_MouseMove(object sender, MouseEventArgs e) {
            if (btnExcluir.Enabled == true)
                btnExcluir.BackgroundImage = Properties.Resources.btnExcluirC;
            else
                btnExcluir.BackgroundImage = Properties.Resources.btnExcluirD;
        }
        private void BtnExcluir_MouseLeave(object sender, EventArgs e) {
            if (btnExcluir.Enabled == true)
                btnExcluir.BackgroundImage = Properties.Resources.btnExcluirN;
            else
                btnExcluir.BackgroundImage = Properties.Resources.btnExcluirD;
        }
        public void LimparTexto(Control.ControlCollection controles) {
            txtCadNome.Clear();
            txtCadCargo.Clear();
            cmbCadBanco.SelectedIndex = (-1);
            txtCadAgencia.Clear();
            txtCadConta.Clear();
            cmbCadSecretaria.SelectedIndex = (-1);
            mskCadCpf.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e) {
            if (!CamposVazios(tpCadastro)) {
                try {
                    cn.conectar();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO tservidores (nome, cargo, cpf, banco, agencia, conta, secretaria) " +
                            "VALUES (@nome, @cargo, @cpf, @banco, @agencia, @conta, @secretaria)", cn.conn);
                    cmd.Parameters.AddWithValue("@nome", txtCadNome.Text);
                    cmd.Parameters.AddWithValue("@cargo", txtCadCargo.Text);
                    cmd.Parameters.AddWithValue("@cpf", mskCadCpf.Text);
                    cmd.Parameters.AddWithValue("@banco", cmbCadBanco.Text);
                    cmd.Parameters.AddWithValue("@agencia", txtCadAgencia.Text);
                    cmd.Parameters.AddWithValue("@conta", txtCadConta.Text);
                    cmd.Parameters.AddWithValue("@secretaria", cmbCadSecretaria.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro de Conexão com o Banco de Dados " + ex.Message, "SysDiárias  -  Erro de Conexão",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    cn.desconectar();
                    LimparTexto(pnlCadastro.Controls);
                    CarregaGrid();
                    CarregaComboServidores();
                    txtCadNome.Focus();
                }
            }
        }
        public void CarregaGrid() {
            try {
                cn.conectar();
                DataSet ds1 = new DataSet();
                SQLiteCommand cmd = new SQLiteCommand("select * from tservidores", cn.conn);
                SQLiteDataAdapter msa1 = new SQLiteDataAdapter(cmd);
                msa1.Fill(ds1, "tservidores");
                dtgServidores.DataSource = ds1.Tables["tservidores"];
            }
            catch (Exception ex) {
                MessageBox.Show("Erro de Conexão com o Banco " + ex.Message, "SysDiárias  -  Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally {
                cn.desconectar();
            }
        }    
        private void tCtrlPrincipal_SelectedIndexChanged(object sender, EventArgs e) {
            if (tCtrlPrincipal.SelectedTab == tpCadastro) {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                txtCadNome.Focus();
                CarregaGrid();
            }
            else if (tCtrlPrincipal.SelectedTab == tpDados) {
                //cmbNome.DataSource = null;
                cmbNome.Refresh();
                LimparTexto(pnlCadastro.Controls);
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }
        private void DtgServidores_CellClick(object sender, DataGridViewCellEventArgs e) {
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            txtCadNome.Text = this.dtgServidores.CurrentRow.Cells[1].Value.ToString();
            txtCadCargo.Text = this.dtgServidores.CurrentRow.Cells[2].Value.ToString();
            cmbCadBanco.Text = this.dtgServidores.CurrentRow.Cells[4].Value.ToString();
            txtCadAgencia.Text = this.dtgServidores.CurrentRow.Cells[5].Value.ToString();
            txtCadConta.Text = this.dtgServidores.CurrentRow.Cells[6].Value.ToString();
            cmbCadSecretaria.Text = this.dtgServidores.CurrentRow.Cells[7].Value.ToString();
            mskCadCpf.Text = this.dtgServidores.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnExcluir_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Confirma Exclusão do Servidor?","SysDiárias  -  Exclusão de Registro",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                    try {
                    cn.conectar();
                    SQLiteCommand cmd = new SQLiteCommand("delete from tservidores where nome = @nome", cn.conn);
                        cmd.Parameters.Add("@nome", DbType.String).Value = txtCadNome.Text;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erro de Conexão com o Banco " + ex.Message, "SysDiárias  -  Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally {
                        cn.desconectar();
                        LimparTexto(pnlCadastro.Controls);
                        CarregaGrid();
                    }
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
                CarregaComboServidores();
                txtCadNome.Focus();

            }else
                return;
        }
        private void BtnCancelar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Confirma Limpar todos os Campos","SysDiárias  -  Limpar Campos", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                LimparTexto(pnlCadastro.Controls);
                txtCadNome.Focus();
            }
            else txtCadNome.Focus();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            txtCadNome.Focus();

        }
        private void btnEditar_Click(object sender, EventArgs e) {
            try {
                cn.conectar();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE tservidores SET nome=@nome, cargo=@cargo, cpf=@cpf, banco=@banco, agencia=@agencia, " +
                    "conta=@conta, secretaria=@secretaria where nome=@nome", cn.conn);
                cmd.Parameters.AddWithValue("@nome", txtCadNome.Text);
                cmd.Parameters.AddWithValue("@cargo", txtCadCargo.Text);
                cmd.Parameters.AddWithValue("@cpf", mskCadCpf.Text);
                cmd.Parameters.AddWithValue("@banco", cmbCadBanco.Text);
                cmd.Parameters.AddWithValue("@agencia", txtCadAgencia.Text);
                cmd.Parameters.AddWithValue("@conta", txtCadConta.Text);
                cmd.Parameters.AddWithValue("@secretaria", cmbCadSecretaria.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw new Exception("Erro ao Atualizar dados na Tabela Servidores " + ex.Message);
            }
            finally {
                cn.desconectar();
                LimparTexto(pnlCadastro.Controls);
                CarregaGrid();
            }
            txtCadNome.Focus();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            txtCadNome.Focus();
            btnEditar_EnabledChanged(null, null);
            CarregaComboServidores();
        }
        private void btnSalvar_EnabledChanged(object sender, EventArgs e) {
            if (btnSalvar.Enabled == true)
                btnSalvar.BackgroundImage = Properties.Resources.btnSalvarN;
            else
                btnSalvar.BackgroundImage = Properties.Resources.btnSalvarD;
        }

        private void btnEditar_EnabledChanged(object sender, EventArgs e) {
            if (btnEditar.Enabled == true)
                btnEditar.BackgroundImage = Properties.Resources.btnEditarN;
            else
                btnEditar.BackgroundImage = Properties.Resources.btnEditarD;
        }

        private void btnCancelar_EnabledChanged(object sender, EventArgs e) {
            if (btnCancelar.Enabled == true)
                btnCancelar.BackgroundImage = Properties.Resources.btnCancelarN;
            else
                btnCancelar.BackgroundImage = Properties.Resources.btnCancelarD;
        }

        private void btnExcluir_EnabledChanged(object sender, EventArgs e) {
            if (btnExcluir.Enabled == true)
                btnExcluir.BackgroundImage = Properties.Resources.btnExcluirN;
            else
                btnExcluir.BackgroundImage = Properties.Resources.btnExcluirD;
        }
        private void btnBackup_Click(object sender, EventArgs e) {
            if (sfdBackup.ShowDialog() == DialogResult.OK) {
                //string sqlBackup = "Data Source=dbservidores.db;Version=3";
                //SQLiteConnection conBackup = new SQLiteConnection(sqlBackup);
                //cn.conectar();
                //conBackup.Open();
                //cn.conn.BackupDatabase(conBackup, "main", "main", 10, null, 0);
                //cn.desconectar();
                cn.desconectar();
                string fileorigem = "dbservidores.db";
                File.Copy(fileorigem, sfdBackup.FileName, true);
                MessageBox.Show("Backup realizado com sucesso!! " + "na pasta " + sfdBackup.FileName, "SysDiárias  -  Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRestore_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Confirma Restauração do Banco? Todos os Dados serão substituídos!", "SysDiárias - Restaurar Banco", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (ofdRestore.ShowDialog() == DialogResult.OK) {
                    cn.desconectar();
                    string filedest = "dbservidores.db";
                    File.Copy(ofdRestore.FileName, filedest,true);
                    CarregaGrid();
                }
            }
        }
        private void btnBackup_MouseMove(object sender, MouseEventArgs e) {
            btnBackup.BackgroundImage = Properties.Resources.btnBackupC;
        }

        private void btnBackup_MouseLeave(object sender, EventArgs e) {
            btnBackup.BackgroundImage = Properties.Resources.btnBackup;
        }

        private void btnRestore_MouseMove(object sender, MouseEventArgs e) {
            btnRestore.BackgroundImage = Properties.Resources.btnRestoreC;
        }

        private void btnRestore_MouseLeave(object sender, EventArgs e) {
            btnRestore.BackgroundImage = Properties.Resources.btnRestore;
        }

        private void Timer2_Tick(object sender, EventArgs e) {
            SendKeys.Send("{ENTER}");
            timer2.Stop();
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e) {
            btnMinimizar.BackgroundImage = Properties.Resources.icone_Minimizar;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e) {
            btnMinimizar.BackgroundImage = Properties.Resources.icone_MinimizarC;
        }

        private void btnFechar_MouseMove(object sender, MouseEventArgs e) {
            btnFechar.BackgroundImage = Properties.Resources.icone_Fechar;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e) {
            btnFechar.BackgroundImage = Properties.Resources.icone_FecharC;
        }

        private void cmbNome_Click(object sender, EventArgs e) {
            if (cmbNome.Items.Count < 1) {
                MessageBox.Show("Não existe(m) Servidor(es) Cadastrado(s), Efetue o Cadastro na aba CADASTRO DO SERVIDOR que se abrirá ao " +
                    "clicar OK", "SysDiárias  -  Cadastro Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tCtrlPrincipal.SelectedTab = tpCadastro;
                txtCadNome.Focus();
            }
        }

       private void CmbTransporte_SelectedIndexChanged_1(object sender, EventArgs e) {
            switch (cmbTransporte.SelectedIndex) {
                case 0:
                    txtPlaca.Mask = "";
                    break;
                case 1:
                    txtPlaca.Mask = "";
                    break;
                case 2:
                case 3:
                case 4:
                    txtPlaca.Mask = "";
                    txtPlaca.Focus();
                    break;
            }
        }
        public void tCtrlPrincipal_DrawItem(object sender, DrawItemEventArgs e) {
            TabPage CurrentTab = tCtrlPrincipal.TabPages[e.Index];
            Rectangle ItemRect = tCtrlPrincipal.GetTabRect(e.Index);
            SolidBrush FillBrush = new SolidBrush(Color.Red);
            SolidBrush TextBrush = new SolidBrush(Color.White);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (Convert.ToBoolean(e.State & DrawItemState.Selected)) {
                FillBrush.Color = Color.White;
                TextBrush.Color = Color.Red;
                ItemRect.Inflate(2, 2);
            }

            //Set up rotation for left and right aligned tabs
            if (tCtrlPrincipal.Alignment == TabAlignment.Left || tCtrlPrincipal.Alignment == TabAlignment.Right) {
                float RotateAngle = 90;
                if (tCtrlPrincipal.Alignment == TabAlignment.Left)
                    RotateAngle = 270;
                PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
                e.Graphics.TranslateTransform(cp.X, cp.Y);
                e.Graphics.RotateTransform(RotateAngle);
                ItemRect = new Rectangle(-(ItemRect.Height / 2), -(ItemRect.Width / 2), ItemRect.Height, ItemRect.Width);
            }

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();
        }

    }
}