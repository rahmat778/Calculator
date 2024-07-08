using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeItem : MonoBehaviour
{
    public Image ItemImg;

    public void SetTheme(Color C)
    {
        ItemImg.color = C;
    }
}
