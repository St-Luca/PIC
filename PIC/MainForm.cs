using System.Windows.Forms;

namespace PIC
{
    public partial class MainForm : Form
    {
        private User User { get; set; }
        public MainForm(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void êîíòðàêòûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MunicipalContractRegister register = new MunicipalContractRegister(new List<MunicipalContract> {
            new MunicipalContract(1, new DateTime(2023, 9, 19), new DateTime(2023, 9, 29), new Organization(1, "TumGU", "32121", "kpp1", "address1", "orgtype1", "orgattr1"), 
                                 new Organization(2, "TumGU2", "321221", "kpp2", "address2", "orgtype2", "orgattr2"), new List<Locality> { new Locality(1, "TumObl", "Tum") },25.5),
           // new MunicipalContract(),
           // new MunicipalContract()          
            });
            MunicipalContractRegisterForm form = new MunicipalContractRegisterForm(register, User);
            form.ShowDialog();
        }
    }
}