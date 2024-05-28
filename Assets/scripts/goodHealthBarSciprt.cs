using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goodHealthBarSciprt : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public void setHealth(int health)
    {
        slider.value = health;
    }
    public void SetMaxHealth(int health)
    {
        slider.value = health;
        slider.maxValue = health;
    }
}
