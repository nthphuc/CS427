using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 50f, maxspeed = 3, jumpPow = 220f;
    private bool grounded = true;
    private Rigidbody2D r2;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
                r2.AddForce(Vector2.up * jumpPow);
        }
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);
        if (r2.velocity.x > maxspeed) r2.velocity = new Vector2(maxspeed, r2.position.y);
        if (r2.velocity.x < -maxspeed) r2.velocity = new Vector2(-maxspeed, r2.position.y);
    }
}
