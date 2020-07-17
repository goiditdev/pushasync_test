using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pushasync_test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_RunTest_AwaitedPush(object sender, EventArgs e)
        {
            try
            {
                Page p = new SecondPage();
                System.Console.WriteLine("Running the test for awaited push...");
                Acr.UserDialogs.UserDialogs.Instance.Alert("This is a test", "Testing...");
                await this.Navigation.PushAsync(p);
                System.Console.WriteLine("Returned from awaited PushAsync, checking if page is on stack");
                if (this.Navigation.NavigationStack.Contains(p))
                {
                    System.Console.WriteLine("Page was pushed to stack!");
                }
                else
                {
                    System.Console.WriteLine("Page is not on stack!");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
        async void Handle_RunTest_UnawaitedPush(object sender, EventArgs e)
        {
            try
            {
                Page p = new SecondPage();
                System.Console.WriteLine("Running the test for unawaited push...");
                Acr.UserDialogs.UserDialogs.Instance.Alert("This is a test", "Testing...");
                this.Navigation.PushAsync(p);
                System.Console.WriteLine("Returned from unawaited PushAsync, checking if page is on stack");
                if (this.Navigation.NavigationStack.Contains(p))
                {
                    System.Console.WriteLine("Page was pushed to stack!");
                }
                else
                {
                    System.Console.WriteLine("Page is not on stack!");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
        async void Handle_RunTest_AwaitedAlert(object sender, EventArgs e)
        {
            try
            {
                Page p = new SecondPage();
                System.Console.WriteLine("Running the test for awaited AlertAsync...");
                await Acr.UserDialogs.UserDialogs.Instance.AlertAsync("This is a test", "Testing...");
                await this.Navigation.PushAsync(p);
                System.Console.WriteLine("Returned from awaited PushAsync, checking if page is on stack");
                if (this.Navigation.NavigationStack.Contains(p))
                {
                    System.Console.WriteLine("Page was pushed to stack!");
                }
                else
                {
                    System.Console.WriteLine("Page is not on stack!");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }
    }
}
