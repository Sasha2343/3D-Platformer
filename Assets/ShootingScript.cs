using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject fireball;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
        }
    }
}
