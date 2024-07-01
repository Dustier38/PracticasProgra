using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToppingController : MonoBehaviour
{
    private TMP_Dropdown toppingOptions;
    public Image Topping;

    public Sprite[] toppingBase;

    void Start()
    {
        toppingOptions = GetComponent<TMP_Dropdown>();
        Topping = GameObject.Find("Topping").GetComponent<Image>();
    }

    public void ChangeTopping()
    {
        switch (toppingOptions.value)
        {
            case 0:
                Topping.sprite = toppingBase[0]; // Fresas
                break;
            case 1:
                Topping.sprite = toppingBase[1]; // Chispas de chocolate
                break;
            case 2:
                Topping.sprite = toppingBase[2]; // Moras
                break;
        }
    }
}

