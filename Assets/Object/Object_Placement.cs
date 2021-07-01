using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Placement : MonoBehaviour
{
    public GameObject ComboBoost;
    public GameObject Distraction;
    public GameObject Negative;
    public GameObject Neutral;
    public GameObject Positive;
    public GameObject Starman;
    
    // Update is called once per frame
    void Start()
    {
        Instantiate(Distraction, new Vector3(0, 0, 0), Quaternion.identity).name = "Distraction"; // wtf how does this work
    }
}
