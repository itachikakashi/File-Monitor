using System;
using System.Windows.Forms;

namespace File_Monitor
{
    public partial class ChooseCalibration : Form
    {
        private bool enableClose = false;
        public ChooseCalibration()
        {
            InitializeComponent();
        }

        private void bluetooth_Click(object sender, EventArgs e)
        {
            closeForm(1, true);
        }

        private void wifi_Click(object sender, EventArgs e)
        {
            closeForm(2, true);
        }
        private void bluetoothWifi_Click(object sender, EventArgs e)
        {
            closeForm(3, false);
        }

        private void closeForm(int button, bool auxSort)
        {
            Dados.BtnId = button;
            enableClose = true;
            Dados.EnableSort = auxSort;
            Dados.WaitNextNotice = DateTime.Now.ToString();
            DateTime plusDate = DateTime.Parse(Dados.WaitNextNotice);
            Close();
        }

        private void ChooseCalibration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!enableClose)
            {
                MessageBox.Show("Você não poderá fechar a aplicação sem antes selecionar uma das opções apresentadas nela!", "Choose Calibration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
