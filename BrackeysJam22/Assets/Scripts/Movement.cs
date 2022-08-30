using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    private SpriteRenderer sr;
    public float jumpVelocity = 40f;
    public float moveSpeed = 10f;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }

        HandleMovement();
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, layerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }

    private void HandleMovement() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
            sr.flipX = false;
        } else {
            if (Input.GetKey(KeyCode.RightArrow)) {
                rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
                sr.flipX = true;
            } else {
                rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
            }
        }
    }
}