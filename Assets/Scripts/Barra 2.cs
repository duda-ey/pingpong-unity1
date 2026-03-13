using UnityEngine;

public class Barra2 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float vel = 5f;
    [SerializeField] private Transform bola;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        float posB = bola.position.y - transform.position.y;

        if (posB > 0.5f)
        {
            rb.linearVelocity = new Vector2(0, vel);
        }
        else if (posB < -0.5f)
        {
            rb.linearVelocity = new Vector2(0, -vel);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
