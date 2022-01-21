using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingWater : MonoBehaviour
{
    public float maxHeight = 1;
    public float risingSpeed = 1;
    public List<WaterInfo>Checkpoints = new List<WaterInfo>();
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RunCheckPoints());
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y < maxHeight)
        {
            this.transform.position += Vector3.up * risingSpeed * Time.deltaTime;
        }
    }
    private IEnumerator RunCheckPoints()
    {
        foreach(WaterInfo info in Checkpoints)
        {
            maxHeight = info.maxHeight;
            risingSpeed = info.risingSpeed;
        
            yield return new WaitUntil(() =>this.transform.position.y >= maxHeight);
            yield return new WaitForSeconds(info.waittime);
        }
    }
}
[System.Serializable]
public class WaterInfo
{
    public float maxHeight;
    public float waittime;
    public float risingSpeed;
}