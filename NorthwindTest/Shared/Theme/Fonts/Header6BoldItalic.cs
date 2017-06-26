﻿using System.Drawing;
using Firefly.Box.UI;
namespace NorthwindTest.Shared.Theme.Fonts
{
    /// <summary>Header 6 Bold Italic #77</summary>
    [System.ComponentModel.DesignerCategory("Component")]
    [System.ComponentModel.Description("Header 6 Bold Italic")]
    public class Header6BoldItalic : FontScheme 
    {
        public Header6BoldItalic()
        {
            try
            {
                this.Font = new Font("Times New Roman", 8F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point, 0);
            }
            catch
            {
            }
        }
    }
}