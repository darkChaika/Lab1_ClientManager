namespace ClientManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            addButton = new Button();
            removeButton = new Button();
            searchButton = new Button();
            clientListBox = new ListBox();
            searchTextBox = new TextBox();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(29, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 0;
            nameTextBox.Text = "Name";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(29, 70);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(100, 23);
            emailTextBox.TabIndex = 1;
            emailTextBox.Text = "Email";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(29, 112);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(100, 23);
            phoneTextBox.TabIndex = 2;
            phoneTextBox.Text = "Phone";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(29, 153);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(100, 23);
            addressTextBox.TabIndex = 3;
            addressTextBox.Text = "Address";
            // 
            // addButton
            // 
            addButton.Location = new Point(165, 69);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(165, 111);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 5;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(461, 26);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 6;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clientListBox
            // 
            clientListBox.FormattingEnabled = true;
            clientListBox.ItemHeight = 15;
            clientListBox.Location = new Point(289, 89);
            clientListBox.Name = "clientListBox";
            clientListBox.Size = new Size(247, 94);
            clientListBox.TabIndex = 7;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(289, 26);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchTextBox);
            Controls.Add(clientListBox);
            Controls.Add(searchButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(addressTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private Button addButton;
        private Button removeButton;
        private Button searchButton;
        private ListBox clientListBox;
        private TextBox searchTextBox;
    }
}
