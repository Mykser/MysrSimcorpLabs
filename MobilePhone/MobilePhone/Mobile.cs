﻿using MobilePhone.PhoneJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public abstract class Mobile
    {
        public abstract ScreenBase Screen { get; }

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);
        }
        public string GetDescription()
        {
            var descripionBuilder = new StringBuilder();
            descripionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            return descripionBuilder.ToString();
        }
        public IPlayback PlaybackComponent { get; set; }
        public void Play(object data)
        {
            PlaybackComponent.Play(data);
        }

    }
}
