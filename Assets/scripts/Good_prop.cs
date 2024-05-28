using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Good_prop : MonoBehaviour
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
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("losst");
        }
    }

    public void takeDamage(int damage)
    {
        Debug.Log("hi");
        currentHealth -= damage;

        hab.setHealth(currentHealth);
    }
}
