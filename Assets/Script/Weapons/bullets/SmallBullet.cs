using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody2D rb;
    public int damage = 20;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        takeDamage enemy = hitInfo.GetComponent<takeDamage>();
        if (enemy != null)
        {
            enemy.Hit(damage);
        }
        Destroy(gameObject);
    }
}
