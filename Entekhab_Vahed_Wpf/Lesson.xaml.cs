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
    /// Interaction logic for Lesson.xaml
    /// </summary>
    public partial class Lesson : Window
    {
        EVContext db = new EVContext();
        public Lesson()
        {
            InitializeComponent();
            var f = db.Lessons.OrderByDescending(u => u.lCode).FirstOrDefault();
            if (f != null)
            {
                txtCode.Text = (int.Parse(f.lCode.ToString()) + 1).ToString();
            }
            else
            {
                txtCode.Text = "1";
            }

            var lst = (from x in db.Fields select new { x.FieldId, x.FieldName }).ToList();
            cmbField.ItemsSource = lst;
            cmbField.DisplayMemberPath = "FieldName";
            cmbField.SelectedValuePath = "FieldId";

            var lst1 = (from x in db.Professors select new { x.pCode, x.LastName }).ToList();
            cmbProf.ItemsSource = lst1;
            cmbProf.DisplayMemberPath = "LastName";
            cmbProf.SelectedValuePath = "pCode";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" && txtUnit.Text == "")
            {
                MessageBox.Show("تمامی فیلدها را وارد نمایید");
                return;
            }
            var les = new Lessonx()
            {
               Name=txtName.Text,
               Vahed=int.Parse(txtUnit.Text),
               field_id= int.Parse(cmbField.SelectedValue.ToString()),
               prof_id= int.Parse(cmbProf.SelectedValue.ToString())

            };

            db.Lessons.Add(les);
            db.SaveChanges();
            MessageBox.Show("درس با موفقیت ذخیره شد");
            Window_Loaded(sender, e);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = (from x in db.Lessons select new { x.lCode, x.Name, x.Vahed, x.Field.FieldName, x.Professor.LastName }).ToList();
            dataGrid.ItemsSource = lst;
            dataGrid.Columns[0].Header = "کد درس";
            dataGrid.Columns[1].Header = "نام درس";
            dataGrid.Columns[2].Header = "تعداد واحد";
            dataGrid.Columns[3].Header = "نام رشته";
            dataGrid.Columns[4].Header = "نام استاد";
        }

        private void btnDell_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {

                object item = dataGrid.SelectedItem;
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                Lessonx p = (from r in db.Lessons where r.lCode == Id select r).SingleOrDefault();
                db.Lessons.Remove(p);
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
