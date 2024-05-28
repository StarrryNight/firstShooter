using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putin_Move : MonoBehaviour
{
    int health = 1;
    int direction = 1;
    public int speed = 50;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
        StartCoroutine(MoveRandomly());

    }

    // Update is called once per frame
    void Update()
    {
        
        rb.velocity = new Vector2(direction * speed, 0);
       
    }


    

    IEnumerator MoveRandomly()
    {
        while (health > 0)
        {
            yield return new WaitForSeconds(Random.Range(1, 2));
            direction *= -1;
        }
    }
}
