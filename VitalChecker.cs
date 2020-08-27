using System;
using System.Diagnostics;

class VitalChecker
{
   public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        var flag1 = bpm_check(bpm);
        var flag2 = spo_check(spo2);
        var flag3 = resp_rate_check(respRate);
        if (flag1 == flag2 ==flag3 == true)
        {
            return true;
        }
        return false;
    }


    static bool bpm_check(float bpm)
    {
        return !(bpm < 70 || bpm > 150);
    }

    static bool spo_check(float spo2)
    {
        return !(spo2 < 90);
    }

    static bool resp_rate_check(float respRate)
    {
        return !(respRate < 30 || respRate > 95);
    }

}
