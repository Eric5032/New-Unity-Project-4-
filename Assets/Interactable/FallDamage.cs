using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FallDamage : MonoBehaviour
{
    [System.Serializable]
    public class DamagingEvent:UnityEvent<float>{}
    public DamagingEvent OnFallDamage;
    public float MinimumFallHeight = 0;
    public float moveSpeed, jumpForce;

    private Animator anim;
    private Rigidbody rb;
    private CharacterController Controller;
    private float LastGroundY = 0;
    private bool isAirborne = false;
    float x, y;
    bool jumping;

    // Start is called before the first frame update
    private void Start()
    {
        // rb = GetComponent<Rigidbody>();
        // anim = GetComponent<Animator>();
        LastGroundY = -1000;
        Controller = GetComponent<CharacterController>();
        isAirborne = !Controller.isGrounded;
    }

    // Update is called once per frame
    void Update()
    {
        if(isAirborne && Controller.isGrounded)
        {
            print(LastGroundY - this.transform.position.y);
            if(LastGroundY - this.transform.position.y > MinimumFallHeight)
            {
                print("Damaged");
                TakeFallDamage(LastGroundY - this.transform.position.y);
            }
        }
        // x = Input.GetAxisRaw("Horizontal");
        // y = rb.velocity.y;

        // anim.SetFloat("xVelocity", x);
        // anim.SetFloat("yVelocity", y);
        if(Controller.isGrounded)
        {
            LastGroundY = this.transform.position.y;
        }
        isAirborne = !Controller.isGrounded;
    }

    private void FixedUpdate()
    {
        
        
    }

    public void TakeFallDamage(float FallDamage)
    {
        OnFallDamage?.Invoke(FallDamage);
    }
}
