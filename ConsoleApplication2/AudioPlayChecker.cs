using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCore.CoreAudioAPI;

namespace ConsoleApplication2
{
    class AudioPlayChecker
    {
        // Gets the default device for the system
        public static MMDevice GetDefaultRenderDevice()
        {
            try
            {
                using (var enumerator = new MMDeviceEnumerator())
                {
                    return enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Checks if audio is playing on a certain device
        public static bool IsAudioPlaying(MMDevice device)
        {
            try
            {
                using (var meter = AudioMeterInformation.FromDevice(device))
                {
                    return meter.PeakValue > 0;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
