using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Text display_Text;
    private int h;

    void Update()
    {
        h = (int)(1f / Time.unscaledDeltaTime);
    }
    void FixedUpdate()
    {
        display_Text.text = h.ToString();
    }

}
