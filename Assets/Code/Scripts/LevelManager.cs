using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform[] path;
    public Transform startPoint;

    public int currency;

    public int lives;
    public void Awake()
    {
        main = this;
    }

    private void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Start()
    {
        currency = 100;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }
    public bool SpendCurrency(int amount)
    {
        if (amount <= currency)
        {
            currency -= amount;
            return true;
        }
        else
        {
            Debug.Log("dont have enough money");
            return false;
        }
    }
}
