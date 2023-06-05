using DonationsWPF.Models;
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
    /// Interaction logic for frmDonorReport.xaml
    /// </summary>
    public partial class frmDonorReport : Window
    {
        
        public frmDonorReport()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // get list of emails of all donors and add to the combo box
            List<string> donorEmails = new List<string>();

            foreach (Donor don in ListUtil.donorList)
            {
                donorEmails.Add(don.Email);
            }
            cmbDonor.ItemsSource = donorEmails;

            // set the listbox and datagridview source to all donations (we show all until user filters)
            lstDonationReport.ItemsSource = ListUtil.donations;
            dtaDonationReport.ItemsSource = ListUtil.donations;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedDonor = cmbDonor.Text;

            int currentDonorId = 0;
            foreach (Donor don in ListUtil.donorList)
            {
                if (don.Email == selectedDonor)
                {
                    currentDonorId = don.DonorId;
                    break;
                }
            }

            List<Donation> filteredDonations = new List<Donation>();
            double total = 0;
            foreach (Donation donation in ListUtil.donations)
            {
                if (donation.DonorId == currentDonorId)
                {
                    filteredDonations.Add(donation);
                    total += donation.Amount;
                }
            }
            lstDonationReport.ItemsSource = filteredDonations;
            dtaDonationReport.ItemsSource = filteredDonations;

            MessageBox.Show("Total is R " + total);
        }

    }
}
