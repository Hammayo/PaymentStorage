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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tsbLabelLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbLabelRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rbSortByAmount = new System.Windows.Forms.RadioButton();
            this.rbSortByDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTxDestinationAccountNo = new System.Windows.Forms.TextBox();
            this.lblTxDestinationAccountNo = new System.Windows.Forms.Label();
            this.txtTxSourceAccountNo = new System.Windows.Forms.TextBox();
            this.lblTxSourceAccountNo = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTxDate = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblTxCurrency = new System.Windows.Forms.Label();
            this.txtTxAmount = new System.Windows.Forms.TextBox();
            this.lblTxAmount = new System.Windows.Forms.Label();
            this.txtTxRef = new System.Windows.Forms.TextBox();
            this.lblTxRef = new System.Windows.Forms.Label();
            this.sbCapture = new System.Windows.Forms.StatusStrip();
            this.sbTxCapturedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbTxProcessedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.paymentGridView = new System.Windows.Forms.DataGridView();
            this.paymentViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sbCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewModelBindingSource)).BeginInit();
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
            this.tsbLabelLeft,
            this.tsbLabelRight});
            this.statusBar.Location = new System.Drawing.Point(0, 372);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(847, 22);
            this.statusBar.TabIndex = 1;
            // 
            // tsbLabelLeft
            // 
            this.tsbLabelLeft.Name = "tsbLabelLeft";
            this.tsbLabelLeft.Size = new System.Drawing.Size(714, 17);
            this.tsbLabelLeft.Spring = true;
            this.tsbLabelLeft.Text = "Payment Storage demo by Hammy Babar v-0.1";
            this.tsbLabelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbLabelRight
            // 
            this.tsbLabelRight.Name = "tsbLabelRight";
            this.tsbLabelRight.Size = new System.Drawing.Size(118, 17);
            this.tsbLabelRight.Text = "FS Agent: User Name";
            // 
            // menuBar
            // 
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(847, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuStrip1";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer.Panel1.Controls.Add(this.sbCapture);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.paymentGridView);
            this.splitContainer.Size = new System.Drawing.Size(847, 348);
            this.splitContainer.SplitterDistance = 173;
            this.splitContainer.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.rbSortByAmount);
            this.groupBox2.Controls.Add(this.rbSortByDate);
            this.groupBox2.Location = new System.Drawing.Point(484, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Payment:";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(6, 46);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(233, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process All Payments";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rbSortByAmount
            // 
            this.rbSortByAmount.AutoSize = true;
            this.rbSortByAmount.Location = new System.Drawing.Point(119, 17);
            this.rbSortByAmount.Name = "rbSortByAmount";
            this.rbSortByAmount.Size = new System.Drawing.Size(120, 17);
            this.rbSortByAmount.TabIndex = 1;
            this.rbSortByAmount.TabStop = true;
            this.rbSortByAmount.Text = "By Payment Amount";
            this.rbSortByAmount.UseVisualStyleBackColor = true;
            // 
            // rbSortByDate
            // 
            this.rbSortByDate.AutoSize = true;
            this.rbSortByDate.Location = new System.Drawing.Point(6, 17);
            this.rbSortByDate.Name = "rbSortByDate";
            this.rbSortByDate.Size = new System.Drawing.Size(107, 17);
            this.rbSortByDate.TabIndex = 0;
            this.rbSortByDate.TabStop = true;
            this.rbSortByDate.Text = "By Payment Date";
            this.rbSortByDate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTxDestinationAccountNo);
            this.groupBox1.Controls.Add(this.lblTxDestinationAccountNo);
            this.groupBox1.Controls.Add(this.txtTxSourceAccountNo);
            this.groupBox1.Controls.Add(this.lblTxSourceAccountNo);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.lblTxDate);
            this.groupBox1.Controls.Add(this.cmbCurrency);
            this.groupBox1.Controls.Add(this.lblTxCurrency);
            this.groupBox1.Controls.Add(this.txtTxAmount);
            this.groupBox1.Controls.Add(this.lblTxAmount);
            this.groupBox1.Controls.Add(this.txtTxRef);
            this.groupBox1.Controls.Add(this.lblTxRef);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 135);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capture Payment: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Payment Details";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTxDestinationAccountNo
            // 
            this.txtTxDestinationAccountNo.Location = new System.Drawing.Point(340, 49);
            this.txtTxDestinationAccountNo.Name = "txtTxDestinationAccountNo";
            this.txtTxDestinationAccountNo.Size = new System.Drawing.Size(113, 20);
            this.txtTxDestinationAccountNo.TabIndex = 9;
            // 
            // lblTxDestinationAccountNo
            // 
            this.lblTxDestinationAccountNo.AutoSize = true;
            this.lblTxDestinationAccountNo.Location = new System.Drawing.Point(217, 52);
            this.lblTxDestinationAccountNo.Name = "lblTxDestinationAccountNo";
            this.lblTxDestinationAccountNo.Size = new System.Drawing.Size(123, 13);
            this.lblTxDestinationAccountNo.TabIndex = 10;
            this.lblTxDestinationAccountNo.Text = "Destination Account No:";
            // 
            // txtTxSourceAccountNo
            // 
            this.txtTxSourceAccountNo.Location = new System.Drawing.Point(340, 16);
            this.txtTxSourceAccountNo.Name = "txtTxSourceAccountNo";
            this.txtTxSourceAccountNo.Size = new System.Drawing.Size(113, 20);
            this.txtTxSourceAccountNo.TabIndex = 7;
            // 
            // lblTxSourceAccountNo
            // 
            this.lblTxSourceAccountNo.AutoSize = true;
            this.lblTxSourceAccountNo.Location = new System.Drawing.Point(217, 19);
            this.lblTxSourceAccountNo.Name = "lblTxSourceAccountNo";
            this.lblTxSourceAccountNo.Size = new System.Drawing.Size(104, 13);
            this.lblTxSourceAccountNo.TabIndex = 8;
            this.lblTxSourceAccountNo.Text = "Source Account No:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(340, 78);
            this.dateTimePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // lblTxDate
            // 
            this.lblTxDate.AutoSize = true;
            this.lblTxDate.Location = new System.Drawing.Point(217, 84);
            this.lblTxDate.Name = "lblTxDate";
            this.lblTxDate.Size = new System.Drawing.Size(77, 13);
            this.lblTxDate.TabIndex = 6;
            this.lblTxDate.Text = "Payment Date:";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "GBP",
            "EUR",
            "USD"});
            this.cmbCurrency.Location = new System.Drawing.Point(95, 81);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(107, 21);
            this.cmbCurrency.TabIndex = 5;
            // 
            // lblTxCurrency
            // 
            this.lblTxCurrency.AutoSize = true;
            this.lblTxCurrency.Location = new System.Drawing.Point(6, 84);
            this.lblTxCurrency.Name = "lblTxCurrency";
            this.lblTxCurrency.Size = new System.Drawing.Size(52, 13);
            this.lblTxCurrency.TabIndex = 4;
            this.lblTxCurrency.Text = "Currency:";
            // 
            // txtTxAmount
            // 
            this.txtTxAmount.Location = new System.Drawing.Point(95, 49);
            this.txtTxAmount.Name = "txtTxAmount";
            this.txtTxAmount.Size = new System.Drawing.Size(107, 20);
            this.txtTxAmount.TabIndex = 3;
            // 
            // lblTxAmount
            // 
            this.lblTxAmount.AutoSize = true;
            this.lblTxAmount.Location = new System.Drawing.Point(6, 52);
            this.lblTxAmount.Name = "lblTxAmount";
            this.lblTxAmount.Size = new System.Drawing.Size(90, 13);
            this.lblTxAmount.TabIndex = 2;
            this.lblTxAmount.Text = "Payment Amount:";
            // 
            // txtTxRef
            // 
            this.txtTxRef.Location = new System.Drawing.Point(95, 16);
            this.txtTxRef.Name = "txtTxRef";
            this.txtTxRef.Size = new System.Drawing.Size(107, 20);
            this.txtTxRef.TabIndex = 1;
            // 
            // lblTxRef
            // 
            this.lblTxRef.AutoSize = true;
            this.lblTxRef.Location = new System.Drawing.Point(3, 19);
            this.lblTxRef.Name = "lblTxRef";
            this.lblTxRef.Size = new System.Drawing.Size(86, 13);
            this.lblTxRef.TabIndex = 0;
            this.lblTxRef.Text = "Transaction Ref:";
            // 
            // sbCapture
            // 
            this.sbCapture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbTxCapturedLabel,
            this.sbTxProcessedLabel});
            this.sbCapture.Location = new System.Drawing.Point(0, 151);
            this.sbCapture.Name = "sbCapture";
            this.sbCapture.Size = new System.Drawing.Size(847, 22);
            this.sbCapture.TabIndex = 0;
            // 
            // sbTxCapturedLabel
            // 
            this.sbTxCapturedLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbTxCapturedLabel.ForeColor = System.Drawing.Color.Green;
            this.sbTxCapturedLabel.Name = "sbTxCapturedLabel";
            this.sbTxCapturedLabel.Size = new System.Drawing.Size(816, 17);
            this.sbTxCapturedLabel.Spring = true;
            this.sbTxCapturedLabel.Text = "Payments: 0";
            this.sbTxCapturedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbTxProcessedLabel
            // 
            this.sbTxProcessedLabel.ForeColor = System.Drawing.Color.Indigo;
            this.sbTxProcessedLabel.Name = "sbTxProcessedLabel";
            this.sbTxProcessedLabel.Size = new System.Drawing.Size(16, 17);
            this.sbTxProcessedLabel.Text = "...";
            // 
            // paymentGridView
            // 
            this.paymentGridView.AllowUserToAddRows = false;
            this.paymentGridView.AllowUserToDeleteRows = false;
            this.paymentGridView.AllowUserToOrderColumns = true;
            this.paymentGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            this.paymentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.paymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentGridView.Location = new System.Drawing.Point(0, 0);
            this.paymentGridView.Name = "paymentGridView";
            this.paymentGridView.ReadOnly = true;
            this.paymentGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.paymentGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.paymentGridView.Size = new System.Drawing.Size(847, 171);
            this.paymentGridView.TabIndex = 0;
            // 
            // paymentViewModelBindingSource
            // 
            this.paymentViewModelBindingSource.DataSource = typeof(PaymentStorage.UI.ViewModel.PaymentViewModel);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 394);
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
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sbCapture.ResumeLayout(false);
            this.sbCapture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentViewModelBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel sbTxCapturedLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsbLabelRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTxRef;
        private System.Windows.Forms.Label lblTxRef;
        private System.Windows.Forms.BindingSource paymentViewModelBindingSource;
        private System.Windows.Forms.Label lblTxDate;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblTxCurrency;
        private System.Windows.Forms.TextBox txtTxAmount;
        private System.Windows.Forms.Label lblTxAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTxDestinationAccountNo;
        private System.Windows.Forms.Label lblTxDestinationAccountNo;
        private System.Windows.Forms.TextBox txtTxSourceAccountNo;
        private System.Windows.Forms.Label lblTxSourceAccountNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rbSortByAmount;
        private System.Windows.Forms.RadioButton rbSortByDate;
        private System.Windows.Forms.ToolStripStatusLabel sbTxProcessedLabel;
    }
}

