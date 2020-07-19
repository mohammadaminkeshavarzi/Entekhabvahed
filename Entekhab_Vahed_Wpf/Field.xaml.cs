using Entekhab_Vahed_Wpf.Config;
using Entekhab_Vahed_Wpf.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Entekhab_Vahed_Wpf
{
    /// <summary>
    /// Interaction logic for Field.xaml
    /// </summary>
    public partial class Field : Window
    {
        EVContext db = new EVContext();
        public Field()
        {
            InitializeComponent();
            var f = db.Fields.OrderByDescending(u => u.FieldId).FirstOrDefault();
            if (f != null)
            {
                txtCodeF.Text =(int.Parse(f.FieldId.ToString())+1).ToString();
            }
            else
            {
                txtCodeF.Text = "1";
            }

            // int intIdt = db.Fields.Max(u => u.FieldId);
            // int? intIdt = db.Fields.Max(u => (int?)u.FieldId);

        }

        private void btnSaveF_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameF.Text == "")
            {
                MessageBox.Show("نام رشته را وارد نمایید");
                return;
            }
            var field = new Fieldx()
            {
                FieldName = txtNameF.Text
            };

            db.Fields.Add(field);
            db.SaveChanges();
            MessageBox.Show("رشته با موفقیت ذخیره شد");
            Window_Loaded(sender, e);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = (from x in db.Fields select new { x.FieldId, x.FieldName }).ToList();
            dataGrid.ItemsSource = lst;
            dataGrid.Columns[0].Header = "کد رشته";
            dataGrid.Columns[1].Header = "نام رشته";
        }

        private void btnDellF_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {

                object item = dataGrid.SelectedItem; //probably you find this object
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
           
                Fieldx f = (from r in db.Fields where r.FieldId == Id select r).SingleOrDefault();
                db.Fields.Remove(f);
                db.SaveChanges();
                MessageBox.Show("با موفقیت حذف شد");
                Window_Loaded(sender, e);

            }
            else
            {
                MessageBox.Show("یک رکورد را انتخاب نمایید");
            }
        }

       
    }
}
