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
    /// Interaction logic for Scores.xaml
    /// </summary>
    public partial class Scores : Window
    {
        EVContext db = new EVContext();
        public Scores()
        {
            InitializeComponent();
            var f = db.Scores.OrderByDescending(u => u.scCode).FirstOrDefault();
            if (f != null)
            {
                txtCode.Text = (int.Parse(f.scCode.ToString()) + 1).ToString();
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

            var lst2 = (from x in db.Students select new { x.sCode, Name = (x.FirstName + " " + x.LastName) }).ToList();
            cmbStud.ItemsSource = lst2;
            cmbStud.DisplayMemberPath = "Name";
            cmbStud.SelectedValuePath = "sCode";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtScore.Text == "" && txtUnit.Text == "")
            {
                MessageBox.Show("تمامی فیلدها را وارد نمایید");
                return;
            }
            var score = new Scorex()
            {
              score1=int.Parse(txtScore.Text),
              cUnit=int.Parse(txtUnit.Text),
              lesson_code= int.Parse(cmbLesson.SelectedValue.ToString()),
              prof_id= int.Parse(cmbProf.SelectedValue.ToString()),
                stud_id = int.Parse(cmbStud.SelectedValue.ToString())

            };

            db.Scores.Add(score);
            db.SaveChanges();
            MessageBox.Show("نمره با موفقیت ذخیره شد");

            Window_Loaded(sender, e);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lst = (from x in db.Scores select new { x.scCode, x.score1, x.cUnit, x.Lesson.Name, x.Professor.LastName, x.Student.FirstName }).ToList();
            dataGrid.ItemsSource = lst;
            dataGrid.Columns[0].Header = "کد نمره";
            dataGrid.Columns[1].Header = "نمره";
            dataGrid.Columns[2].Header = "واحد درس";
            dataGrid.Columns[3].Header = "نام درس";
            dataGrid.Columns[4].Header = "نام استاد";
            dataGrid.Columns[5].Header = "نام دانشجو";
        }

        private void btnDell_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                object item = dataGrid.SelectedItem;
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                Scorex p = (from r in db.Scores where r.scCode == Id select r).SingleOrDefault();
                db.Scores.Remove(p);
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
