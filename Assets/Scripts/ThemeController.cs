using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeController : MonoBehaviour
{
    public static ThemeController Instance;
    public List<ThemeItem> AllItems;

    public RectTransform ToggleImg;
    public Color DarkTheme;
    public Color LightTheme;

    public float circleXPos = 55f;
    bool IsDarkTheme = true;

    private void Start()
    {
        Instance = this;
        SetTheme();
    }
    void SetTheme()
    {
        for (int i = 0; i < AllItems.Count; i++)
        {
            if (RefManager.Instance.GetThemeID("Theme") == 0)
            {
                AllItems[i].SetTheme(DarkTheme);
                IsDarkTheme = true;
                ToggleImg.localPosition = new Vector3(-circleXPos, ToggleImg.localPosition.y, ToggleImg.localPosition.z);
            }
            else
            {
                AllItems[i].SetTheme(LightTheme);
                IsDarkTheme = false;
                ToggleImg.localPosition = new Vector3(circleXPos, ToggleImg.localPosition.y, ToggleImg.localPosition.z);
            }
        }
    }
    public void OnThemeButtonClick()
    {
        if (IsDarkTheme)
        {
            RefManager.Instance.SetThemeID("Theme", 1);
            SetTheme();
        }
        else
        {
            RefManager.Instance.SetThemeID("Theme", 0);
            SetTheme();
        }
    }
}
