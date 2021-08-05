using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class test : MonoBehaviour
{
    public Object_Placement ObjectPlacement;
    public Vector3[] ObjectPlaceholder;

    void Update()
    {
        if(Input.GetAxis("One") == 1)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            

            ObjectPlaceholder.Add(mousePos.x, mousePos.y, ObjectPlaceholder.Length);        add to placement array
            ObjectPlaceholder = ObjectPlaceholder.Select().ToArray();
            //ObjectPlacement.ComboBoostPlacement = ObjectPlaceholder;
        }
    }

}
