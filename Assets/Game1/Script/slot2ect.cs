using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot2ect : MonoBehaviour
{
    public GameObject item1, item2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (selectgame.itemect[0] == 1)
        {
            item1.SetActive(true);
            item2.SetActive(false);
        }
        if (selectgame.itemect[0] == 2)
        {
            item1.SetActive(false);
            item2.SetActive(true);
        }
    }
}
