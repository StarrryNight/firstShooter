using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadAttack : MonoBehaviour
{
    public Transform goodT;
    public Transform trans;
    public GameObject bulletPredab01;
    public GameObject bulletPredab02;
    public putin_prop putin;
    public putinAttack01BulletProp bullet01prop;
    Vector3 lowerPosition;
    int randomAttack = 0;
    public GameObject BadGuysPrefab;
    public badGuysMove badGuysScript;
    int callcount =0;
    
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(randomAtt());
        StartCoroutine(attack());
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((putin.currentHealth <= 75) && callcount == 0)
        {
            callcount = 1;
            callFriends();
            
        }
    }

    IEnumerator attack()
    { 
        while (1> 0)
        {
            if (randomAttack == 1)
            {
                Debug.Log("Attack 1");
                yield return new WaitForSeconds(0.5f);
                attack_01();
            }
            else if (randomAttack == 2)
            {
                Debug.Log("Attack 2");
                yield return new WaitForSeconds(0.8f);
                attack_02();
            }


        }
    }

    IEnumerator randomAtt()
    {
        while (1 > 0)
        {
            randomAttack = Random.Range(1, 3);
            yield return new WaitForSeconds(6f);
        }
    }

    void attack_01()
    {
        if (goodT.position.x > 0.05f)
        {
            for (float i = 50; i < 151; i += 25)
            {
                GameObject bulletInstance;
                // lowerPosition.Set(trans.position.x, trans.position.y - 2, trans.position.z);

                bulletInstance = Instantiate(bulletPredab01, trans.position, Quaternion.Euler(0f, 0f, i)) as GameObject;

                

            }
        }
        else
        {
            for (float i = 25; i < 126; i += 25)
            {
                GameObject bulletInstance;
                // lowerPosition.Set(trans.position.x, trans.position.y - 2, trans.position.z);

                bulletInstance = Instantiate(bulletPredab01, trans.position, Quaternion.Euler(0f, 0f, i)) as GameObject;

               

            }
        }
    }


    void attack_02()
    {
        for (float i = -45; i > -136; i -= 45)
        {
            GameObject bulletInstance;
            // lowerPosition.Set(trans.position.x, trans.position.y - 2, trans.position.z);

            bulletInstance = Instantiate(bulletPredab02, trans.position, Quaternion.Euler(0f, 0f, i)) as GameObject;

            
            StartCoroutine(Destroy1(bulletInstance));

        }

    }

    void callFriends()
    {
        GameObject FriendsInstance;
        GameObject FriendsInstance2;

        FriendsInstance = Instantiate(BadGuysPrefab, new Vector3(-19, 10, 0), BadGuysPrefab.transform.rotation) as GameObject;
        FriendsInstance2 = Instantiate(BadGuysPrefab, new Vector3(19, 10, 0), BadGuysPrefab.transform.rotation) as GameObject;

        StartCoroutine(Destroy2(FriendsInstance));
        StartCoroutine(Destroy2(FriendsInstance2));

        badGuysScript.reduceSpeed();
    }



    public IEnumerator WaitAndAdd(GameObject bulletInstance)
    {
        
        yield return new WaitForSeconds(0.5f);
        Debug.Log("ADDEd");
        BoxCollider2D bc = bulletInstance.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;

    }
    IEnumerator Destroy1(GameObject bulletInstance)
    {
        yield return new WaitForSeconds(7f);
        Destroy(bulletInstance);

    }

    IEnumerator Destroy2(GameObject bulletInstance)
    {
        yield return new WaitForSeconds(15f);
        Destroy(bulletInstance);

    }


}
