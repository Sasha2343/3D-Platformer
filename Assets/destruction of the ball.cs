using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructionoftheball : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null )
        {
            Destroy(enemy.gameObject);
        }
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
