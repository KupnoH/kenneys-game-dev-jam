using UnityEngine;
using UnityEngine.UI;

public class CrewHealth : MonoBehaviour
{
    public Image crewHealthBarFill;
    public Text crewHealthText;

    // Setthe max health value
    public float maxHealth = 250f;

    private float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateCrewHealthBar();
    }

    public void SetCrew(float crewDamage)
    {
        currentHealth -= crewDamage;
        UpdateCrewHealthBar();
    }

    private void UpdateCrewHealthBar()
    {
        float fillAmount = currentHealth / maxHealth;
        crewHealthBarFill.fillAmount = fillAmount;
        crewHealthText.text = "Health: " + currentHealth.ToString("0");
    }
}