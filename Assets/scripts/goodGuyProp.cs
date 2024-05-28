using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodGuyProp : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 100;
    public goodHealthBarSciprt hab;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hab.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

        hab.setHealth(currentHealth);
    }
}
