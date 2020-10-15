using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BeaconHill_Coding_Test;

namespace BeaconHill_Coding_Test
{
    /// <summary>
    /// Derived class form with Keyboard Shortcuts enabled.
    /// </summary>
    public class BaseForm : Form
    {
        /// <summary>
        /// Event Handler for keyboard shortcuts.
        /// </summary>
        public event OnKeyboardShortCutEventHandler OnKeyboardShortCut;
        /// <summary>
        /// Override system method to process a command key shortcut.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            RaiseOnKeyboardShortcut(new OnKeyboardShortCutEventArg() { message = msg, KeyData = keyData });
            return base.ProcessCmdKey(ref msg, keyData);
        }
        void RaiseOnKeyboardShortcut(OnKeyboardShortCutEventArg e)
        {
            OnKeyboardShortCut?.Invoke(null, e);
        }
    }
}
