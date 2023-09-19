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
        public MunicipalContractRegisterForm(MunicipalContractRegister register, User user)
        {
            InitializeComponent();
            Register = register;
            User = user;

            dataGridView1.AutoGenerateColumns = true;
            foreach(MunicipalContract mc in register.GetUserFilter(User))
            {
                string[] munContr = mc.GetStringData();
                dataGridView1.Rows.Add(munContr);
            }
        }

        private bool CanAddMunicipalContract()
        {
            return User.PermissionCode == 1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //считать данные из элементов в лист строк и распарсить???
            //обернуть создание в трай кэтч? обработать эксепшн создания
            MunicipalContract mc = new MunicipalContract();
            bool allowed = MunicipalContractController.CanAddMunicipalContract(User.PermissionCode);
            if (allowed)
            {
                MunicipalContractController.AddMunicipalContract(mc);
            }
        }

        private void LoadMunContractRegisterButton_Click(object sender, EventArgs e)
        {
            //MunicipalContractRegister ca = new MunicipalContractRegister();
            Dictionary<string, string> filter = new Dictionary<string, string>(); //здесь как то составляем словарь для фильтрации. Значения брать из элементов формы.
            Dictionary<string, string> sort = new Dictionary<string, string>(); //здесь как то составляем словарь для сортировки. Значения брать из элементов формы.

            List<MunicipalContract> f1 = Register.LoadMunicipalContractRegister(filter, sort);
            List<MunicipalContract> f2 = Register.GetUserFilter(User);
            List<MunicipalContract> finalFilter = MunicipalContractRegister.GetFinalFilter(f1, f2);

            Register.LoadMunicipalContractRegister(finalFilter, sort);
            //отображаем на форме этот са
        }
    }
}
