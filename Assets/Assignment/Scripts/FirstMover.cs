using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirstMover : MonoBehaviour
{
    public int squareSpeed = 10;
    int spin = 1;
    Vector3 rotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //spin is changed to 100 when the Trigger is entered
    private void OnTriggerEnter2D()
    {
        spin = 100;

    }
    //spin is changed to 0 when the Trigger is exited
    private void OnTriggerExit2D()
    {

        spin = 1;

    }
    // Update is called once per frame
    void Update()
    {
        rotator.z = Input.GetAxis("Horizontal") + Input.GetAxis("Vertical");
        
        //Rotation is controlled by a Vector3. On the Z axis Inputs from Horizontal and Vertical control it.
        //squareSpeed a public int that will multiply it's speed
        transform.Rotate(rotator, Time.deltaTime * squareSpeed * spin);
    }
}
