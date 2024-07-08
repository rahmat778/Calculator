using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ThemeItem : MonoBehaviour
{
    public Image ItemImg;
    public Color DarkTheme;
    public Color LightTheme;
    public bool HasText = false;

    public void SetTheme(bool IsDark)
    {
        if (HasText)
        {
            if (IsDark)
            {
                this.GetComponent<TextMeshProUGUI>().color = LightTheme;
            }
            else
            {
                this.GetComponent<TextMeshProUGUI>().color = DarkTheme;
            }
            return;
        }

        if (IsDark)
        {
            ItemImg.color = DarkTheme;
        }
        else
        {
            ItemImg.color = LightTheme;
        }
    }
}
