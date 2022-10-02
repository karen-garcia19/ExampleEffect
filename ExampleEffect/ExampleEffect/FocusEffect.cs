using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ExampleEffect
{
    public class FocusEffect : RoutingEffect
    {
        public FocusEffect() : base($"MyCompany.{nameof(FocusEffect)}")
        {
        }
    }
}
