namespace SzabaduloForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Megerõsítõ kérdés után engedi csak bezárni a programot
            DialogResult result = MessageBox.Show(
                "Biztosan ki szeretnél lépni az alkalmazásból?",
                "Kilépés megerõsítése",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void FoglalasButton_Click(object sender, EventArgs e)
        {
            //Szabadulószoba foglalás ablak megnyitása

            panel1.Controls.Clear();

            FoglalasControl ujuser = new FoglalasControl();

            panel1.Controls.Add(ujuser);

            ujuser.Dock = DockStyle.Fill;
        }
    }
}