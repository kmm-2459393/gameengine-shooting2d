using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danmakus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.02f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
}
