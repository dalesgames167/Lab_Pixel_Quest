using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public int speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        float horizotal = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(horizotal * speed. _rigidbody2D.velocity.y);
    }
}
