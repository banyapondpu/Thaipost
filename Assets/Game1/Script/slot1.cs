﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot1 : MonoBehaviour {
    public GameObject item1, item2, item3, item4, item5, item6, item7, item8;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (selectgame.item[1]==1)
        {
            item1.SetActive(true);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(false);
            item7.SetActive(false);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 2)
        {
            item1.SetActive(false);
            item2.SetActive(true);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(false);
            item7.SetActive(false);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 3)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(true);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(false);
            item7.SetActive(false);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 4)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(true);
            item5.SetActive(false);
            item6.SetActive(false);
            item7.SetActive(false);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 5)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(true);
            item6.SetActive(false);
            item7.SetActive(false);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 6)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(true);
            item7.SetActive(false);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 7)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(false);
            item7.SetActive(true);
            item8.SetActive(false);
        }
        if (selectgame.item[1] == 8)
        {
            item1.SetActive(false);
            item2.SetActive(false);
            item3.SetActive(false);
            item4.SetActive(false);
            item5.SetActive(false);
            item6.SetActive(false);
            item7.SetActive(false);
            item8.SetActive(true);
        }
    }
}
