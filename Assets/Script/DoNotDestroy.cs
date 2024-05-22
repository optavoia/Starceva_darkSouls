using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private void Awake()
    {
        // Check if there are multiple instances of the GameObject with the "GameMusic" tag
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
            return;
        }

        // Ensure the GameObject is at the root level
        if (this.transform.parent != null)
        {
            this.transform.SetParent(null);
        }

        // Prevent the GameObject from being destroyed on scene load
        DontDestroyOnLoad(this.gameObject);
    }
}
