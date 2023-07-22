using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldController : MonoBehaviour
{
    public Text gold;

    // Setthe max health value
    public float minGold = 0f;

    private float currentGold;
    
    // Start is called before the first frame update
    void Start()
    {
        currentGold = minGold;
        gold.text = "Gold: " + currentGold.ToString("0");
    }

    public void SetGold(float goldAmount)
    {
        // currentHealth = Mathf.Clamp(health, 0f, maxHealth);
        currentGold += goldAmount;
        gold.text = "Gold: " + currentGold.ToString("0");
    }
}
