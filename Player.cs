using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins = 0;
    public AudioSource audiosource;
    public AudioClip coinSound;
    public AudioClip takeDamage;
    private int hp = 100;
    public int maxhp = 100;
    public GameObject fireballPrefab;
    public Transform attackPoint;


    public void ChangeCoins(int count_coins)
    {
        audiosource.PlayOneShot(coinSound);
        coins += count_coins;
        print("Кол-во монет:" + coins);
    }

    public void TakeDamage(int damage)
    {
        hp = hp - damage;
        print(hp + "здоровья");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    
    public int GetHp()
    {
        return hp;
    }
    public void SetHp(int newHp)
    {
        hp = newHp;
    }
    
}