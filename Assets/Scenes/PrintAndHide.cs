using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    private int num;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name+":"+i);
        
        if (i == 100 && gameObject.tag == "Red")
        {
            gameObject.SetActive(false);
        }
        if ( i == num && gameObject.tag == "Blue")
        {
            rend.enabled = false;
        }
    }
}
