﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MyBean
{
    public interface IShowAsNormal
    {
        void ShowAsNormal();
    }

    public interface IShowAsMDI
    {
        void ShowAsMDI();
    }

    public interface IShowAsModal
    {
        void ShowAsModal();
    }

    public interface IShowAsChild
    {
        void ShowAsChild(Control parentControl);
    }
}

