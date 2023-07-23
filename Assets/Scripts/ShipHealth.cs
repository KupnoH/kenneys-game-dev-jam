using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth = 100f;


    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text healthText;
    public Image[] images;

    void Start()
    {
        currentHealth = maxHealth;

        SetMaxHealth(maxHealth);
        UpdateHealthBar();
        images = GetComponentsInChildren<Image>();
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = 1;
        slider.value = 1;
        fill.color = gradient.Evaluate(1f);
    }
    public void GetDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        slider.value = (currentHealth / maxHealth);
        fill.color = gradient.Evaluate(slider.normalizedValue);
        healthText.text = "Health: " + currentHealth.ToString();
    }


}
