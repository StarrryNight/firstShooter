using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putinAttack2Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 10;
    public Good_prop good;
    public GameObject putinBullet2;
    int damage = 15;
    public Transform bulletTransform;
    int changing = 0;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
            rb.velocity = transform.right * speed;
        
       
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
       
    
        if (col.gameObject.tag == "DestroyBullet")
        {
            if (count <= 2)
            {
                speed *= -1;

                count+=1;
                Debug.Log(count);
            }
            
           
        }
        

        if (col.gameObject.tag == "good")
        {
        good.takeDamage(damage);
            Destroy(putinBullet2);
        }
    
        
        
    }


    
}
