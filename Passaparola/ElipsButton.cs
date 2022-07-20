﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Passaparola
{
    public class ElipsButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new System.Drawing.Rectangle(new System.Drawing.Point(), this.Size));
            this.Region = new System.Drawing.Region(gp);
        }
    }
}
