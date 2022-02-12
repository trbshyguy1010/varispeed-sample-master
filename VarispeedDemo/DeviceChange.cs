using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using VarispeedDemo.SoundTouch;
using DiscordRpcDemo;
using System.Collections.Generic;

namespace VarispeedDemo
{
    public class DeviceChange
    {
        public MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        public MMDevice device1;
        public WaveOutEvent wasabi;
        public void DeviceSet(int device)
        {            
            var outputDevice = new WaveOutEvent() { DeviceNumber = device };
            wasabi = outputDevice;
        }
    }
}
