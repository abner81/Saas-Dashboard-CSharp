using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Dashboard_Study.View.Components;

namespace Dashboard_Study.View
{
    partial class MainForm
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
            panel1 = new Panel();
            sideMenu = new SideMenu();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            contentPlace = new Panel();
            header = new Header();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(sideMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 4;
            // 
            // sideMenu
            // 
            sideMenu.BackColor = Color.FromArgb(24, 30, 54);
            sideMenu.Dock = DockStyle.Fill;
            sideMenu.Location = new Point(0, 144);
            sideMenu.Margin = new Padding(6);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(186, 433);
            sideMenu.TabIndex = 9;
            sideMenu.ItemSelectionChanged += sideMenu_ItemSelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 257);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(36, 97);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 1;
            label2.Text = "Abner Machado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_11;
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contentPlace
            // 
            contentPlace.Location = new Point(186, 97);
            contentPlace.Name = "contentPlace";
            contentPlace.Size = new Size(765, 480);
            contentPlace.TabIndex = 25;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(46, 51, 73);
            header.Dock = DockStyle.Top;
            header.Location = new Point(186, 0);
            header.Margin = new Padding(6);
            header.Name = "header";
            header.Size = new Size(764, 65);
            header.TabIndex = 26;
            header.Title = "Dashboard";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(950, 577);
            Controls.Add(header);
            Controls.Add(contentPlace);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel contentPlace;
        private SideMenu sideMenu;
        private Header header;
        private TreeView treeView;
    }
}