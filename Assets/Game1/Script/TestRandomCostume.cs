using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestRandomCostume : MonoBehaviour {
    public  static int[] item;
    // Use this for initialization
    void Start()
    {
        randomitem();
    }
        // Update is called once per frame
        public void randomitem() {
        int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        item = numbers.OrderBy(keySelector: n => Guid.NewGuid()).ToArray();
    }
    }
