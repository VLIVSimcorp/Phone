using Components.BasicComponents;
using Components.Interfaces;
using System;

namespace Components.Screens.ColorfulScreens
{
    public class ColorfulScreen : ScreenBase
    {
        public override double Width { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override ScreenBase Screen => new ColorfulScreen();

        public override void Show(IScreenImage screenImage)
        {
            // here logic that draws colorful image can be added
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            
        }
        public override string ToString()
        {
            return "Colorful Screen";
        }

    }
}
