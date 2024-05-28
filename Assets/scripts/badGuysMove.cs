using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuysMove : MonoBehaviour
{

    public Transform selfTransform;
    Rigidbody2D rb;
    public Transform putinTransform;
    public int speed;
    public GameObject putin;
    int hi = 0;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (selfTransform.position.y < 8)
        {
            hi = 69;
        }
        else if (selfTransform.position.x < 0)
        {
            hi = 0;
        }
        else { hi = 1; }
    }

    // Update is called once per frame
    void Update()
    {
        if (x == 0) { 
        if (hi == 0)
        {

            if (putinTransform.position.x - selfTransform.position.x > 4)
            {

                rb.velocity = transform.right * speed;
            }
            else
            {
                rb.velocity = transform.right * 0;
                selfTransform.parent = putin.transform;
                    Debug.Log("Destoryed");
                Destroy(rb);
                x = 1;

            }
        }
        else if (hi==1)
        {
            if (putinTransform.position.x - selfTransform.position.x < -4)
            {
                Debug.Log("as3");
                rb.velocity = -transform.right * speed;
            }
            else
            {
                rb.velocity = transform.right * 0;
                selfTransform.parent = putin.transform;
                Destroy(rb);
                x = 1;
                    Debug.Log("Destoryed");
                }
        }

        }
    }

    public void check(GameObject friendInstance)
    {
        while (x == 0)
        {
            if (hi == 0)
            {

                if (putinTransform.position.x - selfTransform.position.x > 4)
                {

                    rb.velocity = transform.right * speed;
                }
                else
                {
                    rb.velocity = transform.right * 0;
                    selfTransform.parent = putin.transform;
                    Destroy(friendInstance.GetComponent<Rigidbody>());
                    x = 1;

                }
            }
            else
            {
                if (putinTransform.position.x - selfTransform.position.x < -4)
                {
                    Debug.Log("as3");
                    rb.velocity = -transform.right * speed;
                }
                else
                {
                    rb.velocity = transform.right * 0;
                    selfTransform.parent = putin.transform;
                    Destroy(friendInstance.GetComponent<Rigidbody>());
                    x = 1;
                }
            }
        }
    }

    public void reduceSpeed()
    {
        speed = 20;
        StartCoroutine(reduce());
    }

    IEnumerator reduce()
    {
        yield return new WaitForSeconds(0.3f);
        speed = 14;
        yield return new WaitForSeconds(0.3f);
        speed = 7;
            yield return new WaitForSeconds(0.3f);
        speed = 3;
    }
}
