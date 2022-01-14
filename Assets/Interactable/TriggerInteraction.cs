using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TriggerInteraction : MonoBehaviour
{
    public UnityEvent OnTrigger;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        print("TriggerEnter");
        if(other.CompareTag("Player"))
        {
            OnTrigger?.Invoke();
        }
    }

}
