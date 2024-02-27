using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private TextMeshProUGUI currencyUI;
    [SerializeField] private Animator anim;
    [SerializeField] private TextMeshProUGUI lives;

    private bool isMenuOpen = true;

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("MenuOpen",isMenuOpen);
    }

    private void OnGUI()
    {
        currencyUI.text = LevelManager.main.currency.ToString();
        lives.text = LevelManager.main.lives.ToString();
    }

    public void SetSelected()
    {
        
    }
}
