using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour , IDamageable
{
    
    public float speed = 1f;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    private void Update()
    {
        Vector2 posn= transform.position;

        posn.y += speed * Time.deltaTime;
        transform.position = posn;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();

        if (damageable != null)
        {
            // Call the TakeDamage method on the damageable object
           // damageable.TakeDamage(bullet.damage);
        }

        // Destroy the bullet regardless of whether it hit a damageable object or not
        Destroy(gameObject);
    }
    /*public void TakeDamage(float amount)
    {
        // Reduce the bullet's health by the amount of damage taken
        damage -= amount;

        // Destroy the bullet if its health reaches zero
        if (damage <= 0)
        {
            Destroy(gameObject);
        }
    }*/

}
