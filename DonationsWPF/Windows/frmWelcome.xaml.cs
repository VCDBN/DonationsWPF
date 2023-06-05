using DonationsWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DonationsWPF
{
    /// <summary>
    /// Interaction logic for frmWelcome.xaml
    /// </summary>
    public partial class frmWelcome : Window
    {
        public frmWelcome()
        {
            InitializeComponent();
            ListUtil.PopulateLists();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            frmAddDonor addDonor = new frmAddDonor();
            this.Hide();
            addDonor.ShowDialog();
            this.Show();
        }

        private void btnCaptureDonation_Click(object sender, EventArgs e)
        {
            frmCaptureDonation captureDonation = new frmCaptureDonation();
            this.Hide();
            captureDonation.ShowDialog();
            this.Show();
        }

        private void btnDonorReport_Click(object sender, EventArgs e)
        {
            frmDonorReport donorReport = new frmDonorReport();
            this.Hide();
            donorReport.ShowDialog();
            this.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

    }
}
