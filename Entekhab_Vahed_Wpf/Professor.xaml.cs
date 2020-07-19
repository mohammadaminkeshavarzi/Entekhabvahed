using Entekhab_Vahed_Wpf.Config;
using Entekhab_Vahed_Wpf.Model;
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

namespace Entekhab_Vahed_Wpf
{
    /// <summary>
    /// Interaction logic for Professor.xaml
    /// </summary>
    public partial class Professor : Window
    {
        EVContext db = new EVContext();
        public Professor()
        {
            InitializeComponent();
            var f = db.Professors.OrderByDescending(u => u.pCode).FirstOrDefault();
            if (f != null)
            {
                txtCode.Text = (int.Parse(f.pCode.ToString()) + 1).ToString();
            }
            else
            {
                txtCode.Text = "1";
            }

            var lst = (from x in db.Fields select new { x.FieldId, x.FieldName }).ToList();
            cmbField.ItemsSource = lst;
            cmbField.DisplayMemberPath = "FieldName";
            cmbField.SelectedValuePath = "FieldId";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" && txtLName.Text == "")
            {
                MessageBox.Show("نام و نام خانوادگی را وارد نمایید");
                return;
            }
            var prof = new Professorx()
            {
                FirstName = txtName.Text,
                LastName = txtLName.Text,
                field_id =int.Parse(cmbField.SelectedValue.ToString()),
                Degree = cmbDegree.Text
            };

            db.Professors.Add(prof);
            db.SaveChanges();
            MessageBox.Show("استاد با موفقیت ذخیره شد");
            Window_Loaded(sender, e);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = (from x in db.Professors select new { x.pCode, x.FirstName, x.LastName, x.Field.FieldName, x.Degree }).ToList();
            dataGrid.ItemsSource = lst;
            dataGrid.Columns[0].Header = "کد استاد";
            dataGrid.Columns[1].Header = "نام استاد";
            dataGrid.Columns[2].Header = "نام خانوادگی";
            dataGrid.Columns[3].Header = "نام رشته";
            dataGrid.Columns[4].Header = "مقطع تحصیلی";
        }

        private void btnDell_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {

                object item = dataGrid.SelectedItem; 
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                Professorx p = (from r in db.Professors where r.pCode == Id select r).SingleOrDefault();
                db.Professors.Remove(p);
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
