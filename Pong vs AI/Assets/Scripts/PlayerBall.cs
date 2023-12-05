using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public float speed = 6f;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 movement = new Vector3();

        bool isHoldingUp = Input.GetKey(KeyCode.UpArrow);
        bool isHoldingDown = Input.GetKey(KeyCode.DownArrow);

        if (isHoldingUp)
            movement.y += speed;

        if (isHoldingDown)
            movement.y -= speed;

        transform.position += movement * Time.deltaTime;

    }
}
