
namespace Project
{
    partial class MyComplaints
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
            this.compPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compPanel
            // 
            this.compPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compPanel.AutoScroll = true;
            this.compPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.compPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.compPanel.Location = new System.Drawing.Point(0, 95);
            this.compPanel.Name = "compPanel";
            this.compPanel.Size = new System.Drawing.Size(1413, 608);
            this.compPanel.TabIndex = 21;
            this.compPanel.WrapContents = false;
            this.compPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PagesPanel_Paint);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(1159, 19);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 59);
            this.button4.TabIndex = 20;
            this.button4.Text = "Add Complaint";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label14.Location = new System.Drawing.Point(242, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(293, 43);
            this.label14.TabIndex = 19;
            this.label14.Text = "All Complaints";
            // 
            // MyComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.compPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label14);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MyComplaints";
            this.Size = new System.Drawing.Size(1416, 715);
            this.Load += new System.EventHandler(this.MyComplaints_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel compPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
    }
}
