using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(33, 90, 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
