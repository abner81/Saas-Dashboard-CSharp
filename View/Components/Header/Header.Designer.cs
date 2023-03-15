namespace Dashboard_Study.View.Components
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            textBox1 = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(722, 26);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 27;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(424, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 22);
            textBox1.TabIndex = 26;
            textBox1.Text = "Pesquisar...";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(158, 161, 176);
            lblTitle.Location = new Point(29, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(89, 31);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "[Title]";
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(btnClose);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Location = new Point(0, 17);
            Name = "Header";
            Size = new Size(784, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private TextBox textBox1;
        private Label lblTitle;
    }
}
