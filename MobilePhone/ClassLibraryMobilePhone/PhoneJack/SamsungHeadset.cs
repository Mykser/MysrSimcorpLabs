﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.PhoneJack
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(IPlayback playback)
        {
            Output.WriteLine(playback.ToString());
        }

        public override string ToString()
        {
            return nameof(SamsungHeadset) + " sound";
        }
    }
}
