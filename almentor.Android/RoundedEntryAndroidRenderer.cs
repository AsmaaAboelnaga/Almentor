using almentor.Droid;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(RoundedEntryAndroidRenderer), typeof(RoundedEntryAndroidRenderer))]
namespace almentor.Droid
{
    public class RoundedEntryAndroidRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            //base.OnElementChanged(e);
            //if (e.OldElement==null)
            {
                // Control.SetBackgroundResource(Resource.Layout.rounded_Entry);
                //var gradientDrawable = new GradientDrawable();
                //gradientDrawable.SetCornerRadius(60F);
                //gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                //gradientDrawable.SetColor(Android.Graphics.Color.LightGray);
                //Control.SetBackground(gradientDrawable);

                //Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }
    }
}