using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour
{
    float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;


        if (transform.position.x <= -2.0f)
        {
            speed = -speed;
        }
        if (transform.position.x >= 2.0f)
        {
            speed = -speed;
        }
    }
}
