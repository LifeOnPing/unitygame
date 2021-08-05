using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Placement : MonoBehaviour
{
    [Header("Circle Types")]
    public GameObject[] CircleTypes;

    private int[] ArrayPos;

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
    private int CirclePosition;
    
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
        while(CircleTypes.Length != Pos)
        {
            if( PlacementArray[Pos].Length != ArrayPos[Pos] &&
                PlacementArray[Pos][ArrayPos[Pos]].z<=Time.time)
            {
                circle = (GameObject)Instantiate(   CircleTypes[Pos], new Vector3(   PlacementArray[Pos][ArrayPos[Pos]].x,
                                                    PlacementArray[Pos][ArrayPos[Pos]].y,
                                                    CirclePosition/10000f),
                                                    Quaternion.identity);
                circle.name = circle.name.Split(char.Parse("("))[0];
                Destroy(circle, 2f);
                ArrayPos[Pos]++;
                CirclePosition++;
            }
            Pos++;
        } Pos = 0;
        
        if() make object placements
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
