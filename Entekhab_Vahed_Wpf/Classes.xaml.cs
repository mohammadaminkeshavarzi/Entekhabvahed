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
    /// Interaction logic for Classes.xaml
    /// </summary>
    public partial class Classes : Window
    {
        EVContext db = new EVContext();
        public Classes()
        {
            InitializeComponent();
            var f = db.Classes.OrderByDescending(u => u.classCode).FirstOrDefault();
            if (f != null)
            {
                txtCode.Text = (int.Parse(f.classCode.ToString()) + 1).ToString();
            }
            else
            {
                txtCode.Text = "1";
            }

            var lst = (from x in db.Lessons select new { x.lCode, x.Name }).ToList();
            cmbLesson.ItemsSource = lst;
            cmbLesson.DisplayMemberPath = "Name";
            cmbLesson.SelectedValuePath = "lCode";

            var lst1 = (from x in db.Professors select new { x.pCode, x.LastName }).ToList();
            cmbProf.ItemsSource = lst1;
            cmbProf.DisplayMemberPath = "LastName";
            cmbProf.SelectedValuePath = "pCode";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" && txtCapecity.Text == "" && txtDate.Text == "" && txtMakan.Text == "" && txtTime.Text == "")
            {
                MessageBox.Show("تمامی فیلدها را وارد نمایید");
                return;
            }
            var cls = new Classx()
            {
              ClassName=txtName.Text,
              Dates=ConvertDate.ConvertToGregorian(txtDate.Text),
              capacity= int.Parse(txtCapecity.Text),
              lesson_code=int.Parse(cmbLesson.SelectedValue.ToString()),
              Makan=txtMakan.Text,
              Times=TimeSpan.Parse(txtTime.Text),
              prof_id= int.Parse(cmbProf.SelectedValue.ToString())
            };

            db.Classes.Add(cls);
            db.SaveChanges();
            MessageBox.Show("کلاس با موفقیت ذخیره شد");
            Window_Loaded(sender, e);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = (from x in db.Classes select new { x.classCode, x.ClassName, Dates = ConvertDate.GetPdate(x.Dates), x.Times, x.Lesson.Name, x.Professor.LastName, x.capacity, x.Makan }).ToList();
            dataGrid.ItemsSource = lst;
            dataGrid.Columns[0].Header = "کد کلاس";
            dataGrid.Columns[1].Header = "نام کلاس";
            dataGrid.Columns[2].Header = "تاریخ برگزاری";
            dataGrid.Columns[3].Header = "ساعت برگزاری";
            dataGrid.Columns[4].Header = "نام درس";
            dataGrid.Columns[5].Header = "نام استاد";
            dataGrid.Columns[6].Header = "ظرفیت کلاس";
            dataGrid.Columns[7].Header = "مکان برگزاری";
        }

        private void btnDell_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {

                object item = dataGrid.SelectedItem;
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                Classx p = (from r in db.Classes where r.classCode == Id select r).SingleOrDefault();
                db.Classes.Remove(p);
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
