using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacoiIII.Misc
{
    class Error
    {
        public void SendOK(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

        public void SendAttention(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);

        public DialogResult SendQuestion(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button2);

        public DialogResult SendQuestionAndCancel(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.YesNoCancel, icon: MessageBoxIcon.Question, defaultButton: MessageBoxDefaultButton.Button3);

        public void SendError(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
    }
}