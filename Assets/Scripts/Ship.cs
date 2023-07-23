using UnityEngine;

public class Ship : MonoBehaviour
{
    public static int Health = 100;
    public static int Speed = 0;
    ShipHealth shipHealth;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        shipHealth = GetComponent<ShipHealth>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Land"))
        {
            if (rb.velocity.magnitude > 10)
                shipHealth.GetDamage(10);
            else
                shipHealth.GetDamage(1);
            if (Health <= 0)
            {
                // Game over
            }
        }
    }
}
