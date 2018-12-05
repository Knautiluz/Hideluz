using System;
using System.Windows.Forms;

namespace HideluzEstacionamentos.Controllers
{
    public static class AuxMethods
    {
        public static string TextNoFormatting(this MaskedTextBox _mask)
        {
            _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String retString = _mask.Text;
            _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return retString;
        }
    }
}
