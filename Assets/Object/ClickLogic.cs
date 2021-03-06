using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    public TextMeshPro HealthTextBox;
    public TextMeshPro ScoreTextBox;
    public TextMeshPro ComboTextBox;

    
    void Start()
    {
        enabled = false;
    }

    // gain point
    public void NeutralScript()
    {
        comboValue++;
        points += comboValue * comboBoost;
        Debug.Log(points);

        healthValue++;
        healthValue = Mathf.Clamp(healthValue, 0, maxHealthValue);

        HealthTextBox.text = healthValue.ToString();
        ScoreTextBox.text = points.ToString();
        ComboTextBox.text = comboValue.ToString();
    }

    // Decrease life
    public void NegativeScript()
    {
        comboValue = 0;
        healthValue -= 40 * drainMultiplier;
        Debug.Log(healthValue);

        HealthTextBox.text = healthValue.ToString();
        ScoreTextBox.text = points.ToString();
        ComboTextBox.text = comboValue.ToString();
    }

    // Gain life
    public void PositiveScript()
    {
        healthValue = maxHealthValue;
        Debug.Log(healthValue);

        HealthTextBox.text = healthValue.ToString();
        ScoreTextBox.text = points.ToString();
        ComboTextBox.text = comboValue.ToString();
    }

    // increase point gain for an amount of time
    public void ComboBoostScript()
    {
        comboBoost += comboBoostMultiplier;
        Invoke("resetComboBoost", comboBoostMultiplierTimer);

        HealthTextBox.text = healthValue.ToString();
        ScoreTextBox.text = points.ToString();
        ComboTextBox.text = comboValue.ToString();
    } public void resetComboBoost() {comboBoost -= comboBoostMultiplier;}


    // stop life drain for set period of time
    public void StarmanScript()
    {
        drainMultiplier = drainMultiplier-1;
        Invoke("resetStarman", healthMultiplierTimer);

        HealthTextBox.text = healthValue.ToString();
        ScoreTextBox.text = points.ToString();
        ComboTextBox.text = comboValue.ToString();
    } public void resetStarman() {drainMultiplier++;}


    // Gain point but add distractions
    [Header("Camera Shake Variables")]
    public Transform cam;
    public float shakeTime;
    public float shakeIntensity;
    public float shakeSpeed;

    private float startTime;
    private int a;
    private float camRotation;
    public void DistractionScript()
    {
        //cam.Rotate(0,0,10);
        //Debug.Log(cam.transform.rotation);
        enabled = true;
        startTime = Time.time;
        //a=0;
        
    } void FixedUpdate()
    {
        a++;
        camRotation = shakeIntensity*Mathf.Sin(Mathf.PI*a/10*shakeSpeed);
        cam.transform.eulerAngles = new Vector3(0f, 0f, camRotation);

        if(startTime <= Time.time-shakeTime && a/10 % 10 == 0){
            cam.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            enabled = false;
            a=0;
        }
    }
}
