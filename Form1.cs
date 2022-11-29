namespace EvDP_05LabExer2_11252022_WITHOUT_Challenge
{
    public partial class frmOpenTextFile : Form
    {
        public frmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Do Nothing Yet
            displayToList();
        }

        public void displayToList()
        {
            //Set Directory at Fixed 
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Browse Text Files";
            //Extensions that must be supported, based on Elms
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files(.txt) | *.txt | All files(*.*) | *.*";
            openFileDialog1.ShowDialog();
            string Path = openFileDialog1.FileName;
            using (StreamReader readFile = File.OpenText(Path))
            {
                string _getText = "";
                while ((_getText = readFile.ReadLine()) != null)
                {
                    lvShowText.Items.Add(_getText);
                }
            }

        }
    }
}