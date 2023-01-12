namespace add_game_00
{
    partial class AddGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSequence1 = new System.Windows.Forms.TextBox();
            this.textBoxSequence2 = new System.Windows.Forms.TextBox();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.textBoxWinner = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.textBoxPlay0Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSequence1
            // 
            this.textBoxSequence1.Location = new System.Drawing.Point(28, 124);
            this.textBoxSequence1.Name = "textBoxSequence1";
            this.textBoxSequence1.PlaceholderText = "Sequence 1";
            this.textBoxSequence1.Size = new System.Drawing.Size(223, 31);
            this.textBoxSequence1.TabIndex = 3;
            // 
            // textBoxSequence2
            // 
            this.textBoxSequence2.Location = new System.Drawing.Point(28, 160);
            this.textBoxSequence2.Name = "textBoxSequence2";
            this.textBoxSequence2.PlaceholderText = "Sequence 2";
            this.textBoxSequence2.Size = new System.Drawing.Size(223, 31);
            this.textBoxSequence2.TabIndex = 4;
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(271, 17);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.PlaceholderText = "Comments";
            this.textBoxComments.Size = new System.Drawing.Size(195, 210);
            this.textBoxComments.TabIndex = 5;
            // 
            // textBoxWinner
            // 
            this.textBoxWinner.Location = new System.Drawing.Point(28, 196);
            this.textBoxWinner.Name = "textBoxWinner";
            this.textBoxWinner.PlaceholderText = "Winner";
            this.textBoxWinner.Size = new System.Drawing.Size(223, 31);
            this.textBoxWinner.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(271, 248);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(195, 34);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 31);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.Location = new System.Drawing.Point(28, 88);
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.PlaceholderText = "Players";
            this.textBoxPlayers.Size = new System.Drawing.Size(223, 31);
            this.textBoxPlayers.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBoxPlay0Name.Location = new System.Drawing.Point(28, 54);
            this.textBoxPlay0Name.Name = "textBox1";
            this.textBoxPlay0Name.PlaceholderText = "Players";
            this.textBoxPlay0Name.Size = new System.Drawing.Size(223, 31);
            this.textBoxPlay0Name.TabIndex = 1;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 294);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.textBoxWinner);
            this.Controls.Add(this.textBoxSequence2);
            this.Controls.Add(this.textBoxSequence1);
            this.Controls.Add(this.textBoxPlay0Name);
            this.Controls.Add(this.textBoxPlayers);
            this.Name = "AddGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxSequence1;
        private TextBox textBoxSequence2;
        private TextBox textBoxComments;
        private TextBox textBoxWinner;
        private Button buttonOK;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxPlayers;
        private TextBox textBoxPlay0Name;
    }
}