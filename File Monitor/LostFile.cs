using System;
using System.Windows.Forms;

namespace File_Monitor
{
    public partial class LostFile : Form
    {
        public LostFile()
        {
            InitializeComponent();
        }

        private void btn_Lost_Comfirm_Click(object sender, EventArgs e)
        {            
            Properties.Settings.Default.FilePath = Dados.PathFile = " ";
            Properties.Settings.Default.Save();            
            Close();
        }
    }
}
