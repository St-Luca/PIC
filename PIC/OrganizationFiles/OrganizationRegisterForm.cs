//using PIC.CatchingApp;
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
    public partial class OrganizationRegisterForm : Form
    {
        OrganizationRegister Register { get; set; }
        User User { get; set; }
        public OrganizationRegisterForm()
        {
            InitializeComponent();
        }

        private void LoadOrgRegisterButton_Click(object sender, EventArgs e)
        {
            OrganizationRegister org = new OrganizationRegister();
            Dictionary<string, string> filter = new Dictionary<string, string>(); //здесь как то составляем словарь для фильтрации. Значения брать из элементов формы.
            Dictionary<string, string> sort = new Dictionary<string, string>(); //здесь как то составляем словарь для сортировки. Значения брать из элементов формы.

            List<Organization> f1 = org.LoadOrganizationRegister(filter, sort);
            List<Organization> f2 = org.GetUserFilter(User);
            List<Organization> finalFilter = OrganizationRegister.GetFinalFilter(f1, f2);

            org.LoadOrganizationRegister(finalFilter, sort);
            //отображаем на форме этот org
        }
    }
}
