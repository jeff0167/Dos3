using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        rb.velocity *= -1;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Projectile")) Destroy(gameObject);
    }
}
