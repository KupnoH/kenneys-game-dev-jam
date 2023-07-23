using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private void Awake()
    {
        instance = this;
    }
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

    public void ChangeScore(float goldAmount)
    {
        // currentHealth = Mathf.Clamp(health, 0f, maxHealth);
        currentGold += goldAmount;
        gold.text = "Gold: " + currentGold.ToString("0");
    }
}
