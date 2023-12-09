using UnityEngine;

public class AIBall : Balls
{
    public Rigidbody2D Paddle;

    private void FixedUpdate()
    {
        // AI which tries to block the ball from being scored on its goal
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

            // otherwise just hovers in the middle of its goal
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
