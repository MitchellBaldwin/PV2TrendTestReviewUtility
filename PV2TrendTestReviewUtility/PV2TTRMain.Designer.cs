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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PV2TTRMain));
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
            this.lttrfButton = new System.Windows.Forms.Button();
            this.testFileDisplayLabel = new System.Windows.Forms.Label();
            this.testNameDisplayLabel = new System.Windows.Forms.Label();
            this.testDateDisplayLabel = new System.Windows.Forms.Label();
            this.serialNumberLabel = new System.Windows.Forms.Label();
            this.serialNumberDisplayLabel = new System.Windows.Forms.Label();
            this.complianceDisplayLabel = new System.Windows.Forms.Label();
            this.complianceLabel = new System.Windows.Forms.Label();
            this.resistanceDisplayLabel = new System.Windows.Forms.Label();
            this.resistanceLabel = new System.Windows.Forms.Label();
            this.gasTemperatureDisplayLabel = new System.Windows.Forms.Label();
            this.gasTemperatureLabel = new System.Windows.Forms.Label();
            this.barometricPressureDisplayLabel = new System.Windows.Forms.Label();
            this.barometricPressureLabel = new System.Windows.Forms.Label();
            this.complianceUnitsLabel = new System.Windows.Forms.Label();
            this.gasTemperatureUnitsLabel = new System.Windows.Forms.Label();
            this.barometricBressureUnitsLabel = new System.Windows.Forms.Label();
            this.sampleIntervalUnitsLabel = new System.Windows.Forms.Label();
            this.testLengthUnitsLabel = new System.Windows.Forms.Label();
            this.totalSamplesDisplayLabel = new System.Windows.Forms.Label();
            this.totalSamplesLabel = new System.Windows.Forms.Label();
            this.sampleIntervalDisplayLabel = new System.Windows.Forms.Label();
            this.sampleIntervalLabel = new System.Windows.Forms.Label();
            this.testLengthDisplayLabel = new System.Windows.Forms.Label();
            this.testLengthLabel = new System.Windows.Forms.Label();
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
            this.ttrLlistView.Location = new System.Drawing.Point(0, 0);
            this.ttrLlistView.Name = "ttrLlistView";
            this.ttrLlistView.Size = new System.Drawing.Size(1695, 704);
            this.ttrLlistView.TabIndex = 0;
            this.ttrLlistView.UseCompatibleStateImageBehavior = false;
            this.ttrLlistView.View = System.Windows.Forms.View.Details;
            // 
            // measuredParameterColumnHeader
            // 
            this.measuredParameterColumnHeader.Text = "Measured Parameter";
            this.measuredParameterColumnHeader.Width = 200;
            // 
            // lowLimitColumnHeader
            // 
            this.lowLimitColumnHeader.Text = "Low Limit";
            this.lowLimitColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lowLimitColumnHeader.Width = 80;
            // 
            // targetColumnHeader
            // 
            this.targetColumnHeader.Text = "Target";
            this.targetColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.targetColumnHeader.Width = 80;
            // 
            // highLimitColumnHeader
            // 
            this.highLimitColumnHeader.Text = "High Limit";
            this.highLimitColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.highLimitColumnHeader.Width = 80;
            // 
            // minimumColumnHeader
            // 
            this.minimumColumnHeader.Text = "Minimum";
            this.minimumColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minimumColumnHeader.Width = 80;
            // 
            // averageColumnHeader
            // 
            this.averageColumnHeader.Text = "Average";
            this.averageColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.averageColumnHeader.Width = 80;
            // 
            // maximumColumnHeader
            // 
            this.maximumColumnHeader.Text = "Maximum";
            this.maximumColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maximumColumnHeader.Width = 80;
            // 
            // unitsColumnHeader
            // 
            this.unitsColumnHeader.Text = "Units";
            this.unitsColumnHeader.Width = 80;
            // 
            // minTimeColumnHeader
            // 
            this.minTimeColumnHeader.Text = "Min Time";
            this.minTimeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minTimeColumnHeader.Width = 80;
            // 
            // maxTimeColumnHeader
            // 
            this.maxTimeColumnHeader.Text = "Max Time";
            this.maxTimeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTimeColumnHeader.Width = 80;
            // 
            // lttrfButton
            // 
            this.lttrfButton.Location = new System.Drawing.Point(12, 836);
            this.lttrfButton.Name = "lttrfButton";
            this.lttrfButton.Size = new System.Drawing.Size(366, 56);
            this.lttrfButton.TabIndex = 1;
            this.lttrfButton.Text = "Load Trend Test Results  File";
            this.lttrfButton.UseVisualStyleBackColor = true;
            this.lttrfButton.Click += new System.EventHandler(this.lttrfButton_Click);
            // 
            // testFileDisplayLabel
            // 
            this.testFileDisplayLabel.Location = new System.Drawing.Point(10, 717);
            this.testFileDisplayLabel.Name = "testFileDisplayLabel";
            this.testFileDisplayLabel.Size = new System.Drawing.Size(587, 33);
            this.testFileDisplayLabel.TabIndex = 2;
            this.testFileDisplayLabel.Text = "Reviewing: ";
            // 
            // testNameDisplayLabel
            // 
            this.testNameDisplayLabel.Location = new System.Drawing.Point(10, 751);
            this.testNameDisplayLabel.Name = "testNameDisplayLabel";
            this.testNameDisplayLabel.Size = new System.Drawing.Size(587, 25);
            this.testNameDisplayLabel.TabIndex = 3;
            this.testNameDisplayLabel.Text = "Test name: ";
            // 
            // testDateDisplayLabel
            // 
            this.testDateDisplayLabel.Location = new System.Drawing.Point(10, 785);
            this.testDateDisplayLabel.Name = "testDateDisplayLabel";
            this.testDateDisplayLabel.Size = new System.Drawing.Size(587, 25);
            this.testDateDisplayLabel.TabIndex = 4;
            this.testDateDisplayLabel.Text = "Test date: ";
            // 
            // serialNumberLabel
            // 
            this.serialNumberLabel.Location = new System.Drawing.Point(615, 717);
            this.serialNumberLabel.Name = "serialNumberLabel";
            this.serialNumberLabel.Size = new System.Drawing.Size(228, 23);
            this.serialNumberLabel.TabIndex = 5;
            this.serialNumberLabel.Text = "Serial Number:";
            // 
            // serialNumberDisplayLabel
            // 
            this.serialNumberDisplayLabel.Location = new System.Drawing.Point(864, 717);
            this.serialNumberDisplayLabel.Name = "serialNumberDisplayLabel";
            this.serialNumberDisplayLabel.Size = new System.Drawing.Size(136, 23);
            this.serialNumberDisplayLabel.TabIndex = 6;
            this.serialNumberDisplayLabel.Text = "SL00000";
            this.serialNumberDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // complianceDisplayLabel
            // 
            this.complianceDisplayLabel.Location = new System.Drawing.Point(864, 747);
            this.complianceDisplayLabel.Name = "complianceDisplayLabel";
            this.complianceDisplayLabel.Size = new System.Drawing.Size(136, 23);
            this.complianceDisplayLabel.TabIndex = 8;
            this.complianceDisplayLabel.Text = "0.05";
            this.complianceDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // complianceLabel
            // 
            this.complianceLabel.Location = new System.Drawing.Point(615, 747);
            this.complianceLabel.Name = "complianceLabel";
            this.complianceLabel.Size = new System.Drawing.Size(228, 23);
            this.complianceLabel.TabIndex = 7;
            this.complianceLabel.Text = "Compliance:";
            // 
            // resistanceDisplayLabel
            // 
            this.resistanceDisplayLabel.Location = new System.Drawing.Point(864, 777);
            this.resistanceDisplayLabel.Name = "resistanceDisplayLabel";
            this.resistanceDisplayLabel.Size = new System.Drawing.Size(136, 23);
            this.resistanceDisplayLabel.TabIndex = 10;
            this.resistanceDisplayLabel.Text = "5";
            this.resistanceDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resistanceLabel
            // 
            this.resistanceLabel.Location = new System.Drawing.Point(615, 777);
            this.resistanceLabel.Name = "resistanceLabel";
            this.resistanceLabel.Size = new System.Drawing.Size(228, 23);
            this.resistanceLabel.TabIndex = 9;
            this.resistanceLabel.Text = "Resistance:";
            // 
            // gasTemperatureDisplayLabel
            // 
            this.gasTemperatureDisplayLabel.Location = new System.Drawing.Point(864, 807);
            this.gasTemperatureDisplayLabel.Name = "gasTemperatureDisplayLabel";
            this.gasTemperatureDisplayLabel.Size = new System.Drawing.Size(136, 23);
            this.gasTemperatureDisplayLabel.TabIndex = 12;
            this.gasTemperatureDisplayLabel.Text = "20";
            this.gasTemperatureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gasTemperatureLabel
            // 
            this.gasTemperatureLabel.Location = new System.Drawing.Point(615, 807);
            this.gasTemperatureLabel.Name = "gasTemperatureLabel";
            this.gasTemperatureLabel.Size = new System.Drawing.Size(228, 23);
            this.gasTemperatureLabel.TabIndex = 11;
            this.gasTemperatureLabel.Text = "Gas Temperature:";
            // 
            // barometricPressureDisplayLabel
            // 
            this.barometricPressureDisplayLabel.Location = new System.Drawing.Point(864, 837);
            this.barometricPressureDisplayLabel.Name = "barometricPressureDisplayLabel";
            this.barometricPressureDisplayLabel.Size = new System.Drawing.Size(136, 23);
            this.barometricPressureDisplayLabel.TabIndex = 14;
            this.barometricPressureDisplayLabel.Text = "760";
            this.barometricPressureDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // barometricPressureLabel
            // 
            this.barometricPressureLabel.Location = new System.Drawing.Point(615, 837);
            this.barometricPressureLabel.Name = "barometricPressureLabel";
            this.barometricPressureLabel.Size = new System.Drawing.Size(228, 23);
            this.barometricPressureLabel.TabIndex = 13;
            this.barometricPressureLabel.Text = "Barometric Pressure:";
            // 
            // complianceUnitsLabel
            // 
            this.complianceUnitsLabel.Location = new System.Drawing.Point(1006, 747);
            this.complianceUnitsLabel.Name = "complianceUnitsLabel";
            this.complianceUnitsLabel.Size = new System.Drawing.Size(132, 23);
            this.complianceUnitsLabel.TabIndex = 15;
            this.complianceUnitsLabel.Text = "L/cmH2O";
            // 
            // gasTemperatureUnitsLabel
            // 
            this.gasTemperatureUnitsLabel.Location = new System.Drawing.Point(1006, 807);
            this.gasTemperatureUnitsLabel.Name = "gasTemperatureUnitsLabel";
            this.gasTemperatureUnitsLabel.Size = new System.Drawing.Size(132, 23);
            this.gasTemperatureUnitsLabel.TabIndex = 16;
            this.gasTemperatureUnitsLabel.Text = "°C";
            // 
            // barometricBressureUnitsLabel
            // 
            this.barometricBressureUnitsLabel.Location = new System.Drawing.Point(1006, 837);
            this.barometricBressureUnitsLabel.Name = "barometricBressureUnitsLabel";
            this.barometricBressureUnitsLabel.Size = new System.Drawing.Size(132, 23);
            this.barometricBressureUnitsLabel.TabIndex = 17;
            this.barometricBressureUnitsLabel.Text = "mmHg";
            // 
            // sampleIntervalUnitsLabel
            // 
            this.sampleIntervalUnitsLabel.Location = new System.Drawing.Point(1490, 781);
            this.sampleIntervalUnitsLabel.Name = "sampleIntervalUnitsLabel";
            this.sampleIntervalUnitsLabel.Size = new System.Drawing.Size(132, 23);
            this.sampleIntervalUnitsLabel.TabIndex = 25;
            this.sampleIntervalUnitsLabel.Text = "hh:mm:ss";
            // 
            // testLengthUnitsLabel
            // 
            this.testLengthUnitsLabel.Location = new System.Drawing.Point(1490, 753);
            this.testLengthUnitsLabel.Name = "testLengthUnitsLabel";
            this.testLengthUnitsLabel.Size = new System.Drawing.Size(132, 23);
            this.testLengthUnitsLabel.TabIndex = 24;
            this.testLengthUnitsLabel.Text = "hh:mm:ss";
            // 
            // totalSamplesDisplayLabel
            // 
            this.totalSamplesDisplayLabel.Location = new System.Drawing.Point(1378, 811);
            this.totalSamplesDisplayLabel.Name = "totalSamplesDisplayLabel";
            this.totalSamplesDisplayLabel.Size = new System.Drawing.Size(106, 23);
            this.totalSamplesDisplayLabel.TabIndex = 23;
            this.totalSamplesDisplayLabel.Text = "20";
            this.totalSamplesDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalSamplesLabel
            // 
            this.totalSamplesLabel.Location = new System.Drawing.Point(1184, 811);
            this.totalSamplesLabel.Name = "totalSamplesLabel";
            this.totalSamplesLabel.Size = new System.Drawing.Size(188, 23);
            this.totalSamplesLabel.TabIndex = 22;
            this.totalSamplesLabel.Text = "Total Samples:";
            // 
            // sampleIntervalDisplayLabel
            // 
            this.sampleIntervalDisplayLabel.Location = new System.Drawing.Point(1378, 781);
            this.sampleIntervalDisplayLabel.Name = "sampleIntervalDisplayLabel";
            this.sampleIntervalDisplayLabel.Size = new System.Drawing.Size(106, 23);
            this.sampleIntervalDisplayLabel.TabIndex = 21;
            this.sampleIntervalDisplayLabel.Text = "hh:mm:ss";
            this.sampleIntervalDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sampleIntervalLabel
            // 
            this.sampleIntervalLabel.Location = new System.Drawing.Point(1184, 781);
            this.sampleIntervalLabel.Name = "sampleIntervalLabel";
            this.sampleIntervalLabel.Size = new System.Drawing.Size(188, 23);
            this.sampleIntervalLabel.TabIndex = 20;
            this.sampleIntervalLabel.Text = "Sample Interval:";
            // 
            // testLengthDisplayLabel
            // 
            this.testLengthDisplayLabel.Location = new System.Drawing.Point(1378, 751);
            this.testLengthDisplayLabel.Name = "testLengthDisplayLabel";
            this.testLengthDisplayLabel.Size = new System.Drawing.Size(106, 23);
            this.testLengthDisplayLabel.TabIndex = 19;
            this.testLengthDisplayLabel.Text = "hh:mm:ss";
            this.testLengthDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // testLengthLabel
            // 
            this.testLengthLabel.Location = new System.Drawing.Point(1184, 751);
            this.testLengthLabel.Name = "testLengthLabel";
            this.testLengthLabel.Size = new System.Drawing.Size(188, 23);
            this.testLengthLabel.TabIndex = 18;
            this.testLengthLabel.Text = "Test Length:";
            // 
            // PV2TTRMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1695, 904);
            this.Controls.Add(this.sampleIntervalUnitsLabel);
            this.Controls.Add(this.testLengthUnitsLabel);
            this.Controls.Add(this.totalSamplesDisplayLabel);
            this.Controls.Add(this.totalSamplesLabel);
            this.Controls.Add(this.sampleIntervalDisplayLabel);
            this.Controls.Add(this.sampleIntervalLabel);
            this.Controls.Add(this.testLengthDisplayLabel);
            this.Controls.Add(this.testLengthLabel);
            this.Controls.Add(this.barometricBressureUnitsLabel);
            this.Controls.Add(this.gasTemperatureUnitsLabel);
            this.Controls.Add(this.complianceUnitsLabel);
            this.Controls.Add(this.barometricPressureDisplayLabel);
            this.Controls.Add(this.barometricPressureLabel);
            this.Controls.Add(this.gasTemperatureDisplayLabel);
            this.Controls.Add(this.gasTemperatureLabel);
            this.Controls.Add(this.resistanceDisplayLabel);
            this.Controls.Add(this.resistanceLabel);
            this.Controls.Add(this.complianceDisplayLabel);
            this.Controls.Add(this.complianceLabel);
            this.Controls.Add(this.serialNumberDisplayLabel);
            this.Controls.Add(this.serialNumberLabel);
            this.Controls.Add(this.testDateDisplayLabel);
            this.Controls.Add(this.testNameDisplayLabel);
            this.Controls.Add(this.testFileDisplayLabel);
            this.Controls.Add(this.lttrfButton);
            this.Controls.Add(this.ttrLlistView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button lttrfButton;
        private System.Windows.Forms.Label testFileDisplayLabel;
        private System.Windows.Forms.Label testNameDisplayLabel;
        private System.Windows.Forms.Label testDateDisplayLabel;
        private System.Windows.Forms.Label serialNumberLabel;
        private System.Windows.Forms.Label serialNumberDisplayLabel;
        private System.Windows.Forms.Label complianceDisplayLabel;
        private System.Windows.Forms.Label complianceLabel;
        private System.Windows.Forms.Label resistanceDisplayLabel;
        private System.Windows.Forms.Label resistanceLabel;
        private System.Windows.Forms.Label gasTemperatureDisplayLabel;
        private System.Windows.Forms.Label gasTemperatureLabel;
        private System.Windows.Forms.Label barometricPressureDisplayLabel;
        private System.Windows.Forms.Label barometricPressureLabel;
        private System.Windows.Forms.Label complianceUnitsLabel;
        private System.Windows.Forms.Label gasTemperatureUnitsLabel;
        private System.Windows.Forms.Label barometricBressureUnitsLabel;
        private System.Windows.Forms.Label sampleIntervalUnitsLabel;
        private System.Windows.Forms.Label testLengthUnitsLabel;
        private System.Windows.Forms.Label totalSamplesDisplayLabel;
        private System.Windows.Forms.Label totalSamplesLabel;
        private System.Windows.Forms.Label sampleIntervalDisplayLabel;
        private System.Windows.Forms.Label sampleIntervalLabel;
        private System.Windows.Forms.Label testLengthDisplayLabel;
        private System.Windows.Forms.Label testLengthLabel;
    }
}

