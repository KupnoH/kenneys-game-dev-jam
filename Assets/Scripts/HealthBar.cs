using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarFill;
    public Text healthText;

    // Setthe max health value
    public float maxHealth = 100f;

    private float currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void SetHealth(float health)
    {
        // currentHealth = Mathf.Clamp(health, 0f, maxHealth);
        currentHealth -= health;
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        float fillAmount = currentHealth / maxHealth;
        healthBarFill.fillAmount = fillAmount;
        healthText.text = "Health: " + currentHealth.ToString("0");
    }
}
