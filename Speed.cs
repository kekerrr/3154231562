using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float speed = 2.1f;
    Vector3 new_transform;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        new_transform = gameObject.transform.position;
        new_transform.z += speed * Time.deltaTime;
        new_transform.x += speed * Time.deltaTime;
        new_transform.y += speed * Time.deltaTime;
        gameObject.transform.position = new_transform;
    }
}
