using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageViewer : MonoBehaviour
{
    public List<Material> Materials;
    public GameObject screen;
    public int imageNum = 0;
    
    public void PreviousFunc()
    {
        if (imageNum >= 1)
        {
            imageNum--;
            screen.GetComponent<Renderer>().material = Materials[imageNum];
        }
    }

    public void NextFunc()
    {
        if (imageNum < Materials.Count -1)
        {
            imageNum++;
            screen.GetComponent<Renderer>().material = Materials[imageNum];
        }
    }
}
