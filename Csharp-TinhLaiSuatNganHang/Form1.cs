using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_TinhLaiSuatNganHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tienlai;
            double laisuat = Double.Parse(txtLaisuat.Text.Replace("%",""))/100;
            double sotien, nam;
            sotien = double.Parse(txtSotien.Text);
            nam = double.Parse(txtSonamgui.Text);
            for (int i = 1; i < nam; i++)
            {
                tienlai = sotien * laisuat;
                lsbKetqua.Items.Add($"{1}\t {sotien:F2}\t\t\t {tienlai:F2}");
            }
        }

        private void txtSotien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            