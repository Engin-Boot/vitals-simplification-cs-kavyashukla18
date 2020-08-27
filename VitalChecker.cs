using System;

class VitalChecker
{
    static bool bpmChecker (float bpm)
    {
        return (bpm < 70 || bpm > 150);
    }

    static bool spo2Checker(float spo2)
    {
        return (spo2 < 90);
    }

    static bool respRateChecker(float respRate)
    {
        return (respRate < 30 || respRate > 95);
    }
    public static bool vitalsAreOk(float bpm, float spo2, float respRate)
    {
        bool bpmCheck = bpmChecker(bpm);
        bool spo2check = spo2Checker(spo2);
        bool respRateCheck = respRateChecker(respRate);
        if (bpmCheck || spo2check || respRateCheck)
        {
            return false;
        }
        return true;
    }
}
