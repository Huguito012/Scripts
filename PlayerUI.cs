using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    private void Update()
    {
        healthSlider.maxValue = player.MaxHealth;
        healthSlider.value = player.health;

        coinsCounterText.text = player.coins.ToString();
    }
}
