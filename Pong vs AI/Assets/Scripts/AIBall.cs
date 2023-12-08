using UnityEngine;

public class AIBall : Balls
{
    public Rigidbody2D Paddle;

    private void FixedUpdate()
    {
        if (this.Paddle.velocity.x > 0.0f)
        {
            if (this.Paddle.position.y > this.transform.position.y)
            {
                ridigbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.Paddle.position.y < this.transform.position.y)
            {
                ridigbody.AddForce(Vector2.down * this.speed);
            }
            else
            {
                if (this.transform.position.y > 0.0f)
                {
                    ridigbody.AddForce(Vector2.down * this.speed);
                }
                else if (this.transform.position.y < 0.0f)
                {
                    ridigbody.AddForce(Vector2.up * this.speed);
                }
            }
        }
    }
}
