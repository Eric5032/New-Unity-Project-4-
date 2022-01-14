using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public static int coinAmount = 0;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        
    }
    void Update()
    {
        text.text = coinAmount.ToString() + " Points";
    }
}
