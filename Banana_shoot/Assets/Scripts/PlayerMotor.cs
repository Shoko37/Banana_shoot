using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero;

    private Rigidbody rb;

    void Start()
    {
        rb = Getcomponent<Rigidbody>();
    }
    // Gets a movement vector
    public void Move (Vector3 _velocity)
    {
        velociy = _velociy;
    }
    // Run every physics iteration
    void FixedUpdate ()
        {
            PerformMovement();
        }
    

    // Perform movenent based on velocity variavle
    void PerformMovement ()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }


}
