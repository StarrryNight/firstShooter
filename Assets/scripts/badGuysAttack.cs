using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuysAttack : MonoBehaviour
{

    public Transform goodT;
    public Transform trans;
    public GameObject badGuysBulletPredab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(attackI());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator attackI()
    {
        while (1 > 0)
        {
            
                
                yield return new WaitForSeconds(2f);
                attack();
            
           


        }
    }

    void attack()
    {
        if (goodT.position.x > 0.05f)
        {
            for (float i = 50; i < 151; i += 33)
            {
                GameObject bulletInstance;
                // lowerPosition.Set(trans.position.x, trans.position.y - 2, trans.position.z);

                bulletInstance = Instantiate(badGuysBulletPredab, trans.position, Quaternion.Euler(0f, 0f, i)) as GameObject;

               

            }
        }
        else
        {
            for (float i = 25; i <126; i+= 33)
            {
                GameObject bulletInstance;
                // lowerPosition.Set(trans.position.x, trans.position.y - 2, trans.position.z);

                bulletInstance = Instantiate(badGuysBulletPredab, trans.position, Quaternion.Euler(0f, 0f, i)) as GameObject;

               

            }
        }
    }
}
