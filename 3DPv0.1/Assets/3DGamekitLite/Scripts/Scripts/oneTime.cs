using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic can be added here if needed
    }

    // This method is called when another collider enters the trigger collider attached to this GameObject
    void OnTriggerEnter(Collider other)
    {
        // Check if the other collider is tagged as "Player" (or any other condition you need)
        if (other.CompareTag("Untagged"))
        {
            // Destroy the GameObject this script is attached to
            Destroy(gameObject);
        }
    }
}
