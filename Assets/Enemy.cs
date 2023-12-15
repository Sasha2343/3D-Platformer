using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    // Start is called before the first frame update
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        TTTTT player = other.GetComponent<TTTTT>();
        player.TakeDamage(playerDamage);
    }
}
