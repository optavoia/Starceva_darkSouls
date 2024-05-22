using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public Text nameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Без имени");
        nameText.text = "Привет, " + playerName;
    }
}
