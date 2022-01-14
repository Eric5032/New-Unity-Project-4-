using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        ScoreText.coinAmount += 1;
        this.gameObject.SetActive(false);
    }
}
