using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset;

    private void Update()
    {
        if(FindObjectOfType<PlinkoBallController>().isFalling)
            transform.position = ball.position + offset;
    }
}
