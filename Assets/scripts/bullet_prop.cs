using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_prop : MonoBehaviour
{
    public GameObject bullet;
    public  Rigidbody2D rb;
    public int speed = 10;
   
    public int damage = 20;
    public putin_prop putin;
    public float cooldown;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        putin = GameObject.Find("bad").GetComponent<putin_prop>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "DestroyBullet" || col.gameObject.tag == "putin")
        {
            Debug.Log("yes");
            Destroy(bullet);
        }
        if (col.gameObject.tag == "putin")
        {
            putin.takeDamage(damage);
        }
    }
}
