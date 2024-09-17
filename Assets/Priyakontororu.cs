using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priyakontororu : MonoBehaviour
{
    public GameObject da;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.01f, 0, 0);
        }
      if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.01f, 0,0);
        }
      if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(da, transform.position, Quaternion.identity);
        }
    }
}
