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
    }
}
