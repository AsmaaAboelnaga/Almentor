using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace almentor
{
   public  class RoundedEntry : Entry
    {
        public static readonly BindableProperty CorenerRadiusProperty =
           BindableProperty.Create<RoundedEntry, double>(p => p.CornerRadius, 0);
        public double CornerRadius
        {
            get { return (double)base.GetValue(CorenerRadiusProperty); }
            set { base.SetValue(CorenerRadiusProperty, value); }
        }
        public static readonly BindableProperty StrokeProperty =
         BindableProperty.Create<RoundedEntry, Color>(p => p.Stroke, default(Color));

        public Color Stroke
        {
            get { return (Color)base.GetValue(StrokeProperty); }
            set { base.SetValue(StrokeProperty, value); }
        }

        public static readonly BindableProperty StrokeThicknessProperty =
        BindableProperty.Create<RoundedEntry, double>(p => p.StrokeThickness, default(double));

        public double StrokeThickness
        {
            get { return (double)base.GetValue(StrokeThicknessProperty); }
            set { base.SetValue(StrokeThicknessProperty, value); }
        }
    }
}
