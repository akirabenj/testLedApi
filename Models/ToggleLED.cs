using System.Device.I2c;

namespace testApi {
    public class ToggleLED {

        private I2cDevice device;
        public ToggleLED() {
            I2cConnectionSettings settings = new I2cConnectionSettings(1, 0x8);
            this.device = I2cDevice.Create(settings);
        }
        
        public void SwitchLED(bool state) {
            if (state) {
                device.WriteByte(0x1);
            } else {
                device.WriteByte(0x0);
            }
        }
    }
}