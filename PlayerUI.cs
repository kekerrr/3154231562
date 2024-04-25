using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player playerScript;
    public Slider hpSlider;
    public Text coinCounter;

    void Start()
    {
        hpSlider.maxValue = playerScript.maxhp;
        coinCounter.text = playerScript.coins.ToString();
    }

    void Update()
    {
        hpSlider.value = playerScript.GetHp();
        coinCounter.text = playerScript.coins.ToString();
    }
}
