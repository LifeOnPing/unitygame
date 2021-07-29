using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Placement : MonoBehaviour
{
    [Header("Circle Types")]
    public GameObject[] CircleTypes;

    public int[] ArrayPos;

    public Vector3[] ComboBoostPlacement;
    public Vector3[] DistractionPlacement;
    public Vector3[] NegativePlacement;
    public Vector3[] NeutralPlacement;
    public Vector3[] PositivePlacement;
    public Vector3[] StarmanPlacement;

    public Vector3[][] john = new Vector3[5][];
    //Vector3 = new int[20][];

    private GameObject circle;
    private int Pos;
    
    void Start()
    {
        ArrayPos = new int[CircleTypes.Length];

        john[0] = ComboBoostPlacement;
        john[1] = DistractionPlacement;
    }

    void Update()
    {
        print(john[1][5].x);   now make this work
        /*while(NeutralPlacement.Length != Pos)
        {
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
        }*/
        

    }
}
