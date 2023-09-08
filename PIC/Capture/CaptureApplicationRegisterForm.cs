//using PIC.CatchingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIC
{
    public partial class CaptureForm : Form
    {
        CaptureApplicationRegister Register { get; set; }
        User User { get; set; }

        public CaptureForm()
        {
            InitializeComponent();
        }
        private void AddCaptureButton_Click(object sender, EventArgs e)
        {
            //считать данные из элементов в лист строк и распарсить???
            //обернуть создание в трай кэтч? обработать эксепшн создания
            CaptureApplication capture = new CaptureApplication(); //здесь что то придумать с вызовом добавления captAnimalCard
            bool allowed = CaptureController.CanMakeCapture(User.PermissionCode);
            if (allowed)
            {
                //CaptureController.AddCapture(capture);//или здесь
            }
        }

        private void LoadCaptureRegisterButton_Click(object sender, EventArgs e)
        {
            CaptureApplicationRegister capt = new CaptureApplicationRegister();
            Dictionary<string, string> filter = new Dictionary<string, string>(); //здесь как то составляем словарь для фильтрации. Значения брать из элементов формы.
            Dictionary<string, string> sort = new Dictionary<string, string>(); //здесь как то составляем словарь для сортировки. Значения брать из элементов формы.

            List<CaptureApplication> f1 = capt.LoadCaptureRegister(filter, sort);
            List<CaptureApplication> f2 = capt.GetUserFilter(User);
            List<CaptureApplication> finalFilter = CaptureApplicationRegister.GetFinalFilter(f1, f2);

            capt.LoadCaptureRegister(finalFilter, sort);
            //отображаем на форме этот са
        }

    }
}
