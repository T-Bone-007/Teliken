using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pravis_Teliken.Handler
{
    public class FileHandler
    {
        public static FileHandler Instance = new FileHandler();
        public Image GetImage(string WhatImg) 
        {
            return Image.FromFile($"Pictures/{WhatImg}");
        }
    }
}
