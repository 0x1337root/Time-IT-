using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    Renderer firstColor;

    Color32 objectColor;

    static Color32 yellow = new Color32(255, 255, 0, 255);

    static Color32 purple = new Color32(116, 1, 238, 255);

    static Color32 green = new Color32(7, 197, 0, 255);

    List<Color32> colours = new List<Color32>{yellow, purple, green};

    int number;

    void Start()
    {
        firstColor = GetComponent<MeshRenderer>();
        firstColor.material.color = RandomColorPicker();
    }

    void OnTriggerEnter(Collider other)
    {
        objectColor = other.GetComponent<MeshRenderer>().material.color;

        if (firstColor.material.color.Equals(objectColor))
        {
            ChangeColor();
        }
    }
    
    void ChangeColor()
    {
        firstColor.material.color = RandomColorPicker();
    }

    Color RandomColorPicker()
    {
        number = Random.Range(0, 3);
        return colours[number];
    }
}
