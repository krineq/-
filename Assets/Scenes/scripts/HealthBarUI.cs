using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text hpText;

    private void Start()
    {
        playerHealth.OnHealthChanged += UpdateUI;

        UpdateUI(playerHealth.CurrentHealth, playerHealth.MaxHealth);
    }

    private void UpdateUI(int current, int max)
    {
        slider.value = (float)current / max;

        hpText.text = $"{current} / {max}";
    }

    private void OnDestroy()
    {
        playerHealth.OnHealthChanged -= UpdateUI;
    }
}