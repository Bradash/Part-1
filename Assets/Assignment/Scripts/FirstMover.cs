using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMover : MonoBehaviour
{
    public int squareSpeed = 10;
    Vector3 rotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotator.z = Input.GetAxis("Horizontal");

        transform.Rotate(rotator, Time.deltaTime * squareSpeed);
    }
}
