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
            this.OpenTrendTestFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OpenTrendTestFileDialog
            // 
            this.OpenTrendTestFileDialog.DefaultExt = "ttr";
            this.OpenTrendTestFileDialog.Filter = "Trend Test fules|*.ttr|All files|*.*";
            // 
            // PV2TTRMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2052, 904);
            this.Name = "PV2TTRMain";
            this.Text = "PneuView® 2.0 Trend Test Review";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenTrendTestFileDialog;
    }
}

