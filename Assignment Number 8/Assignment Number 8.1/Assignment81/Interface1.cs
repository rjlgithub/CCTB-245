using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment81
{
    interface IVehicle
    {
        void SteeringWheel();
        void GasPedal();
        void Brakes();
    }

    interface ICruiseControl
    {
        void CruiseControl();
    }

    interface IGPS
    {
        void GPS();
    }

    interface IBoseSpeakers
    {
        void BoseSpeakers();
    }
}
