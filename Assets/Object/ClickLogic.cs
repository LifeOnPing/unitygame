using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    public float healthValue;
    private float comboValue;
    private float points;

    // gain point
    public void DefaultCircleScript()
    {
        points++;
        Debug.Log(points);
        Destroy(DefaultCircle(UnityEngine.GameObject));
    }

    // Decrease life
    public void BadCircle()
    {
        
        Debug.Log("points");
    }

    // Gain life


    // increase point gain for an amount of time

    // stop life drain for set period of time

    // Gain point but add distractions

}
