using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [Header("Mouse")]
    public GameObject MouseSprite;
    public ClickLogic a;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        MouseSprite.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)+new Vector3(0f, 0f, 1f);
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if (hit.collider != null) {
                string objectHit = hit.collider.ToString();
                objectHit = objectHit.Split(char.Parse(" "))[0];
                a.Invoke(objectHit, 0f);
                Debug.Log(objectHit);
            }
        }
        
    }
}
