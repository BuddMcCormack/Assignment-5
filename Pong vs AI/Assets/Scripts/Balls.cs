using UnityEngine;

public class Balls : MonoBehaviour
{
    protected Rigidbody2D ridigbody;
    public float speed = 10.0f;

    private void Awake()
    {
        ridigbody = GetComponent<Rigidbody2D>();
    }
}
