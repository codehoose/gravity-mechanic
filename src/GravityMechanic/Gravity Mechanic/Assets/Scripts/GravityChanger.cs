using UnityEngine;

public class GravityChanger : MonoBehaviour
{
    SpriteRenderer _sprite;

	void Awake ()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

	void Update ()
    {
	    if (Input.GetButtonDown("Fire1"))
        {
            _sprite.flipY = !_sprite.flipY;

            var tmp = Physics2D.gravity;
            tmp.y *= -1;
            Physics2D.gravity = tmp;
        }
	}
}
