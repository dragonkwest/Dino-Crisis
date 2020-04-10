using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colors : MonoBehaviour
{
 
    public Button Green;
    public Button Red;
    public Button Blue;
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if{ if(Input.GetMouseButtonDown(0)}
        {
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color(1, 0, 0, 1);
        }
    }
}
