using System.Windows.Forms;

namespace CookingWizard.Controls
{
    partial class MealSelector
    {

        public ComboBox MealSelectorCb
        {
            get { return mealSelectorCb; }
            set { mealSelectorCb = value; }
        }
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
            this.mealSelectorCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mealSelectorCb
            // 
            this.mealSelectorCb.Dock = System.Windows.Forms.DockStyle.Left;
            this.mealSelectorCb.FormattingEnabled = true;
            this.mealSelectorCb.Location = new System.Drawing.Point(0, 0);
            this.mealSelectorCb.Name = "mealSelectorCb";
            this.mealSelectorCb.Size = new System.Drawing.Size(121, 21);
            this.mealSelectorCb.TabIndex = 0;
            // MealSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mealSelectorCb);
            this.Name = "MealSelector";
            this.Size = new System.Drawing.Size(121, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox mealSelectorCb;
    }
}
