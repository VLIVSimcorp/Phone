using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Screens.ColorfulScreens
{
    public class RetinaScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            // here logic for Retina screen can be added        }
        }
        public override string ToString()
        {
            return "Retina Screen";
        }

    }
}
