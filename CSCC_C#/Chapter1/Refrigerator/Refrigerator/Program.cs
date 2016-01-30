using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class Refrigerator
    {
        int length;
        int width;
        int height;
        int areaOfBase;
        int volume;
        double temperature;
        string brand;
        string serialNumber;

        void AreaOfBase()
        {
            this.areaOfBase = this.length * this.width;
        }


        void SetVolume()
        {
            this.volume = this.length * this.width * this.height;
        }

        
        void SetTemperature()
        {
            this.temperature = (37.0 + 41.0) / 2;
        }
        
        void SetTemperature(double givenTemperature)
        {
            this.temperature = givenTemperature;
        }
    }
}
