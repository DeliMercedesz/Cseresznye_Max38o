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
            // Meger�s�t� k�rd�s ut�n engedi csak bez�rni a programot
            DialogResult result = MessageBox.Show(
                "Biztosan ki szeretn�l l�pni az alkalmaz�sb�l?",
                "Kil�p�s meger�s�t�se",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void FoglalasButton_Click(object sender, EventArgs e)
        {
            //Szabadul�szoba foglal�s ablak megnyit�sa

            panel1.Controls.Clear();

            FoglalasControl ujuser = new FoglalasControl();

            panel1.Controls.Add(ujuser);

            ujuser.Dock = DockStyle.Fill;
        }
    }
}