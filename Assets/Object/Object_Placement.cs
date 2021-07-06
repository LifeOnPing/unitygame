using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Placement : MonoBehaviour
{
    
    public GameObject[] circle = new GameObject[] {};
    public GameObject ComboBoost;
    public GameObject Distraction;
    public GameObject Negative;
    public GameObject Neutral;
    public GameObject Positive;
    public GameObject Starman;

    private int ComboBoostArrayPos;
    private int DistractionArrayPos;
    private int NegativeArrayPos;
    private int NeutralArrayPos;
    private int PositiveArrayPos;
    private int StarmanArrayPos;

    public Vector3[] ComboBoostPlacement = new Vector3[] {new Vector3(0f, 0f, 0f)};
    public Vector3[] DistractionPlacement = new Vector3[] {new Vector3(0f, 0f, 0f)};
    public Vector3[] NegativePlacement = new Vector3[] {new Vector3(0f, 0f, 0f)};
    public Vector3[] NeutralPlacement = new Vector3[] {new Vector3(0f, 0f, 0f)};
    public Vector3[] PositivePlacement = new Vector3[] {new Vector3(0f, 0f, 0f)};
    public Vector3[] StarmanPlacement = new Vector3[] {new Vector3(0f, 0f, 0f)};
                                                        
    //public float[] DistractionPlacementY = new float[] {1f,2f,3f};
    
    void Update()
    {
        
        
        if( NeutralPlacement.Length != NeutralArrayPos &&
            NeutralPlacement[NeutralArrayPos].z<=Time.time) {
            Instantiate(Neutral, new Vector3(   NeutralPlacement[NeutralArrayPos].x,
                                                NeutralPlacement[NeutralArrayPos].y,
                                                NeutralArrayPos/10000f),
                                                Quaternion.identity).name = "Neutral";
            NeutralArrayPos++;
        }
        

    }
}
