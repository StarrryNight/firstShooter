using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class good_move : MonoBehaviour


{
    Rigidbody2D body;
    public int speed;
    public GameObject rocketPrefab;
    public Transform trans;
    float horizontal;
    public float cooldown;
    private float NextFire;
    public static int weaponNum;
    GameObject weaponPrefab;
    public GameObject circlePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        if (weaponNum ==0)
        {
            weaponPrefab = circlePrefab;
        }
        else if (weaponNum == 1)
        {
            weaponPrefab = rocketPrefab;
        }
        cooldown = weaponPrefab.GetComponent<bullet_prop>().cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Fire1") && Time.time > NextFire)
        {
            NextFire = Time.time + cooldown;
            GameObject rocketInstance;
            rocketInstance = Instantiate(weaponPrefab, trans.position, trans.rotation) as GameObject;
        
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal*speed, 0);
    }
}
