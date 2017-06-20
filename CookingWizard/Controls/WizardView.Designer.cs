using CookingWizard.Models_;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CookingWizard.Controls
{
    partial class WizardView
    {
        public Label ActionLb
        {
            get { return actionLb; }
            set { actionLb = value; }
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
            this.actionLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // actionLb
            // 
            this.actionLb.AutoSize = true;
            this.actionLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLb.Location = new System.Drawing.Point(0, 0);
            this.actionLb.MaximumSize = new System.Drawing.Size(600, 0);
            this.actionLb.Name = "actionLb";
            this.actionLb.Size = new System.Drawing.Size(0, 18);
            this.actionLb.TabIndex = 0;
            // 
            // WizardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionLb);
            this.Name = "WizardView";
            this.Size = new System.Drawing.Size(540, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label actionLb;

        public List<Meal> DataSource { get; set; }
        public int N { get; set; }
    }
}
