using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //config para
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float ScreenWidth = 16f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * ScreenWidth;
        Vector2 padPos = new Vector2(transform.position.x, transform.position.y);
        padPos.x = Mathf.Clamp(mousePos, minX, maxX);
        transform.position = padPos;



    }

}
