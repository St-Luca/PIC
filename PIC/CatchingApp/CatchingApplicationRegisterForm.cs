using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIC.CatchingApp;

namespace PIC
{
    public partial class CatchingApplicationRegisterForm : Form
    {
        CatchingApplicationRegister Register { get; set; }
        User User { get; set; }
        public CatchingApplicationRegisterForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //считать данные из элементов в лист строк и распарсить???
            //обернуть создание в трай кэтч? обработать эксепшн создания
            CatchingApplication ca = new CatchingApplication();
            bool allowed = CatchingApplicationController.CanAddCatchingApplication(User.PermissionCode);
            if(allowed)
            {
                CatchingApplicationController.AddCatchingApplication(ca);
            }
        }

        private void LoadCatAppRegButton_Click(object sender, EventArgs e)
        {
            CatchingApplicationRegister ca = new CatchingApplicationRegister();
            Dictionary<string, string> filter = new Dictionary<string, string>(); //здесь как то составляем словарь для фильтрации. Значения брать из элементов формы.
            Dictionary<string, string> sort = new Dictionary<string, string>(); //здесь как то составляем словарь для сортировки. Значения брать из элементов формы.

            List<CatchingApplication> f1 = ca.LoadCatchingApplicationRegister(filter, sort);
            List<CatchingApplication> f2 = ca.GetUserFilter(User);
            List<CatchingApplication> finalFilter = CatchingApplicationRegister.GetFinalFilter(f1, f2);

            ca.LoadCatchingApplicationRegister(finalFilter, sort);
            //отображаем на форме этот са
        }
    }
}
