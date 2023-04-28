
namespace Project
{
    partial class MyDiaries
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
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.PagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.label14.Location = new System.Drawing.Point(242, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 43);
            this.label14.TabIndex = 16;
            this.label14.Text = "All Diaries";
            this.label14.Click += new System.EventHandler(this.label14_Click);
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
            this.button4.Location = new System.Drawing.Point(1208, 19);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 59);
            this.button4.TabIndex = 17;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PagesPanel
            // 
            this.PagesPanel.AutoScroll = true;
            this.PagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PagesPanel.Location = new System.Drawing.Point(0, 107);
            this.PagesPanel.Name = "PagesPanel";
            this.PagesPanel.Size = new System.Drawing.Size(1413, 608);
            this.PagesPanel.TabIndex = 18;
            this.PagesPanel.WrapContents = false;
            // 
            // MyDiaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PagesPanel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label14);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MyDiaries";
            this.Size = new System.Drawing.Size(1413, 715);
            this.Load += new System.EventHandler(this.MyDiaries_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel PagesPanel;
    }
}
