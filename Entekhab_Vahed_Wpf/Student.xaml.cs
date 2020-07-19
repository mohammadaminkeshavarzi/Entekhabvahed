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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        EVContext db = new EVContext();
        public Student()
        {
            InitializeComponent();
            var f = db.Students.OrderByDescending(u => u.sCode).FirstOrDefault();
            if (f != null)
            {
                txtCode.Text = (int.Parse(f.sCode.ToString()) + 1).ToString();
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
            if (txtName.Text == "" && txtLName.Text == "" && txtFather.Text == "" && txtCodM.Text == "")
            {
                MessageBox.Show("تمامی فیلد ها را وارد نمایید");
                return;
            }
            var stud = new Studentx()
            {
                FirstName = txtName.Text,
                LastName = txtLName.Text,
                FatherName = txtFather.Text,
                NatCode = Int32.Parse(txtCodM.Text),
                field_id = int.Parse(cmbField.SelectedValue.ToString()),
                Degree = cmbDegree.Text

            };

            db.Students.Add(stud);
            db.SaveChanges();
            MessageBox.Show("دانشجو با موفقیت ذخیره شد");
            Window_Loaded(sender, e);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = (from x in db.Students select new { x.sCode, x.FirstName, x.LastName, x.FatherName, x.NatCode, x.Field.FieldName, x.Degree }).ToList();
            dataGrid.ItemsSource = lst;
            dataGrid.Columns[0].Header = "شماره دانشجویی";
            dataGrid.Columns[1].Header = "نام دانشجویی";
            dataGrid.Columns[2].Header = "نام خانوادگی";
            dataGrid.Columns[3].Header = "نام پدر";
            dataGrid.Columns[4].Header = "کد ملی";
            dataGrid.Columns[5].Header = "نام رشته";
            dataGrid.Columns[6].Header = "مقطع تحصیلی";
        }

        private void btnDell_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {

                object item = dataGrid.SelectedItem;
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                Studentx p = (from r in db.Students where r.sCode == Id select r).SingleOrDefault();
                db.Students.Remove(p);
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
