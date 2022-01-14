using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayController : MonoBehaviour
{
    public float Health = 100f;
    public Image healthBar;
    public GameObject GameScreen;

    public static bool gameOver;

    void Start()
    {
        gameOver = false;
    }
    void Update()
    {
        healthBar.fillAmount = Health/100.0f;
        if(Health < 0)
        {
            gameOver = true;
            GameScreen.SetActive(true);
        }
    }
    public void TakeDamage(float Damage)
    {
        Health -= Damage;
    }
}
