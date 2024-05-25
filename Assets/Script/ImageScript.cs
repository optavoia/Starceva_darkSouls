using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject armor1;
    public GameObject armor2;
    public GameObject armor3;
    public GameObject legs1;
    public GameObject legs2;
    public GameObject legs3;
    public GameObject head1;
    public GameObject head2;
    public GameObject head3;
    public GameObject weapon1;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject sizeSliderY;
    public GameObject sizeSliderX;
    public GameObject imageHolder;
    public Transform boundary;
    public Sprite[] spriteArray;

    public void showArmor1(bool value)
    {
        armor1.SetActive(value);
    }

    public void showArmor2(bool value)
    {
        armor2.SetActive(value);
    }

    public void showArmor3(bool value)
    {
        armor3.SetActive(value);
    }

    public void showLegs1(bool value)
    {
        legs1.SetActive(value);
    }

    public void showLegs2(bool value)
    {
        legs2.SetActive(value);
    }

    public void showLegs3(bool value)
    {
        legs3.SetActive(value);
    }

    public void showHead1(bool value)
    {
        head1.SetActive(value);
    }

    public void showHead2(bool value)
    {
        head2.SetActive(value);
    }

    public void showHead3(bool value)
    {
        head3.SetActive(value);
    }

    public void showWeapon1(bool value)
    {
        weapon1.SetActive(value);
    }

    public void showWeapon2(bool value)
    {
        weapon2.SetActive(value);
    }

    public void showWeapon3(bool value)
    {
        weapon3.SetActive(value);
    }


    public void changeSize()
    {
        
        float sizeX = sizeSliderX.GetComponent<Slider>().value;
        float sizeY = sizeSliderY.GetComponent<Slider>().value;

        
        if (imageHolder.transform.position.x > boundary.position.x)
        {
            
            imageHolder.transform.localScale = new Vector2(sizeX, sizeY);
        }
        
    }
}
