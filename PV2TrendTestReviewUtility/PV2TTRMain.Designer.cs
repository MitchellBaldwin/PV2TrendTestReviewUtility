namespace PV2TrendTestReviewUtility
{
    partial class PV2TTRMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Proximal Pressure",
            "15.00",
            "18.00",
            "21.00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.OpenTrendTestFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ttrLlistView = new System.Windows.Forms.ListView();
            this.measuredParameterColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lowLimitColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.highLimitColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.averageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maximumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitsColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // OpenTrendTestFileDialog
            // 
            this.OpenTrendTestFileDialog.DefaultExt = "ttr";
            this.OpenTrendTestFileDialog.Filter = "Trend Test fules|*.ttr|All files|*.*";
            // 
            // ttrLlistView
            // 
            this.ttrLlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.measuredParameterColumnHeader,
            this.lowLimitColumnHeader,
            this.targetColumnHeader,
            this.highLimitColumnHeader,
            this.minimumColumnHeader,
            this.averageColumnHeader,
            this.maximumColumnHeader,
            this.unitsColumnHeader,
            this.minTimeColumnHeader,
            this.maxTimeColumnHeader});
            this.ttrLlistView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ttrLlistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttrLlistView.FullRowSelect = true;
            this.ttrLlistView.GridLines = true;
            this.ttrLlistView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.IndentCount = 1;
            this.ttrLlistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ttrLlistView.Location = new System.Drawing.Point(0, 0);
            this.ttrLlistView.Name = "ttrLlistView";
            this.ttrLlistView.Size = new System.Drawing.Size(2052, 704);
            this.ttrLlistView.TabIndex = 0;
            this.ttrLlistView.UseCompatibleStateImageBehavior = false;
            this.ttrLlistView.View = System.Windows.Forms.View.Details;
            // 
            // measuredParameterColumnHeader
            // 
            this.measuredParameterColumnHeader.Text = "Measured Parameter";
            this.measuredParameterColumnHeader.Width = 300;
            // 
            // lowLimitColumnHeader
            // 
            this.lowLimitColumnHeader.Text = "Low Limit";
            this.lowLimitColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowLimitColumnHeader.Width = 120;
            // 
            // targetColumnHeader
            // 
            this.targetColumnHeader.Text = "Target";
            this.targetColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.targetColumnHeader.Width = 120;
            // 
            // highLimitColumnHeader
            // 
            this.highLimitColumnHeader.Text = "High Limit";
            this.highLimitColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.highLimitColumnHeader.Width = 120;
            // 
            // minimumColumnHeader
            // 
            this.minimumColumnHeader.Text = "Minimum";
            this.minimumColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minimumColumnHeader.Width = 120;
            // 
            // averageColumnHeader
            // 
            this.averageColumnHeader.Text = "Average";
            this.averageColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.averageColumnHeader.Width = 120;
            // 
            // maximumColumnHeader
            // 
            this.maximumColumnHeader.Text = "Maximum";
            this.maximumColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maximumColumnHeader.Width = 120;
            // 
            // unitsColumnHeader
            // 
            this.unitsColumnHeader.Text = "Units";
            this.unitsColumnHeader.Width = 120;
            // 
            // minTimeColumnHeader
            // 
            this.minTimeColumnHeader.Text = "Min Time";
            this.minTimeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minTimeColumnHeader.Width = 120;
            // 
            // maxTimeColumnHeader
            // 
            this.maxTimeColumnHeader.Text = "Max Time";
            this.maxTimeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTimeColumnHeader.Width = 120;
            // 
            // PV2TTRMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2052, 904);
            this.Controls.Add(this.ttrLlistView);
            this.Name = "PV2TTRMain";
            this.Text = "PneuView® 2.0 Trend Test Review";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenTrendTestFileDialog;
        private System.Windows.Forms.ListView ttrLlistView;
        private System.Windows.Forms.ColumnHeader measuredParameterColumnHeader;
        private System.Windows.Forms.ColumnHeader lowLimitColumnHeader;
        private System.Windows.Forms.ColumnHeader targetColumnHeader;
        private System.Windows.Forms.ColumnHeader highLimitColumnHeader;
        private System.Windows.Forms.ColumnHeader minimumColumnHeader;
        private System.Windows.Forms.ColumnHeader averageColumnHeader;
        private System.Windows.Forms.ColumnHeader maximumColumnHeader;
        private System.Windows.Forms.ColumnHeader unitsColumnHeader;
        private System.Windows.Forms.ColumnHeader minTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader maxTimeColumnHeader;
    }
}

