using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    string text;
    int year;
    public GameObject inputField;
    public GameObject inputFieldAge;
    public GameObject displayField;
    public GameObject imageHolder;
    public GameObject scroll;
    public Sprite[] spriteArray;


    public void getText()
    {
        int year = int.Parse(inputFieldAge.GetComponent<Text>().text);

        if (year < 1924 || year > 2024)
        {
            displayField.GetComponent<Text>().text = "Lūdzu, ievadiet gadu no 1924 līdz 2024";
            return;
        }

        int age = 2024 - year;
        string text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = "Sveiki, " + text + "! Tev ir " + age + " gadi";
    }

    public void changeHero(int index)
    {
        imageHolder.GetComponent<Image>().sprite = spriteArray[index];
        if (index == 0)
            scroll.GetComponent<Text>().text = "Female Wretch is a starting Class in Elden Ring. The Wretch is the “deprived” of the game. It starts at level 1 with 10 on all stats and just a club for weapons. It is the weakest starting Class in Elden Ring, and should be selected by those who want an added challenge in the earlier parts of the game. The Classes only determine the starting Stats and Equipment of the player, but as the game progresses, players can freely change their build to their preferred playstyle.";
        else if (index == 1)
            scroll.GetComponent<Text>().text = "Male Wretch is a starting Class in Elden Ring. The Wretch is the “deprived” of the game. It starts at level 1 with 10 on all stats and just a club for weapons. It is the weakest starting Class in Elden Ring, and should be selected by those who want an added challenge in the earlier parts of the game. The Classes only determine the starting Stats and Equipment of the player, but as the game progresses, players can freely change their build to their preferred playstyle.";

    }
}