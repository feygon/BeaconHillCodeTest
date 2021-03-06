﻿/*
    Author: Richard Nickerson
    Date:   2020-10-15
    Desc:   This is a form which takes keywords from a title and bold text in a text box,
                and searches for images matching those keywords on Google Images through
                a Google WebHook
 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

using GoogleSearchClasses;

namespace BeaconHill_Coding_Test
{
    /// <summary>
    /// Partial class for methods involved in operation of the BaseForm ImageSearchByTitleAndKeywords.
    /// </summary>
    public partial class ImageSearchByTitleAndKeywords : BaseForm
    {
        List<(CheckBox, PictureBox, int)> pics;
        List<string> keyWords = new List<string>();
        string keyWordString;
        List<(Image img, int index, string title)> pickedImageFiles = new List<(Image img, int index, string title)>();

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ImageSearchByTitleAndKeywords()
        {
            InitializeComponent();
            OnKeyboardShortCut += Form_OnKeyboardShortCut;
        }
        #endregion
        #region KeyBoard Shortcut Methods
        // Ctrl-B clicks the bold button.
        private void Form_OnKeyboardShortCut(object Sender, OnKeyboardShortCutEventArg e)
        {
            if (e.KeyData == (Keys.Control | Keys.B)
                && SlideTextRTBox.Focused
                && SlideTextRTBox.SelectionLength > 0)
            {
                BoldButton_Click(Sender, e);
            }
        }
        #endregion
        #region Button Methods
        private void SelectImagesBtn_Click(object sender, EventArgs e)
        {
            if (pickedImageFiles.Count > 0)
            {
                string keyWordString = "";
                foreach (string s in keyWords) { String.Concat(keyWordString, s, " "); }
                string str = String.Format($"You picked {pickedImageFiles.Count.ToString()} images from keywords\n {ScanKeyWords()}:");
                foreach (var pic in pickedImageFiles)
                {
                    str = string.Concat(str, "\n", pic.index); // tags have image filenames.
                }
                MessageBox.Show(str);
            }
            else { MessageBox.Show("Please select at least one image."); }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<PictureBox> pics = new List<PictureBox>() {
                pic0, pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 };

            string keyWords = ScanKeyWords();
            this.keyWordString = String.Concat(keyWordString, keyWords);
            //RunAsync().GetAwaiter().GetResult();
            var imageSearch = new GoogleSearch(null, null);
            var x = imageSearch.TBMISCH;
            imageSearch.Options.Add(x.Key, x.Value);
            //basic search
            List<(string src, string title)> imgURLs = imageSearch.Search(keyWords);
            //List<Task> tasks = new List<Task>();
            int i = 0;
            List<int> skipped = new List<int>();
            foreach (var url in imgURLs)
            {
                if (url.src.StartsWith("http") && i < 9)
                {
                    WebRequest req = WebRequest.Create(url.src);
                    WebResponse res = req.GetResponse();
                    System.IO.Stream stream = res.GetResponseStream();
                    pics[i].Image = Image.FromStream(stream);
                    pics[i].Tag = url.title;
                    i++;
                } else { skipped.Add(i);}
            };
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            int pos = SlideTextRTBox.SelectionStart,
                len = SlideTextRTBox.SelectionLength;
            bool isBold = SlideTextRTBox.SelectionFont.Bold;
            if (!isBold)
            {
                SlideTextRTBox.SelectionFont = new Font(SlideTextRTBox.Font, FontStyle.Bold);
            }
            else
            {
                SlideTextRTBox.SelectionFont = SlideTextRTBox.Font;
            }

            SlideTextRTBox.Focus();
            SlideTextRTBox.SelectionStart = pos;
            SlideTextRTBox.SelectionLength = len;
        }
        #endregion
        #region Keyword Processing
        /// <summary>
        /// Get a list of parsed words from the title box
        /// </summary>
        /// <returns></returns>
        private List<string> ScanTitle()
        {
            string[] words = ParseAndTrim(TitleTextBox.Text);
            return words.ToList();
        }

        /// <summary>
        /// Scan parsed bold substrings of textbox into search keywords
        /// </summary>
        private string ScanKeyWords()
        {
            keyWords.Clear();
            List<string> titleKeyWords = new List<string>(ScanTitle().AsEnumerable());
            // Get original text, focus, selection position and length, and initialize a dictionary for which individual characters are bold and/or valid alphanumeric
            bool titleFocus = TitleTextBox.Focused;
            bool textBoxFocus = SlideTextRTBox.Focused;
            int pos = 0, len = 0;
            if (titleFocus) { pos = TitleTextBox.SelectionStart; len = TitleTextBox.SelectionLength; }
            else if (textBoxFocus) { pos = SlideTextRTBox.SelectionStart; len = SlideTextRTBox.SelectionLength; }

            SlideTextRTBox.Focus();

            // Collect the bold characters and their positions.
            Dictionary<int, (char, bool, bool)> boldCharsInSlideText = GetBoldCharacters(); // helper

            List<string> TextBoxKeyWords = GetWordsFromCharMap(boldCharsInSlideText); // helper

            List<string> AllKeyWords = new List<string>(titleKeyWords.AsEnumerable());

            AllKeyWords.AddRange(TextBoxKeyWords.AsEnumerable());
            this.keyWords = AllKeyWords.Distinct().ToList();

            SlideTextRTBox.SelectionStart = 0;
            SlideTextRTBox.SelectionLength = 0;
            SearchButton.Focus();

            string str = string.Empty;
            foreach (var word in keyWords)
            {
                str = string.Concat(str, word, " ");
            }
            return str;
        }
        #endregion
        #region PicPick Methods
        private void SelectPic0_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(0);
        }

        private void SelectPic1_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(1);
        }

        private void SelectPic2_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(2);
        }

        private void SelectPic3_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(3);
        }

        private void SelectPic4_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(4);
        }

        private void SelectPic5_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(5);
        }

        private void SelectPic6_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(6);
        }

        private void SelectPic7_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(7);
        }

        private void SelectPic8_CheckedChanged(object sender, EventArgs e)
        {
            PicChecked(8);
        }
        #endregion
        #region Helpers
        /// <summary>
        /// Parse a string into words, whitespace and punctuation.
        /// Then split it into an array delimited by whitespace and punctuation.
        /// Finally, trim out the whitespace and punctuation.
        /// Leave any hyphenated word pairings together. 
        /// Email addresses, decimals (and bold periods), hashtags and words containing hashtag signs are left intact.
        /// /// <para>Operational Complexity: Linear Time</para>
        /// </summary>
        /// <param name="str">The string to parse.</param>
        /// <returns></returns>
        private string[] ParseAndTrim(string str)
        {
            return new string(str.Cast<char>().Where((ltr) => char.IsLetterOrDigit(ltr)
                    || char.IsWhiteSpace(ltr)
                    || "# ,.@!'?-;/".Contains(ltr)).ToArray()
                ) // new string
                .Split(" ,!;/".ToCharArray())
                .Distinct()
                .Select((word) => word.Trim(" ,!;/".ToCharArray())
                ).ToArray();
        }
        /// <summary>
        /// Get the bold characters, map by position, and mark whether they are bold and/or valid.
        /// <para>Operational Complexity: Linear Time</para>
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, (char, bool, bool)> GetBoldCharacters()
        {
            Dictionary<int, (char, bool, bool)> boldCharsInSlideText = new Dictionary<int, (char ch, bool isBold, bool isValidChar)>();
            for (int i = 0; i < SlideTextRTBox.Text.Length; i++)
            {
                SlideTextRTBox.SelectionStart = i;
                SlideTextRTBox.SelectionLength = 1;
                char ch = SlideTextRTBox.Text[i];
                if (char.IsLetterOrDigit(ch) || " @#,.'!?-/;".Contains(ch))
                {
                    boldCharsInSlideText.Add(i, (ch, SlideTextRTBox.SelectionFont.Bold, (bool)(char.IsLetterOrDigit(ch) || "-#@'.".Contains(ch))));
                }
                else
                {
                    boldCharsInSlideText.Add(i, (' ', false, false));
                }
            }
            return boldCharsInSlideText;
        }

        /// <summary>
        /// Iterate through the letters in the map, noting where words start and stop.
        /// Record each word after it ends.
        /// /// <para>Operational Complexity: Linear Time</para>
        /// </summary>
        /// <param name="boldCharsInSlideText">Map of characters and their properties.</param>
        /// <returns></returns>
        private List<string> GetWordsFromCharMap(Dictionary<int, (char, bool, bool)> boldCharsInSlideText)
        {
            List<string> TBKeyWords = new List<string>();
            // get bold words from parsed bold characters.
            int ctr = 0;
            int wordStart = 0;
            int wordEnd = 0;
            bool inWord = false;
            while (ctr <= boldCharsInSlideText.Count())
            {
                bool inWordArFirst = inWord;
                bool end = !boldCharsInSlideText.TryGetValue(ctr, out (char, bool, bool) value);
                (int index, (char ch, bool isBold, bool isValidChar) val) kvp = (-42, (char.MaxValue, false, false)); // bunk data.
                if (!end)
                {
                    kvp = (ctr, value);
                }
                else { inWord = false; }
                // Has a word just started? Start collecting characters.
                if (!inWord && kvp.val.isValidChar && kvp.val.isBold)
                {
                    wordStart = ctr;
                    inWord = true;
                }
                // Has a word just ended? Add that word to the array of words to add.
                if (inWord && (!kvp.val.isValidChar || !kvp.val.isBold))
                {
                    inWord = false;
                }
                if (!inWord && inWordArFirst)
                {
                    wordEnd = ctr;
                    TBKeyWords.Add(new string(
                        boldCharsInSlideText
                        .Where((ch) => (ch.Key >= wordStart && ch.Key < wordEnd))
                        .Select((val) => val.Value.Item1)
                        .ToArray()));
                }
                ctr++;
            }
            return TBKeyWords;
        }
        /// <summary>
        /// If the box is checked, add up to 3 images to the picked images. If there's already 3, uncheck it.
        /// If the box is unchecked, remove the image from picked images (if it's there).
        /// <para>Operational Complexity: Constant Time</para>
        /// </summary>
        /// <param name="v"></param>
        private void PicChecked(int v)
        {
            int index = -42;
            CheckBox box;
            PictureBox pic;
            switch (v)
            {
                case 0: box = SelectPic0; pic = pic0; index = 0; break;
                case 1: box = SelectPic1; pic = pic1; index = 1; break;
                case 2: box = SelectPic2; pic = pic2; index = 2; break;
                case 3: box = SelectPic3; pic = pic3; index = 3; break;
                case 4: box = SelectPic4; pic = pic4; index = 4; break;
                case 5: box = SelectPic5; pic = pic5; index = 5; break;
                case 6: box = SelectPic6; pic = pic6; index = 6; break;
                case 7: box = SelectPic7; pic = pic7; index = 7; break;
                case 8: box = SelectPic8; pic = pic8; index = 8; break;
                default: throw new Exception("Bad input.");
            }

            if (box.CheckState == CheckState.Checked)
            {
                if (pickedImageFiles.Count < 3)
                {
                    pickedImageFiles.Add((pic.Image, index, (string)pic.Image.Tag));
                }
                else
                {
                    box.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Please limit your selection to 3 images.");
                }
            }
            else
            {
                if (pickedImageFiles.Contains((pic.Image, index, (string)pic.Image.Tag)))
                {
                    pickedImageFiles.Remove((pic.Image, index, (string)pic.Image.Tag));
                }
            }
            #endregion
        }
    }
}