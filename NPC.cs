using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 100;
    public int level = 3;
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Жизни" + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
