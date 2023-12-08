using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wwwww : MonoBehaviour
{
    public float speedFactor = 2.5f;
    // Start is called before the first frame update
    void OnTriggerEnter (Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed -= speedFactor;
    }
}
