using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TTTTT : MonoBehaviour
{
    private int health = 10;
    public AudioClip damageSound;
    public AudioSource source;
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            source.PlayOneShot(damageSound);
            print("Здоровье игрока: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
