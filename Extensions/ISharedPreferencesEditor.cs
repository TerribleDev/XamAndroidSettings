using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SharedSettingsAbstraction.Extensions
{
   public static class AndroidExtensions
    {
       public static void SaveObject ( this ISharedPreferencesEditor ed, string key, object value)
       {
           var refType = value.GetType();

           if (refType == typeof(string))
           {
               ed.PutString(key,(String)value);
           }
           if (refType == typeof(bool))
           {
               ed.PutBoolean(key, (bool)value);
           }
           if (refType == typeof(int))
           {
               ed.PutInt(key, (int)value);
           }
           if (refType == typeof(float))
           {
               ed.PutFloat(key, (float)value);
           }
       }
    }
}