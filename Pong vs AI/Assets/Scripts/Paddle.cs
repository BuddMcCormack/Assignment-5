using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D ridigbody;
    public float speed = 200.0f;

    private void Awake()
    {
        ridigbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
    }


    // Resets the paddle and adds a random starting velocity to the paddle
    public void ResetPosition()
    {
        ridigbody.position = Vector3.zero;
        ridigbody.velocity = Vector3.zero;

        AddStartupVelocity();
    }

    private void AddStartupVelocity()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        ridigbody.AddForce(direction * this.speed);
    }
}
