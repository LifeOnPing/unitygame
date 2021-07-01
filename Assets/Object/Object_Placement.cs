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
    Vector3[] NeutralPlacement = new[] {new Vector3(2f, 14f, 5f),
                                        new Vector3(3f, 14f, 5.5f),
                                        new Vector3(4f, 14f, 6f),
                                        new Vector3(5f, 14f, 6.5f),
                                        new Vector3(6f, 14f, 7f),
                                        new Vector3(7f, 14f, 7.5f)};
                                                        
    //public float[] DistractionPlacementY = new float[] {1f,2f,3f};
    private int i;
    
    // Update is called once per frame
    void Update()
    {
        
        try{
        if(NeutralPlacement[i].z<=Time.time)
        {
            Instantiate(Neutral, new Vector3(NeutralPlacement[i].x, NeutralPlacement[i].y, 0f), Quaternion.identity).name = "Neutral"; // wtf how does this work
            i++;
        }}catch {}
        

    }
}
