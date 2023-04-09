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
using WpfApp1.Models;
using System.Text.RegularExpressions;//Dùng khi Check DL
using System.Reflection;//Dùng khi chọn dòng
using System.Reflection.PortableExecutable;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Capnhatsanpham : Window
    {
        public Capnhatsanpham()
        {
            InitializeComponent();
        }
      QLBHContext db = new QLBHContext();
        private void Hienthidulieu()
        {
            var query = from sp in db.SanPhams
                        orderby sp.DonGia
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuong,
                            sp.DonGia,
                            ThanhTien = sp.DonGia * sp.SoLuong,
                        };
            dvgSanPham.ItemsSource = query.ToList();
        }
        private void HienThiCB()
        {
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            cboLoaiSP.ItemsSource =query.ToList();
            cboLoaiSP.DisplayMemberPath = "TenLoai";
            cboLoaiSP.SelectedValuePath = "MaLoai";
            cboLoaiSP.SelectedIndex = 0;

        }

        private void Window_Loader(object sender, RoutedEventArgs e)
        {
            HienThiCB();
            Hienthidulieu();
        }

    }

}
