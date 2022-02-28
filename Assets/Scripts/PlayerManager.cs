using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    float h,v;
    Rigidbody2D rb;
    public float moveSpeed;
    public GameObject Projectile;
    public GameObject FirePointR, FirePointL;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        if(Input.GetKeyDown(KeyCode.Space)) Shot();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(h,v).normalized * moveSpeed;
    }

    void Shot()
    {
        GameObject r = Instantiate<GameObject>(Projectile, FirePointR.transform.position, FirePointR.transform.rotation);
        GameObject l = Instantiate<GameObject>(Projectile, FirePointL.transform.position, FirePointL.transform.rotation);
    }
}
