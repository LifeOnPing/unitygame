using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class test : MonoBehaviour
{
    public Object_Placement ObjectPlacement;
    public Vector3[] ObjectPlaceholder;
    public float counter;
    public float BeatsPerMinute;
    private int i = 0;

    void Start()
    {
        BeatsPerMinute = 60/BeatsPerMinute;
    }

    void Update()
    {
        if(Input.GetKey("1"))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if(Input.GetAxis("Fire1") == 1 && i == 0) {
                Vector3[] temp = new Vector3[ObjectPlaceholder.Length+1];
                ObjectPlaceholder.CopyTo(temp, 0);
                ObjectPlaceholder = temp;
                print(ObjectPlaceholder.Length);
                ObjectPlaceholder[ObjectPlaceholder.Length-1] = new Vector3(mousePos.x, mousePos.y, counter);
                counter += BeatsPerMinute;
                i = 1;
                ObjectPlacement.ComboBoostPlacement = ObjectPlaceholder;
            } else if(Input.GetAxis("Fire1") == 0 && i == 1){
                i = 0;
            }

            //ObjectPlaceholder[len(ObjectPlaceholder)+1] = new Vector3(mousePos.x, mousePos.y, ObjectPlaceholder.Length);    //    add to placement array
            //ObjectPlaceholder = ObjectPlaceholder.Select().ToArray();
            //ObjectPlacement.ComboBoostPlacement = ObjectPlaceholder;
        }
    }

}
