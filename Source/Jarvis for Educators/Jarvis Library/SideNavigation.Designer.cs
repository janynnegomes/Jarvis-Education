namespace Jarvis_Library
{
    partial class SideNavigation
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
            this.flowMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowMenuContainer
            // 
            this.flowMenuContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenuContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMenuContainer.Location = new System.Drawing.Point(0, 0);
            this.flowMenuContainer.Name = "flowMenuContainer";
            this.flowMenuContainer.Size = new System.Drawing.Size(208, 246);
            this.flowMenuContainer.TabIndex = 7;
            // 
            // SideNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowMenuContainer);
            this.Name = "SideNavigation";
            this.Size = new System.Drawing.Size(208, 246);
            this.Load += new System.EventHandler(this.SideNavigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMenuContainer;
    }
}
