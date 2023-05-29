using Components.BasicComponents;
using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Screens
{
    public class MonochromeScreen : ScreenBase
    {
        public override double Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override ScreenBase Screen => new MonochromeScreen();

        public override void Show(IScreenImage screenImage)
        {
            //here logic that draws monochrome image can be added
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
           
        }
        public override string ToString()
        {
            return "Monochrome Screen";
        }

    }
}

