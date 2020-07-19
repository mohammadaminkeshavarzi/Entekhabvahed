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
using Entekhab_Vahed_Wpf.Config;
using Entekhab_Vahed_Wpf.Model;

namespace Entekhab_Vahed_Wpf
{
    /// <summary>
    /// Interaction logic for ChUnit.xaml
    /// </summary>
    public partial class ChUnit : Window
    {
        EVContext db = new EVContext();
        public ChUnit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("شماره دانشجویی را وارد نمایید");
                return;
            }
            if (cmbLesson.SelectedValue == null)
            {
                MessageBox.Show("یک درس را انتخاب نمایید");
                return;
            }
            int number = int.Parse(txtNumber.Text.ToString());
            int code = int.Parse(cmbLesson.SelectedValue.ToString());
            var exist = db.ChooseUnits.Where(x => x.lesson_code == code && x.stud_id== number).FirstOrDefault();
            if (exist != null)
            {
                MessageBox.Show("این درس را انتخاب نموده اید");
                return;
            }

            DateTime dt = ConvertDate.ConvertToGregorian(lblDate.Content.ToString());
            var time = (from c in db.ChooseUnits
                        join s in db.Classes
                        on c.lesson_code equals s.lesson_code
                        join l in db.Lessons on c.lesson_code equals l.lCode
                        where c.stud_id==number
                        select new { c, s, l }).ToList();
            foreach (var item in time)
            {
                if (item.s.Dates == dt)
                {
                    MessageBox.Show("تاریخ برگزاری این درس با درس " + item.l.Name + " تداخل دارد");
                    return;
                }
            }
       
            var ch = new ChooseUnit()
            {
                lesson_code = int.Parse(cmbLesson.SelectedValue.ToString()),
                prof_id = int.Parse(lblShOstad.Content.ToString()),
                stud_id = int.Parse(txtNumber.Text),
                field_id = int.Parse(lblFieldId.Content.ToString()),
                cUnit = int.Parse(lblVahed.Content.ToString()),
            };

            db.ChooseUnits.Add(ch);
            db.SaveChanges();
            MessageBox.Show("این درس انتخاب شد");
            unitData();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("شماره دانشجویی را وارد نمایید");
                return;
            }
            int id = int.Parse(txtNumber.Text.Trim());
            var q = (from s in db.Students
                     join f in db.Fields on s.field_id equals f.FieldId
                     where s.sCode == id
                     select new { s, f }).SingleOrDefault();

            if (q != null)
            {
                lblNameStud.Content = q.s.FirstName + " " + q.s.LastName;
                lblField.Content = q.f.FieldName;
                lblFieldId.Content = q.f.FieldId;
            }
            Lessonsx();
            cmbLesson.IsEnabled = true;
            btnSave.IsEnabled = true;
            unitData();

            float ave = 0, t = 0, v = 0;
            var average = db.Scores.Where(x => x.stud_id == id).ToList();
            foreach (var item in average)
            {
                t += item.score1 * item.cUnit;
                v += item.cUnit;
            }
            ave = t / v;
            lblAve.Content = ave.ToString();
        }

        private void Lessonsx()
        {
            int id = int.Parse(lblFieldId.Content.ToString());
            var lst = (from x in db.Lessons where x.field_id == id select new { x.lCode, x.Name }).ToList();
            cmbLesson.ItemsSource = lst;
            cmbLesson.DisplayMemberPath = "Name";
            cmbLesson.SelectedValuePath = "lCode";
        }

        private void cmbLesson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int x = int.Parse(cmbLesson.SelectedValue.ToString());
            var q = (from l in db.Lessons
                     join f in db.Fields on l.field_id equals f.FieldId
                     join p in db.Professors on l.prof_id equals p.pCode
                     join c in db.Classes on l.lCode equals c.lesson_code
                     where l.lCode == x
                     select new { l, f, p, c }).SingleOrDefault();

            if (q != null)
            {
                lblVahed.Content = q.l.Vahed;
                lblShOstad.Content = q.p.pCode;
                lblNameOstad.Content = q.p.FirstName + " " + q.p.LastName;
                lblShClass.Content = q.c.classCode;
                lblNameClass.Content = q.c.ClassName;
                lblDate.Content = ConvertDate.GetPdate(q.c.Dates);
                lblTime.Content = q.c.Times;
            }
        }

        private void unitData()
        {
            int id = int.Parse(txtNumber.Text);
            var q = (from u in db.ChooseUnits
                     join f in db.Fields on u.field_id equals f.FieldId
                     join p in db.Professors on u.prof_id equals p.pCode
                     join s in db.Students on u.stud_id equals s.sCode
                     join l in db.Lessons on u.lesson_code equals l.lCode
                     where u.stud_id == id
                     select new {u.CUCode, l.Name, f.FieldName, p.LastName, u.cUnit }).ToList();

            dataGrid.ItemsSource = q;
            dataGrid.Columns[0].Header = "شناسه ثبت";
            dataGrid.Columns[1].Header = "نام درس";
            dataGrid.Columns[2].Header = "نام رشته";
            dataGrid.Columns[3].Header = "استاد درس";
            dataGrid.Columns[4].Header = "تعداد واحد";
        }

        private void btnDell_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                object item = dataGrid.SelectedItem; 
                int Id = int.Parse((dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                var f = (from r in db.ChooseUnits where r.CUCode == Id select r).SingleOrDefault();
                db.ChooseUnits.Remove(f);
                db.SaveChanges();
                MessageBox.Show("با موفقیت حذف شد");
                unitData();
            }
            else
            {
                MessageBox.Show("یک رکورد را انتخاب نمایید");
            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
