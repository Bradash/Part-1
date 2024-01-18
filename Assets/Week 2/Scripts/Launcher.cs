using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject missilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
