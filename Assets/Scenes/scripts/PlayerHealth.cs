using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int, int> OnHealthChanged;

    [SerializeField] private int maxHealth = 100;

    private int currentHealth;
    public int MaxHealth => maxHealth;
    public int CurrentHealth => currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;

        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        Debug.Log($"HP: {currentHealth}");

        OnHealthChanged?.Invoke(currentHealth, maxHealth);
    }
}
