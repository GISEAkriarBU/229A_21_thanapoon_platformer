using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image healthFillImage;
    public void SetMaxHealth(int maxHealth)
    {
        healthFillImage.fillAmount = 1;
    }

    public void SetHealth(int currentHealth, int maxHealth)
    {
        healthFillImage.fillAmount = (float)currentHealth / maxHealth;
    }
}
