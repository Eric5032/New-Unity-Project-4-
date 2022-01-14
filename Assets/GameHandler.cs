using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] Vector3 EnterPosition, ExitPostion;
    public float FallDamageDistance = 2;
    public float DamageAmount = 5;
    [SerializeField] private HealthBar healthBar;
    private float CurrentHealth = 100;
    // Start is called before the first frame update
    private void Start()
    {
        EnterPosition = this.transform.position;
        ExitPostion = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void TakeDamage(float Damage)
    {
        CurrentHealth -= Damage;
        healthBar.SetSize(CurrentHealth/100.0f);
    }
    void OnTriggerEnter(Collider other)
    {
        print(other);
        if(other.gameObject.CompareTag("ground"))
        {
            EnterPosition = this.transform.position;

            if(ExitPostion.y - EnterPosition.y > FallDamageDistance)
            {
                //to do add player take damage
                TakeDamage(DamageAmount*(ExitPostion.y - EnterPosition.y)/FallDamageDistance);
        
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            ExitPostion = this.transform.position;
        }
    }
}
