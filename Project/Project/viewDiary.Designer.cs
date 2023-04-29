
namespace Project
{
    partial class viewDiary
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
            this.PagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.detaile = new System.Windows.Forms.Label();
            this.hedline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastModDate = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PagesPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagesPanel
            // 
            this.PagesPanel.AutoScroll = true;
            this.PagesPanel.Controls.Add(this.detaile);
            this.PagesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PagesPanel.Location = new System.Drawing.Point(10, 167);
            this.PagesPanel.Name = "PagesPanel";
            this.PagesPanel.Padding = new System.Windows.Forms.Padding(20);
            this.PagesPanel.Size = new System.Drawing.Size(1393, 538);
            this.PagesPanel.TabIndex = 21;
            this.PagesPanel.WrapContents = false;
            // 
            // detaile
            // 
            this.detaile.AutoSize = true;
            this.detaile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detaile.Location = new System.Drawing.Point(23, 20);
            this.detaile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 40);
            this.detaile.Name = "detaile";
            this.detaile.Size = new System.Drawing.Size(1180, 58);
            this.detaile.TabIndex = 14;
            this.detaile.Text = "[Grab your reader’s attention with a great quote from the document or use this sp" +
    "ace to emphasize a key point.\r\nTo place this text box anywhere on the page, just" +
    " drag it.]";
            // 
            // hedline
            // 
            this.hedline.AutoSize = true;
            this.hedline.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hedline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.hedline.Location = new System.Drawing.Point(278, 25);
            this.hedline.Name = "hedline";
            this.hedline.Size = new System.Drawing.Size(186, 43);
            this.hedline.TabIndex = 19;
            this.hedline.Text = "Headline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.AddDate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(276, 87);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 34);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // AddDate
            // 
            this.AddDate.AutoSize = true;
            this.AddDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.AddDate.Location = new System.Drawing.Point(102, 0);
            this.AddDate.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(100, 23);
            this.AddDate.TabIndex = 23;
            this.AddDate.Text = "addDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Modified:";
            // 
            // LastModDate
            // 
            this.LastModDate.AutoSize = true;
            this.LastModDate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastModDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.LastModDate.Location = new System.Drawing.Point(134, 0);
            this.LastModDate.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.LastModDate.Name = "LastModDate";
            this.LastModDate.Size = new System.Drawing.Size(104, 23);
            this.LastModDate.TabIndex = 27;
            this.LastModDate.Text = "lasttMod";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.LastModDate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(276, 124);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1054, 34);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 2);
            this.panel1.TabIndex = 15;
            // 
            // viewDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PagesPanel);
            this.Controls.Add(this.hedline);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "viewDiary";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1413, 715);
            this.Load += new System.EventHandler(this.viewDiary_Load);
            this.PagesPanel.ResumeLayout(false);
            this.PagesPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PagesPanel;
        private System.Windows.Forms.Label hedline;
        private System.Windows.Forms.Label detaile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label AddDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LastModDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}
