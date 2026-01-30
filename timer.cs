using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    //value for which timer counts down from to 0
    protected float startTime;
    //constructor taking in the calue for start time
    public Timer(float number)
    {
        startTime = number;
    }
    
//Coundown starts decreasing by Time.deltaTime until hits 0 (or passes below)
    public bool startCountdown()
    {
        if ((startTime > 0))
        {
            startTime -= Time.deltaTime;
            //Timer is still cooking!
            return false;
        }
        else
        {
            //*DING* timer is done!
            return true;
        }
    }

    //startTime reference
    public float getStartTime()
    {
        return startTime;
    }
    //change value of startTime
    public void setStartTime(float val)
    {
        startTime = val;
    }

}

