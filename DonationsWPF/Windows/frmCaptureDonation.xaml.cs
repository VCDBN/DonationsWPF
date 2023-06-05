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
    /// Interaction logic for frmCaptureDonation.xaml
    /// </summary>
    public partial class frmCaptureDonation : Window
    {
        List<string> donorNames = new List<string>();

        public frmCaptureDonation()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Donor donor in ListUtil.donorList)
            {
                donorNames.Add(donor.Name);
            }
            cmbDonor.ItemsSource = donorNames;
        }
        
        private void btnCaptureDonation_Click(object sender, EventArgs e)
        {

            string selectedDonor = cmbDonor.Text;

            int currentDonorId = 0;
            foreach (Donor don in ListUtil.donorList)
            {
                if (don.Name.Equals(selectedDonor))
                {
                    currentDonorId = don.DonorId;
                    break;
                }
            }

            Donation donation = new(ListUtil.donations.Count, Convert.ToDouble(txbAmount.Text),
                                    txbCause.Text, currentDonorId);

            ListUtil.donations.Add(donation);

            MessageBox.Show("Donation Added");

            this.Close();
        }

    }
}
