namespace Plugin_Tasks
{
    partial class TasksPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveTask = new System.Windows.Forms.Button();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.lblNotificationMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(583, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Location = new System.Drawing.Point(520, 9);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTask.TabIndex = 1;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(502, 20);
            this.txtTaskTitle.TabIndex = 2;
            // 
            // pnlNotification
            // 
            this.pnlNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlNotification.Controls.Add(this.lblNotificationMessage);
            this.pnlNotification.Location = new System.Drawing.Point(12, 35);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(583, 33);
            this.pnlNotification.TabIndex = 3;
            this.pnlNotification.Visible = false;
            // 
            // lblNotificationMessage
            // 
            this.lblNotificationMessage.AutoSize = true;
            this.lblNotificationMessage.Location = new System.Drawing.Point(3, 7);
            this.lblNotificationMessage.Name = "lblNotificationMessage";
            this.lblNotificationMessage.Size = new System.Drawing.Size(35, 13);
            this.lblNotificationMessage.TabIndex = 0;
            this.lblNotificationMessage.Text = "label1";
            // 
            // TasksPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 355);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.btnSaveTask);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TasksPanel";
            this.Text = "TasksPanel";
            this.Load += new System.EventHandler(this.TasksPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveTask;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Label lblNotificationMessage;
    }
}