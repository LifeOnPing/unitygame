using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Placement : MonoBehaviour
{
    [Header("Circle Types")]
    public GameObject[] CircleTypes;

    public int[] ArrayPos;

    [Header("Circle Placement")]
    public Vector3[] ComboBoostPlacement;
    public Vector3[] DistractionPlacement;
    public Vector3[] NegativePlacement;
    public Vector3[] NeutralPlacement;
    public Vector3[] PositivePlacement;
    public Vector3[] StarmanPlacement;

    public Vector3[][] PlacementArray = new Vector3[6][];
    //Vector3 = new int[20][];

    private GameObject circle;
    private int Pos;
    
    void Start()
    {
        ArrayPos = new int[CircleTypes.Length];

        PlacementArray[0] = ComboBoostPlacement;
        PlacementArray[1] = DistractionPlacement;
        PlacementArray[2] = NegativePlacement;
        PlacementArray[3] = NeutralPlacement;
        PlacementArray[4] = PositivePlacement;
        PlacementArray[5] = StarmanPlacement;
    }

    void Update()
    {
        while(NeutralPlacement.Length != Pos)           look at arkive and fix this
        {
        print("PlacementArray[1][5].x");
            if( NeutralPlacement.Length != ArrayPos[0] &&
                NeutralPlacement[ArrayPos[0]].z<=Time.time) {
                circle = (GameObject)Instantiate(CircleTypes[0], new Vector3(   NeutralPlacement[ArrayPos[0]].x,
                                                    NeutralPlacement[ArrayPos[0]].y,
                                                    ArrayPos[0]/10000f),
                                                    Quaternion.identity);
                circle.name = "Neutral";
                Destroy(circle, 2f);
                ArrayPos[0]++;
            }
            Pos++;
        }
        

    }
}
