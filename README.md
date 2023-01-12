When you're ready to take your game to the next level, your code could be improved by keeping each form's UI controls private and using properties and methods to access the values between forms. The thing is, we really don't _want_ the AddGame form to have access to the main form's list view. Here's one way to streamline the design in three easy steps.

***
**Make a class to represent a Game (that will become a ListViewItem)**

    public class Game
    {
        public string? Play0Name { get; set; }
        public string? Players { get; set; }
        public string? Sequence1 { get; set; }
        public string? Sequence2 { get; set; }
        public string? Winner { get; set; }
        public string? Comments { get; set; }
        public DateTime GameDate { get; set; }
    }

***
**Add Game**

When you show the Add Game dialog its purpose is to populate the Game class. Once the user supplies enough information that the new game is valid then enable the [OK] button.

[![add-game][1]][1]

    public partial class AddGameForm : Form
    {
        public AddGameForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            buttonOK.Enabled = false; // Will be enabled when all the texboxes have values
            buttonOK.Click += (sender, e) =>DialogResult = DialogResult.OK;
            // Make an array of the textboxes.
            _textboxes = 
                Controls
                .Cast<Control>()
                .Where(_ => _ is TextBox)
                .Cast<TextBox>()
                .ToArray();
            foreach (var textbox in _textboxes) textbox.TextChanged += onAnyTextChanged;
        }
        // Determine if the game is valid by looking through all the textboxes.
        private void onAnyTextChanged(object? sender, EventArgs e)
        {
            buttonOK.Enabled = !_textboxes.Any(_=>string.IsNullOrWhiteSpace(_.Text));
        }
        private TextBox[] _textboxes;
        // If this dialog returns [OK] then the main form 
        // can retrieve the valid game using this method.
        public Game GetGame()
        {
            Game game = new Game
            {
                Play0Name = textBoxPlay0Name.Text,
                Players = textBoxPlayers.Text,
                Sequence1 = textBoxSequence1.Text,
                Sequence2 = textBoxSequence2.Text, 
                Winner = textBoxWinner.Text, 
                Comments = textBoxComments.Text, 
            };
            return game;
        }
        // Position the form relative to the main form when shown.
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if(Visible && Owner != null) 
            {
                Location = new Point(
                    x: Owner.Location.X + Owner.Width + 10,
                    y: Owner.Location.Y);
            }
        }
    }
***
**Retrieve valid Game**

If the `AddGameForm` returns `DialogResult.OK` it means it holds a valid game form that you can retrieve and assign however you want to the ListView.

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

  [1]: https://i.stack.imgur.com/fCPf4.png