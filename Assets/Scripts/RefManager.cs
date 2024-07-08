using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefManager : MonoBehaviour
{
    public static RefManager Instance;
    private void Start()
    {
        Instance = this;
    }
    public void SetThemeID(string Name, int ID)
    {
        PlayerPrefs.SetInt(Name, ID);
        PlayerPrefs.Save();
    }
    public int GetThemeID(string Name)
    {
        return PlayerPrefs.GetInt(Name, 0);
    }
}
