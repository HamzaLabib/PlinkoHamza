using UnityEngine;

public class PlinkoBallController : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;
    
    public AudioSource ballBouncing;
    public AudioSource loserMusic;
    public AudioSource winnerMusic;

    public bool isFalling = false;
    public bool isEnded = false;
    
    private void Update()
    {
        GetControllers();
    }

    void GetControllers()
    {
        if (!isFalling)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
            if (Input.GetKeyUp(KeyCode.RightArrow))
                DampenXRight(); // to stop the ball instantly
            if (Input.GetKey(KeyCode.LeftArrow))
                rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
            if (Input.GetKeyUp(KeyCode.LeftArrow))
                DampenXleft();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.useGravity = true;
            isFalling = true;
        }
    }

    void DampenXleft()
    {
        if (rb.velocity.x < 0)
            rb.AddForce(-rb.velocity.x , 0, 0, ForceMode.Impulse);
    }

    void DampenXRight()
    {
        if (rb.velocity.x > 0)
            rb.AddForce(-rb.velocity.x , 0, 0, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.freezeRotation = true;

        if (other.tag == "Goal")
            winnerMusic.enabled = true;
        else
            loserMusic.enabled = true;

        isEnded = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Hit")
            ballBouncing.Play();
    }
}
