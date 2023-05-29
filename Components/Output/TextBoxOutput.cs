using Components.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components.Output
{
    public class TextBoxOutput : IOutput
    {
        private readonly TextBox _textBox;
        public TextBoxOutput(TextBox newTextBox)
        {
            _textBox = newTextBox;
        }
        public void Write(string text)
        {
            if (_textBox != null) 
            {
                _textBox.AppendText(text + Environment.NewLine);
            }
        }

        public void WriteLine(string text)
        {
            if (_textBox != null)
            {
                _textBox.AppendText(text + Environment.NewLine);
            }
        }
    }
}
