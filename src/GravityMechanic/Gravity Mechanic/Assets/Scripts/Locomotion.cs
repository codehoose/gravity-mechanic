using UnityEngine;

public class Locomotion : MonoBehaviour
{
    Rigidbody2D _rb;
    float speed = 10f;
    float maxVel = 5f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var xdiff = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        if (Mathf.Abs(_rb.velocity.x) > maxVel)
        {
            var temp = _rb.velocity;
            temp.x = maxVel * Mathf.Sign(xdiff);
            _rb.velocity = temp;
            return;
        }

        _rb.AddForce(Vector2.right * xdiff, ForceMode2D.Impulse);
    }
}
