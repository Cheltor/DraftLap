using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has crossed the finish line!");
            // Add code to end the game or display a victory screen
        }
    }
}
