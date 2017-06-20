using CookingWizard.Controls;
using CookingWizard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CookingWizard
{
    public partial class CookingWizardView : Form
    {
        private List<UserControl> wizardViews;
        private CookingWizardViewModel cookingWizardViewModel;
        private int pageIndex;

        public CookingWizardView()
        {
            InitializeComponent();
        }

#region Form Event Handlers

        private void CookingWizardView_Load(object sender, EventArgs e)
        {
            InitializeViewModels();
            SetUpMealSelectorCb();
        }

        private void MealSelectorCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cookingWizardViewModel.SelectedMeal = (Models_.Meal)((sender as ComboBox).SelectedItem);

            AddOrResetWizardViews();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (pageIndex < wizardViews.Count)
            {
                ReAddWizardViewToTableLayoutPanel(0);
                if (pageIndex != wizardViews.Count - 1)
                    pageIndex += 1;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                ReAddWizardViewToTableLayoutPanel(1);

                if (pageIndex != 1)
                {
                    pageIndex -= 1;
                }
            }
        }

        #endregion

#region Other methods
        /// <summary>
        /// Adds views to the wizardView collection depending on the size of the View Model's collection that 
        /// holds data to be displayed on the CookingWizardView pages.
        /// Views must be of type UserControl or extend the UserControl.
        /// </summary>
        private void AddViewsToWizardView()
        {
            foreach (Models_.Action action in cookingWizardViewModel.SelectedMeal.Recipe.Actions)
            {
                WizardView wizardView = new WizardView();
                wizardView.ActionLb.Text = action.Context;
                wizardView.Dock = DockStyle.Fill;
                wizardViews.Add(wizardView);
            }
        }

        /// <summary>
        /// Replaces the current view int the TableLayoutPanel displayed in the specific CookingWizardView page
        /// with new View from the wizardViews collection.
        /// </summary>
        /// <param name="index">
        /// Indicates whether next or previous view from the wizardView collection should be replaced.
        /// 0 - next View
        /// 1 - previous View
        /// </param>
        private void ReAddWizardViewToTableLayoutPanel(int index)
        {
            ViewHolder.Controls.RemoveAt(ViewHolder.Controls.Count - 1);
            ViewHolder.Controls.Add(wizardViews.ElementAt(pageIndex - index), 0, 1);
            ViewHolder.SetColumnSpan(wizardViews.ElementAt(pageIndex - index), 2);
        }

        /// <summary>
        /// Initializes data initial data
        /// </summary>
        private void InitializeViewModels()
        {
            pageIndex = 1;
            wizardViews = new List<UserControl>();
            cookingWizardViewModel = new CookingWizardViewModel();
            wizardViews.Add((UserControl)ViewHolder.GetControlFromPosition(0, 1));
        }

        /// <summary>
        /// Sets DataSource and EventHandlers for the mealSelector
        /// </summary>
        private void SetUpMealSelectorCb()
        {
            mealSelector1.MealSelectorCb.SelectedIndexChanged += new EventHandler(MealSelectorCb_SelectedIndexChanged);
            BindingSource comboBoxBindingSource = new BindingSource()
            {
                DataSource = cookingWizardViewModel.Meals
            };
            mealSelector1.MealSelectorCb.DataSource = comboBoxBindingSource;
            mealSelector1.MealSelectorCb.DisplayMember = "Name";
        }

        /// <summary>
        /// If user selects meal for the first time then add views to the wizardViews collection.
        /// Else user decides to go back to the main page to change his selected meal or he is changig
        /// meal from the main page. Remove all views from the wizardViews collection except the main page.
        /// </summary>
        private void AddOrResetWizardViews()
        {
            if (wizardViews.Count == 1)
            {
                AddViewsToWizardView();
            }
            else
            {
                wizardViews.RemoveRange(1, wizardViews.Count - 1);
                AddViewsToWizardView();
            }
        }

#endregion
    }
}
