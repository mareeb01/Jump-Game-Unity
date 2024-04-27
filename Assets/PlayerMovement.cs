using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    //public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool rightKey = Input.GetKey(KeyCode.RightArrow);
        bool leftKey = Input.GetKey(KeyCode.LeftArrow);
        bool space = Input.GetKey(KeyCode.Space);
        if (rightKey == true)
        {
            Debug.Log("right Key is pressed");
            rb.AddForce(Vector2.right, ForceMode2D.Impulse);
        }

        if (leftKey == true)
        {
            Debug.Log("left Key is pressed");
            rb.AddForce(Vector2.left, ForceMode2D.Impulse);
        }

        if (space == true)
        {
            Debug.Log("space Key is pressed");
            rb.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }
}
//---------------------------------------------------------------------------------------
//debug.log
//start update fix update date update unity build in function