using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class GeoController : MonoBehaviour
{
    string variable1 = "Hello";
    string variable2 = "World";
    int variable3 = 3;
    private Rigidbody2D rb;
    public float speed = 7;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, -4, 5);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            transform.position += new Vector3(2, 1, 4);
        }
            if (Input.GetKeyDown(KeyCode.C))
        {
            transform.position += new Vector3(-1, 2, 3);
        }

        Debug.Log(variable3++);
        transform.position += new Vector3(0.005f, 0, 0); }
        }
        {
           rb.velocity=new Vector2(-1, rb.velocity.y);
        } 
           if (Input.GetKeyDown(KeyCode.E))
        }
           transform.position += new Vector3(-2,4,1)
        {
           if (Input.GetKeyDown(KeyCode.A))
        }
           trasnform.position += new Vector3(4,-3,5
        {
        */
        float xInput = Input.GetAxis("Horizontal");

        Debug.Log(xInput);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);


        
    }
}