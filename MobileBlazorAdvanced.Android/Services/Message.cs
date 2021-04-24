using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileBlazorAdvanced.Droid.Services
{
    public class Message : MobileBlazorAdvanced.IMessage
    {
        public void ShowMessage(string texto)
        {
            Toast.MakeText(Android.App.Application.Context, $"{texto}", ToastLength.Long).Show();
        }
    }
}