using System.Device.I2c;

namespace testApi {
    public interface ITemperatureService
    {
        string getCurrentTemperature();
    }

    public class TemperatureService: ITemperatureService 
    {
        private I2cDevice device;
        public TemperatureService()
        {
            I2cConnectionSettings settings = new I2cConnectionSettings(1, 0x8);
            this.device = I2cDevice.Create(settings);
        }
        public string getCurrentTemperature()
        {
            var temp = device.ReadByte().ToString();
            return temp;
        }
    }
}