using System;
using System.Diagnostics;
class Checker
{
    static void ExpectTrue(bool expression)
    {
        if (!expression)
        {
            VitalLog.getVitalLog("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression)
    {
        if (expression)
        {
            VitalLog.getVitalLog("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main()
    {
        ExpectTrue(VitalChecker.vitalsAreOk(100, 95, 60));
        ExpectFalse(VitalChecker.vitalsAreOk(40, 91, 92));
        VitalLog.getVitalLog("All ok");
        return 0;
    }
}
