
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    //VARIABLES DE MONEDAS
    private int coins;
    public AudioSource audiosource;
    public AudioClip collectSound;
    public AudioClip damageSound;
    public GameObject fireballPrefab;
    public Transform attackPoint;


    //VARIABLES DE SALUD
    public int health = 100;
    public void CollectCoins()
    {
        coins++;

        audiosource.PlayOneShot(collectSound);

        print("Collected coins: " + coins);
    }

    //A method that lowers the player's health
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player health: " + health);

        if(health > 0)
        {
            audiosource.PlayOneShot(damageSound);
        }
        else
        {
            SceneManager.LoadScene("Game Over");
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);

        }
    }
}
