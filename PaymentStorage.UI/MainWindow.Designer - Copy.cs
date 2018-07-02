namespace PaymentStorage.UI
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsbLabelLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.paymentGridView = new System.Windows.Forms.DataGridView();
            this.sbCapture = new System.Windows.Forms.StatusStrip();
            this.sbCaptureLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            this.sbCapture.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 128);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLabelLeft});
            this.statusBar.Location = new System.Drawing.Point(0, 348);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(841, 22);
            this.statusBar.TabIndex = 1;
            // 
            // tsbLabelLeft
            // 
            this.tsbLabelLeft.Name = "tsbLabelLeft";
            this.tsbLabelLeft.Size = new System.Drawing.Size(826, 17);
            this.tsbLabelLeft.Spring = true;
            this.tsbLabelLeft.Text = "Created by Hammy Babar v-0.1";
            this.tsbLabelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuBar
            // 
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(841, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.sbCapture);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.paymentGridView);
            this.splitContainer.Size = new System.Drawing.Size(841, 324);
            this.splitContainer.SplitterDistance = 132;
            this.splitContainer.TabIndex = 3;
            // 
            // paymentGridView
            // 
            this.paymentGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.paymentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentGridView.Location = new System.Drawing.Point(0, 0);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.paymentGridView.Size = new System.Drawing.Size(841, 188);
            this.paymentGridView.TabIndex = 0;
            // 
            // sbCapture
            // 
            this.sbCapture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbCaptureLabel});
            this.sbCapture.Location = new System.Drawing.Point(0, 110);
            this.sbCapture.Name = "sbCapture";
            this.sbCapture.Size = new System.Drawing.Size(841, 22);
            this.sbCapture.TabIndex = 0;
            // 
            // sbCaptureLabel
            // 
            this.sbCaptureLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbCaptureLabel.ForeColor = System.Drawing.Color.Green;
            this.sbCaptureLabel.Name = "sbCaptureLabel";
            this.sbCaptureLabel.Size = new System.Drawing.Size(826, 17);
            this.sbCaptureLabel.Spring = true;
            this.sbCaptureLabel.Text = "Payments: 0";
            this.sbCaptureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 370);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Storage";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            this.sbCapture.ResumeLayout(false);
            this.sbCapture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel tsbLabelLeft;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView paymentGridView;
        private System.Windows.Forms.StatusStrip sbCapture;
        private System.Windows.Forms.ToolStripStatusLabel sbCaptureLabel;
    }
}

