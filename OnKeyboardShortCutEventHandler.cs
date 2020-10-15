using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeaconHill_Coding_Test
{
    /// <summary>
    /// A class to catch keyboard shortcuts in a form.
    /// </summary>
    public class OnKeyboardShortCutEventArg : EventArgs
    {
        /// <summary>
        /// System Message
        /// </summary>
        public Message message { get; set; }
        /// <summary>
        /// Data about keypresses
        /// </summary>
        public Keys KeyData { get; set; }
    }
    /// <summary>
    /// Handler for shortcutevents, using shortcuteventargs.
    /// </summary>
    /// <param name="Sender"></param>
    /// <param name="e"></param>
    public delegate void OnKeyboardShortCutEventHandler(object Sender, OnKeyboardShortCutEventArg e);
}