﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 20;


    public static int Rounds;


    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        Rounds = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
