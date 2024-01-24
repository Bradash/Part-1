using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public float steeringSpeed;
public float forwardSpeed;
public float maxSpeed;
public class Car : MonoBehaviour
{
    Vector2 force;
    Rigidbody2D rigidbody2;
    // Start is called before the first frame update
    void Start()
        rigidbody2 = GetComponent<Rigidbody2D>();
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float steering = Input.GetAxis("Horizontal");
        float acceleration = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        Rigidbody.AddTorque(steeringSpeed + steering + Time.deltaTime);


            //Don't accelerate if we're already at top speed :P
if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }
    }
}
