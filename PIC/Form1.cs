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
    }
}