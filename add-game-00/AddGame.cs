using System.Data;

namespace add_game_00
{
    public partial class AddGameForm : Form
    {
        public AddGameForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            buttonOK.Enabled = false; // Will be enabled when all the texboxes have values
            buttonOK.Click += (sender, e) =>DialogResult = DialogResult.OK;
            _textboxes = 
                Controls
                .Cast<Control>()
                .Where(_ => _ is TextBox)
                .Cast<TextBox>()
                .ToArray();
            foreach (var textbox in _textboxes) textbox.TextChanged += onAnyTextChanged;
        }
        private void onAnyTextChanged(object? sender, EventArgs e)
        {
            buttonOK.Enabled = !_textboxes.Any(_=>string.IsNullOrWhiteSpace(_.Text));
        }
        private TextBox[] _textboxes;
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
    }
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
}
