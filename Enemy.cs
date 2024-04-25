using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public int playerDamage = 5;
    public Transform target;

    
    private void OnTriggerEnter(Collider other)
    {
        Player x = other.GetComponent<Player>();
        x.TakeDamage(playerDamage);
    }

    void Update()
    {
        gameObject.transform.LookAt(target.position);
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.position, speed * Time.deltaTime);
    }
}
