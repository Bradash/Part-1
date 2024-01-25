using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class Car : MonoBehaviour
{
    public float steeringSpeed;
    public float forwardSpeed;
    public float maxSpeed;
    float steering;
    float acceleration;


    Vector2 force;

    public Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()   
    {
        rigidbody = GetComponent<Rigidbody2D>();

        steeringSpeed = 200;
        forwardSpeed = 500;
        maxSpeed = 1000;
        

    }
    
    // Update is called once per frame
    void Update()
    {

        steering = - (Input.GetAxis("Horizontal"));
        acceleration = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steeringSpeed * steering * Time.deltaTime);

        force.y = acceleration * forwardSpeed;
        rigidbody.AddRelativeForce(force * Time.deltaTime);

        //Don't accelerate if we're already at top speed :P
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddRelativeForce(force * Time.deltaTime);
        }
    }
}
