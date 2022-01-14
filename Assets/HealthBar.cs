using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform bar;
    public Image HPBar;
    void Start()
    {
        bar = transform.Find("Bar");
    }

    // Update is called once per frame
    public void SetSize(float sizeNormalalized)
    {
        // bar.localScale = new Vector3(sizeNormalalized, 1f);
        HPBar.fillAmount = sizeNormalalized;
    }
}
