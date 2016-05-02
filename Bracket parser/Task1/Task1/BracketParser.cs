using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Task1
{
     partial class FBracketParser : Form
    {
        public FBracketParser()
        {
            InitializeComponent();
        }
        private static readonly char[] _Brackets = { '(', '{', '[', ')', '}', ']' };
        private static readonly int _centerOfBrackets = _Brackets.Length/2;

        private void bCheck_Click(object sender, EventArgs e)
        {  
            var result = CheckBrackets(tBInputBox.Text);
            lIsCorrect.Text = result == 0
                ? "Correct"
                : result < 0
                    ? "Error: need closing bracket"
                    : string.Format("Error in {0} symbol", result);
        }
        
        public int CheckBrackets(string inputText)
        {
            var bracketsStack = new Stack<int>();
            for (int i = 0; i < inputText.Length; i++)
            {
                var bracketIndex=Array.IndexOf(_Brackets, inputText[i]);
                if (bracketIndex == -1) continue;
                if (bracketIndex < _centerOfBrackets)
                {
                    bracketsStack.Push(bracketIndex);
                    continue;
                }
                if (bracketsStack.Count==0 || bracketsStack.Pop() != (bracketIndex - _centerOfBrackets))
                    return i+1;
            }
            return -bracketsStack.Count;

        }
    }
}
