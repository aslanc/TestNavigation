using System;
using Xamarin.Forms;

namespace TestNavigation
{
    public class CustomTabButtons : StackLayout
    {

    }
    public class CustomTabButton : Button
    {
        public CustomTabButton()

        {

            Clicked += ThisTabButtonClicked;

        }
        public void ThisTabButtonClicked(object s, EventArgs e)

        {

            CustomTabs prnt = validParentCustomTabs();

            if (prnt == null) return;


            prnt.SelectedTabButton = this;

        }
        private CustomTabs validParentCustomTabs()

        {

            if (Parent != null && Parent.Parent != null &&

               Parent.Parent.GetType() == typeof(CustomTabs))

                return ((CustomTabs)Parent.Parent);
            else
            {
                throw new Exception(

                   "Error, el padre de un CustomTabButton " +

                   "deb ser un CustomTabs");
            }

        }
    }
}
