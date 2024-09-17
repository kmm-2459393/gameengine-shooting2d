using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hpsk : MonoBehaviour
{
    GameObject lmage;
    // Start is called before the first frame update
    void Start()
    {
        this.lmage = GameObject.Find("lmage");   
    }

    // Update is called once per frame
   public void DecreaseHp()
    {
        this.lmage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
