using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public GameObject explosion;
    private float speed = 5f;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        print("123");
    }
    void OnDestroy()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void Start()
    {
        Destroy(gameObject, 3);
    }
}