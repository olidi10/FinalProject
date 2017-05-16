using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project
{
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {
            InitializeComponent();
            



        }
        String SUBMIT = "";
        String DECLINE = "";
        String RESET = "";
        
       


        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            SUBMIT = button.Text;
            
        }
        private void OnDeclineButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DECLINE = button.Text;

        }
        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            School.Text = "";
            Location.Text = ""; 
            FName.Text = "";
            LName.Text = "";
            NName.Text = "";
            Entry.Text = "";
            Exit.Text = "";
            Major.Items.Clear();
             
            Button button = (Button)sender;
            RESET = button.Text;

        }
        private void OnAcceptButtonClicked(object sender, EventArgs e)
        {

        }
        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            {
                object entry = null;
                if (entry == null)
                    return;
                Picker picker = (Picker)sender;
                int selectedIndex = picker.SelectedIndex;
                if (selectedIndex == -1)
                    return;
                string selectedItem = picker.Items[selectedIndex];
                //PropertyInfo propertyInfo = typeof(Keyboard).GetRuntimeProperty(selectedItem);
                //Collection views;
                //entry.Keyboard = (Keyboard)propertyInfo.GetValue(null);
                
            }
           
        }



    }

    internal class Collection
    {
    }
}
        
    

