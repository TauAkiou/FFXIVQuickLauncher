﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVLauncher.PatchInstaller.ZiPatch
{
    enum ZiPatchCommandType
    {
        Unknown,
        FileHeader,
        APLY,
        SQPK,
        EndOfFile
    }
}
