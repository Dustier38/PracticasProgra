using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlavorController : MonoBehaviour
{
    private TMP_Dropdown colorOptions;
    public Image Pastel;

    public Sprite[] flavorsBase;
    void Start()
    {
       colorOptions = GetComponent<TMP_Dropdown>();
        Pastel = GameObject.Find("Pastel").GetComponent<Image>();
    }

    public void ChangeFlavor()
    {
        switch (colorOptions.value)
        {
            case 0:
                Pastel.sprite = flavorsBase[0];
                break;
            case 1:
                Pastel.sprite = flavorsBase[1];
                break;
            case 2:
                Pastel.sprite = flavorsBase[2];
                break;
        }
    }
}
