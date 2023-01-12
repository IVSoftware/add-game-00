namespace add_game_00
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonAddGame.Click += onClickAddGame;
        }        
        private void onClickAddGame(object? sender, EventArgs e)
        {
            using (AddGameForm addGame = new AddGameForm())
            {
                if (DialogResult.OK.Equals(addGame.ShowDialog(this)))
                {
                    Game game = addGame.GetGame();
                    // Use the info given via textboxes and add them to items/subitems
                    ListViewItem lvi = new ListViewItem(game.Players);
                    lvi.SubItems.Add(game.Players);
                    lvi.SubItems.Add(game.Sequence1);
                    lvi.SubItems.Add(game.Sequence2);
                    lvi.SubItems.Add(game.Comments);
                    lvi.SubItems.Add(game.Winner);
                    lvi.SubItems.Add(game.GameDate.ToShortDateString());

                    // Add the items to the list view.
                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}