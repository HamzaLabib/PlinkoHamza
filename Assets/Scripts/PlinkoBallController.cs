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
            if (Input.GetKey(KeyCode.LeftArrow))
                rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.useGravity = true;
            isFalling = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
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
