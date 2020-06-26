using System;
using Unosquare.RaspberryIO;

namespace testApi {
    public class ToggleLED {
        
        public void SwitchLED(bool state) {
            var device = Pi.I2C.AddDevice(0x8);
            if (state) {
                device.Write(0x1);
            } else {
                device.Write(0x0);
            }
        }
    }
}