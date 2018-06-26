﻿using System;
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

        public void SendAttention(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

        public DialogResult SendQuestion(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.YesNoCancel, icon: MessageBoxIcon.Question);

        public void SendError(string text, string title) => MessageBox.Show(text: text, caption: title, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
    }
}