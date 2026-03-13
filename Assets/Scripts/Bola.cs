using UnityEngine;

public class Bola : MonoBehaviour
{

    [SerializeField]private Rigidbody2D rb;
    private float vel = 5f;
    private Vector2 VelD;
    private float timer;
    private float velT;
    public int ponto1 = 0;
    public int ponto2 = 0;
    public AudioClip som1;
    public AudioClip som2;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        direcao();    
        rb.linearVelocity = VelD;
      
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        velT = timer;

       
    }
    private void direcao()
    {
        int x = Random.Range(0, 4);

        switch (x)
        {
            case 0:
                VelD = new Vector2(vel, vel);
                break;
            case 1:
                VelD = new Vector2(-vel, vel);
                break;
            case 2:
                VelD = new Vector2(vel, -vel);
                break;
            case 3:
                VelD = new Vector2(-vel, -vel);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("parede"))
        {
            AudioSource.PlayClipAtPoint(som2, transform.position);
            Debug.Log("colidiu com a parede");
        }
        if(collision.gameObject.CompareTag("ponto"))
        {
            ponto2 += 1;
            Debug.Log("ponto do player 1");
            AudioSource.PlayClipAtPoint(som1, transform.position);
            transform.position = new Vector2(-0.06f, 0.03f);
        }
        if(collision.gameObject.CompareTag("ponto2"))
        {
            ponto1 += 1;
            Debug.Log("ponto do player 2");
            AudioSource.PlayClipAtPoint(som1, transform.position);
            transform.position = new Vector2(-0.06f, 0.03f);
        }

    }
}