using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileBlazorAdvanced.Droid.Services
{
    public class AdvancedMessage : IAdvancedMessage
    {
        public void ShowMessageAndCatchAction(string Message, Action<string> ToClick)
        {
            var Activity = (Activity)MainActivity.CurrentActivity;
            var view = Activity.FindViewById(Android.Resource.Id.Content);
            Snackbar snackbar = Snackbar.Make(view, Message, Snackbar.LengthLong)
                .SetAction("Regresa", o =>
                {
                    ToClick.Invoke("Regresa, Toco el Snack");
                });
                snackbar.Show();
        }
        
    }
}