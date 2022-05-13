namespace BlakeEastwoodAssgt
{
    public partial class MainMenu : Form
    {
        GameInfo game1 = new GameInfo();
        public MainMenu()
        {
            InitializeComponent();

        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            game1.PlayerCount = Convert.ToInt32(PlayerBox.Text);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (game1.PlayerCount + game1.AiCount > 6)
            {
                System.Windows.Forms.MessageBox.Show("Too many players have been selected. make sure there is less than 6 chosen both in ai and players");
            }
            else if (game1.PlayerCount + game1.AiCount <= 1)
            {
                MessageBox.Show("Not enough players have been selected. Please select at least two players");
            }

            else
            {
                game1.TotalPlayers = game1.PlayerCount + game1.AiCount;
                Game frmGame = new Game(game1);
                frmGame.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testing testfrm = new testing(game1);
            testfrm.ShowDialog();
        }

        private void AIBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            game1.AiCount = Convert.ToInt32(AIBox.SelectedItem);
        }
    }
}