﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.PhoneJack
{
    public interface IPlayback
    {
        void Play(IPlayback playback);
    }
}
