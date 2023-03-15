namespace Dashboard_Study.View.Components
{
    partial class SideMenuItem
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
            button = new Button();
            borderLeft = new Panel();
            SuspendLayout();
            // 
            // button
            // 
            button.Dock = DockStyle.Fill;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button.ForeColor = Color.FromArgb(0, 126, 249);
            button.Image = Properties.Resources.home;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Location = new Point(0, 0);
            button.Name = "button";
            button.Padding = new Padding(15, 0, 0, 0);
            button.Size = new Size(259, 45);
            button.TabIndex = 0;
            button.Text = "Dashboard";
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
            button.UseVisualStyleBackColor = true;
            // 
            // borderLetf
            // 
            borderLeft.BackColor = Color.FromArgb(0, 126, 249);
            borderLeft.Dock = DockStyle.Left;
            borderLeft.Location = new Point(0, 0);
            borderLeft.Name = "borderLetf";
            borderLeft.Size = new Size(3, 45);
            borderLeft.TabIndex = 6;
            // 
            // SideMenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            Controls.Add(borderLeft);
            Controls.Add(button);
            Name = "SideMenuItem";
            Size = new Size(259, 45);
            ResumeLayout(false);
        }

        #endregion

        private Button button;
        private Panel borderLeft;
    }
}
