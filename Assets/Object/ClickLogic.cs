using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    [Header("Health Stuff")]
    public int healthValue;
    public int maxHealthValue;
    public int drainMultiplier;
    public float healthMultiplierTimer;

    [Header("Points Stuff")]
    public float points;
    public float comboValue;
    public float comboBoost;
    public float comboBoostMultiplier;
    public float comboBoostMultiplierTimer;

    // gain point
    public void NeutralScript()
    {
        comboValue++;
        points += comboValue * comboBoost;
        Debug.Log(points);

        healthValue++;
        healthValue = Mathf.Clamp(healthValue, 0, maxHealthValue);
    }

    // Decrease life
    public void NegativeScript()
    {
        comboValue = 0;
        healthValue -= 40 * drainMultiplier;
        Debug.Log(healthValue);
    }

    // Gain life
    public void PositiveScript()
    {
        healthValue = maxHealthValue;
        Debug.Log(healthValue);
    }

    // increase point gain for an amount of time
    public void ComboBoostScript()
    {
        comboBoost += comboBoostMultiplier;
        Invoke("resetComboBoost", comboBoostMultiplierTimer);
    } public void resetComboBoost() {comboBoost -= comboBoostMultiplier;}


    // stop life drain for set period of time
    public void StarmanScript()
    {
        drainMultiplier = drainMultiplier-1;
        Invoke("resetStarman", healthMultiplierTimer);
    } public void resetStarman() {drainMultiplier++;}


    // Gain point but add distractions

}
