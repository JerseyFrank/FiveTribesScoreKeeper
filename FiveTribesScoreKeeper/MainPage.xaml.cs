using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace FiveTribesScoreKeeper
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private string Total(int PlayerNum)
        {
            int result = 0;
            
            List<int> lsValues = this.GetValues(PlayerNum);
            foreach(int i in lsValues)
            {
                result += i;
            }

            return result.ToString();
        }

        private List<int> GetValues(int colIndex)
        {
            List<int> lsResult = new List<int>();

            Type tbType = new TextBox().GetType();
            foreach (UIElement uie in gridInputs.Children)
            {
                if (uie.GetType() == tbType)
                {
                    TextBox tb = (TextBox)uie;
                    if (Grid.GetColumn(tb) == colIndex)
                    {
                        //lsResult.Add(1);
                        if (tb.Text == "")
                            lsResult.Add(0);
                        else
                            lsResult.Add(Convert.ToInt32(tb.Text));
                    }
                }
            }

            return lsResult;
        }
                
        private void tbCoinsP1_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblkTotalP1.Text = this.Total(1);
        }

        private void tbCoinsP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblkTotalP2.Text = this.Total(2);
        }

        private void tbCoinsP3_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblkTotalP3.Text = this.Total(3);
        }

        private void tbCoinsP4_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblkTotalP4.Text = this.Total(4);
        }
    }
}
