using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour
{
    Vector3 scaler;
    // Start is called before the first frame update
    void Start()
    {
        scaler.x = 1;
        scaler.y = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Everytime the orb is hit, the orb get's bigger.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Vector3 is used to affect all 3 components of the scale
        //f added to the end of the decimal to make it a float
        object value = transform.localScale += scaler*.1f;
    }
}
