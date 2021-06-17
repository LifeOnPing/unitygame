using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    public int healthValue;
    private float comboValue;
    private float points;

    // gain point
    public void CircleDefaultScript()
    {
        comboValue++;
        healthValue++;
        points+=comboValue;
        Debug.Log(healthValue);
    }

    // Decrease life
    public void CircleBadScript()
    {
        comboValue = 0;
        healthValue /= 3;
        Debug.Log(healthValue);
    }

    // Gain life
    public void CircleGoodScript()
    {
        healthValue=50;
        Debug.Log(healthValue);
    }

    // increase point gain for an amount of time

    // stop life drain for set period of time

    // Gain point but add distractions

}
