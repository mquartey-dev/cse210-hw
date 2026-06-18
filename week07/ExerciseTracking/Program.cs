using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Running runningAct = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingAct = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming swimmingAct = new Swimming("05 Nov 2022", 20, 40);

        // Use a polymorphic list of the base type Activity so each derived
        // activity type can be stored together and summarized uniformly.
        List<Activity> activities = new List<Activity>();
        activities.Add(runningAct);
        activities.Add(cyclingAct);
        activities.Add(swimmingAct);

        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("--------------------------");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}