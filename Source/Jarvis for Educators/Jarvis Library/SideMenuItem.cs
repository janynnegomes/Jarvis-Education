using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis_Library
{
    public class SideMenuItem:Panel
    {

        public string Title { get; set; }
        public string Subtitle { get; set; }
        public Icon Icon { get; set; }

        public SideMenuItem(string title, string subtitle, Icon icon)
        {
            this.Title = title;
            this.Subtitle = subtitle;
            this.Icon = icon;

            BuildInterface();
        }

        private void BuildInterface()
        {
            PictureBox pictureBoxItemIcon = new PictureBox();
            Label lblMenuTitle = new Label();

            this.Controls.Add(pictureBoxItemIcon);
            this.Controls.Add(lblMenuTitle);
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "pnlItemContainer";
            this.Size = new System.Drawing.Size(200, 61);
            this.TabIndex = 7;


            // 
            // pictureBoxItemIcon
            // 
            pictureBoxItemIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBoxItemIcon.Location = new System.Drawing.Point(13, 12);
            pictureBoxItemIcon.Name = "pictureBoxItemIcon";
            pictureBoxItemIcon.Size = new System.Drawing.Size(33, 31);
            pictureBoxItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxItemIcon.TabIndex = 1;
            pictureBoxItemIcon.TabStop = false;
            
            if (this.Icon != null)
            {
                pictureBoxItemIcon.Image = this.Icon.ToBitmap();
            }

            // 
            // lblMenuTitle
            // 
            lblMenuTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            lblMenuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMenuTitle.ForeColor = System.Drawing.Color.White;
            lblMenuTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            lblMenuTitle.Location = new System.Drawing.Point(52, 3);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new System.Drawing.Size(148, 55);
            lblMenuTitle.TabIndex = 2;
            lblMenuTitle.Text = this.Title;
            lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            this.Controls.Add(pictureBoxItemIcon);
            this.Controls.Add(lblMenuTitle);
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
