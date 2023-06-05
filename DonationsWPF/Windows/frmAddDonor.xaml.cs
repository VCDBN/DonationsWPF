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
    /// Interaction logic for frmAddDonor.xaml
    /// </summary>
    public partial class frmAddDonor : Window
    {
        public frmAddDonor()
        {
            InitializeComponent();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            int donorId = ListUtil.donorList.Count + 1;
            string name = txbName.Text;
            string surname = txbSurname.Text;
            string phone = txbPhone.Text;
            string email = txbEmail.Text;

            Donor donor = new Donor(donorId, name, surname, phone, email);

            ListUtil.donorList.Add(donor);

            MessageBox.Show("Donor Added");

            this.Close();
        }
    }
}
