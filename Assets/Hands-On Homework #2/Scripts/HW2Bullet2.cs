using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2Bullet1 : MonoBehaviour
{
    //==================================================================================================================
    // Variables 
    //==================================================================================================================

    //Used by Player Spawner 
    private Camera _camera;    //Camera Game Object 
    private Vector3 _mousePos; //Current Mouse Position  

    //Movement Controls 
    private Rigidbody2D _rigidbody2D; //The rigidbody that will move the bullet 
    public float speed = 2;           //Speed at which the bullet moves 

    //Flag and Timer 
    public float deathTime = 1.5f;   //How long before the bullet dies 
    public bool playerBullet1 = true; //Is the bullet used by player or enemy 

    //==================================================================================================================
    // Base Method  
    //==================================================================================================================

    //Checks who is shooting the bullet and set up the bullet settings 
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
        _camera = GameObject.Find("Game_Camera").GetComponent<Camera>();
        _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        RotationUpdate(_mousePos);
    }
    //Takes in the position of the mouse or the player, then calculates the rotation
    //And set it 
    private void RotationUpdate(Vector3 pos1)
    {
        var pos2 = transform.position;
        var dir = pos1 - pos2;
        var rotation = pos2 - pos1;
        _rigidbody2D.velocity = new Vector2(dir.x, dir.y).normalized * speed;
        var rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }

    //Waits till timer is out then destroys the bullet 
    private IEnumerator Death()
    {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }
}