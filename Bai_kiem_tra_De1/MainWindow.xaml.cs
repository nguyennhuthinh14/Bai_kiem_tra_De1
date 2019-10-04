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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai_kiem_tra_De1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnKetqua_Click(object sender, RoutedEventArgs e)
        {
            double diemvan = double.Parse(txtDiemmonNguvan.Text);
            double diemtoan = double.Parse(txtDiemmonToan.Text);
            double diemtb = 0;
            diemtb = (diemvan + diemtoan) / 2;
            if (rbGioi.IsChecked == true)
            {
                if (diemtb >= 8.0)
                {
                    MessageBox.Show("Ten SV:  " + txtTenSV.Text + "\n" + "Ma so SV:  " + txtMasoSV.Text + "\n" + "Diem TB:  " + diemtb + "\n" + "Danh hieu:  " + "Gioi");
                }
                if (diemtb < 8.0)
                    MessageBox.Show("Ten SV:  " + txtTenSV.Text + "\n" + "Ma so SV:  " + txtMasoSV.Text + "\n" + "Diem TB:  " + diemtb + "\n" + "Danh hieu:  " + "Không khen thưởng");
            }

            if (rbKha.IsChecked == true)
            {
                if (diemtb >= 7.0)
                {
                    MessageBox.Show("Ten SV:  " + txtTenSV.Text + "\n" + "Ma so SV:  " + txtMasoSV.Text + "\n" + "Diem TB:  " + diemtb + "\n" + "Danh hieu:  " + "Kha");
                }
                if (diemtb < 7.0)
                    MessageBox.Show("Ten SV:  " + txtTenSV.Text + "\n" + "Ma so SV:  " + txtMasoSV.Text + "\n" + "Diem TB:  " + diemtb + "\n" + "Danh hieu:  " + "Không khen thưởng");
            }

            if (rbYeu.IsChecked == true)
            {
                MessageBox.Show("Ten SV:  " + txtTenSV.Text + "\n" + "Ma so SV:  " + txtMasoSV.Text + "\n" + "Diem TB:  " + diemtb + "\n" + "Danh hieu:  " + "Không khen thưởng");
            }
        }
        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
   
