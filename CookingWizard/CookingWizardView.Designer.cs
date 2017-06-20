using System;

namespace CookingWizard
{
    partial class CookingWizardView
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
            this.ViewHolder = new System.Windows.Forms.TableLayoutPanel();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.mealSelector1 = new Controls.MealSelector();
            this.ViewHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewHolder
            // 
            this.ViewHolder.AutoSize = true;
            this.ViewHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewHolder.ColumnCount = 3;
            this.ViewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ViewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ViewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ViewHolder.Controls.Add(this.Previous, 1, 2);
            this.ViewHolder.Controls.Add(this.Next, 2, 2);
            this.ViewHolder.Controls.Add(this.mealSelector1, 0, 1);
            this.ViewHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewHolder.Location = new System.Drawing.Point(0, 0);
            this.ViewHolder.Name = "ViewHolder";
            this.ViewHolder.RowCount = 3;
            this.ViewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ViewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ViewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ViewHolder.Size = new System.Drawing.Size(734, 365);
            this.ViewHolder.TabIndex = 0;
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous.Location = new System.Drawing.Point(590, 335);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(67, 23);
            this.Previous.TabIndex = 3;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Next.Location = new System.Drawing.Point(663, 335);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(68, 23);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // mealSelector1
            // 
            this.ViewHolder.SetColumnSpan(this.mealSelector1, 3);
            this.mealSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealSelector1.Location = new System.Drawing.Point(3, 39);
            this.mealSelector1.Name = "mealSelector1";
            this.mealSelector1.Size = new System.Drawing.Size(728, 286);
            this.mealSelector1.TabIndex = 4;
            // 
            // CookingWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 365);
            this.Controls.Add(this.ViewHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CookingWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CookingWizardView_Load);
            this.ViewHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ViewHolder;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private Controls.MealSelector mealSelector1;
    }
}

