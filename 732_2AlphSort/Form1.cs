namespace _732_2AlphSort
{
    public partial class MainForm : Form
    {
        private bool is_authed = false;
        private Sorter1 sorter = new Sorter1();

        public MainForm()
        {
            InitializeComponent();
            Output.Text = "";

            Opacity = 0;
            ShowInTaskbar = false;
        }

        public void UserAuthed()
        {
            Opacity = 100;
            ShowInTaskbar = true;
            this.Activate();
            is_authed = true;
        }

        private void MakeSort_Click(object sender, EventArgs e)
        {
            string str = Input.Text;

            Output.Text = sorter.MakeSort(str);

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_authed)
            {
                DialogResult answer = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Внимание!", MessageBoxButtons.YesNoCancel);

                if (answer != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != ' ')
            {
                e.Handled = true;
            }

        }
    }
}