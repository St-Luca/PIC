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
    public partial class MunicipalContractRegisterForm : Form
    {
        MunicipalContractRegister Register { get; set; }
        User User { get; set; }
        public MunicipalContractRegisterForm()
        {
            InitializeComponent();
        }

        private bool CanAddMunicipalContract()
        {
            return User.PermissionCode == 1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //считать данные из элементов в лист строк и распарсить???
            //обернуть создание в трай кэтч? обработать эксепшн создания
            MunicipalContract ca = new MunicipalContract();
            bool allowed = MunicipalContractController.CanAddMunicipalContract(User.PermissionCode);
        }
    }
}
