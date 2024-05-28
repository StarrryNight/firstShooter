using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putinAttack01BulletProp : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed = 10;
    public Vector2 hi;
    public Good_prop good;
    public GameObject putinBullet1;
    int damage = 5;
    private IEnumerator coroutine;
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
        Debug.Log("afasfgewg");
        if(col.gameObject.tag == "DestroyBullet" || col.gameObject.tag == "good")
        {
            Debug.Log("yes");
            Destroy(putinBullet1);
        }
        if (col.gameObject.tag == "good")
        {
            good.takeDamage(damage);
        }
    }

    
 
}
