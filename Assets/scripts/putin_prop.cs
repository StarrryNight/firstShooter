using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putin_prop : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth = 100;
    public healthBarSript hab;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hab.SetMaxHealth(maxHealth);
    }

    // Update is called      Debug.Log("hi");
        
    void Update()
    {
           
    }
    
    public void takeDamage(int damage)
    {
        Debug.Log("hi");
        currentHealth -=damage;

        hab.setHealth(currentHealth);
    }
    


}
