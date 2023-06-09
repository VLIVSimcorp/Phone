﻿using Components.Interfaces;
using System.Text;

namespace Components.BasicComponents
{
    public abstract class ScreenBase
    {
        public abstract ScreenBase Screen { get; }
        public abstract double Width { get; set; }
        public abstract double Height { get; set; }
        public abstract void Show(IScreenImage screenImage);

        public abstract void Show(IScreenImage screenImage, int brightness);
        public string GetDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            return descriptionBuilder.ToString();
        }

    }

}
