﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public class ClsUIVaildator
    {
        internal int TxtBoxValidator(String TxtBoxField)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxField))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
