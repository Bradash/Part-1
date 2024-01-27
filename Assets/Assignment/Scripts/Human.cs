using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public int humanSpeed = 100;
    Vector2 direction;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        //On the rigidbody Vector2 is controlling both components and humanSpeed multiplies it.
        rigidbody.AddForce(direction * Time.deltaTime * humanSpeed);
    }

}
