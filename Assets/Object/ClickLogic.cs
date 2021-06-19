using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    [Header("Health Stuff")]
    public int healthValue;
    public int maxHealthValue;

    [Header("Points Stuff")]
    public float points;
    public float comboValue;
    public float comboBoost;
    public float comboBoostMultiplier;
    public float comboBoostMultiplierTimer;

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
        comboBoost += comboBoostMultiplier;
        Invoke("resetComboBoost", comboBoostMultiplierTimer);
    } public void resetComboBoost() {comboBoost -= comboBoostMultiplier;}


    // stop life drain for set period of time

    // Gain point but add distractions

}
