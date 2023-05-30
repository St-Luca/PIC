using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
