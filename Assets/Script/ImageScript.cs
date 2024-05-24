using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject sizeSliderY;
    public GameObject sizeSliderX;
    public GameObject imageHolder;
    public Transform boundary; // точка, определ€юща€ границу

    public void changeSize()
    {
        // Get the size values from the sliders
        float sizeX = sizeSliderX.GetComponent<Slider>().value;
        float sizeY = sizeSliderY.GetComponent<Slider>().value;

        // Check the position of the imageHolder relative to the boundary
        if (imageHolder.transform.position.x > boundary.position.x)
        {
            // If it's on the right side, change its size
            imageHolder.transform.localScale = new Vector2(sizeX, sizeY);
        }
        // If it's on the left side, don't change its size
    }
}
