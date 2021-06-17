using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    public int healthValue;
    public int maxHealthValue;
    private int comboBoost = 1;
    private float comboValue;
    private float points;

    // gain point
    public void CircleNeutralScript()
    {
        comboValue++;
        points+=comboValue*comboBoost;
        Debug.Log(points);

        healthValue++;
        healthValue = Mathf.Clamp(healthValue, 0, maxHealthValue);
    }

    // Decrease life
    public void CircleNegativeScript()
    {
        comboValue = 0;
        healthValue -= 40;
        Debug.Log(healthValue);
    }

    // Gain life
    public void CirclePositiveScript()
    {
        healthValue=maxHealthValue;
        Debug.Log(healthValue);
    }

    // increase point gain for an amount of time
    public void CircleComboBoostScript()
    {
        comboBoost = 5;
        Invoke("comboBoost = 1;", 5);
    }


    // stop life drain for set period of time

    // Gain point but add distractions

}
