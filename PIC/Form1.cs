namespace PIC
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private User User { get; set; }
        public Form1(User user)
        {
            InitializeComponent();
            User = user;    
        }
    }
}