using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    string Hp;
    public int Hp_ = 100;
    public Color myColor;


    private void Update()
    {
        Hp = Hp_.ToString();
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 150, 150), Hp);

        myColor = RGBSlider(new Rect(50, 10, 200, 20), myColor);
    }

    Color RGBSlider(Rect screenRect, Color rgb)
    {
        rgb.r = LabelSlider(screenRect, rgb.r, 1.0f, "Red");
        screenRect.y += 20;
        rgb.g = LabelSlider(screenRect, rgb.g, 1.0f, "Green");
        screenRect.y += 20;
        rgb.b = LabelSlider(screenRect, rgb.b, 1.0f, "Blue");
        screenRect.y += 20;
        rgb.a = LabelSlider(screenRect, rgb.a, 1.0f, "Transparency");
        return rgb;
    }
    
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText)
    {
        GUI.Label(screenRect, labelText);
        screenRect.x += screenRect.width;
        sliderValue = GUI.HorizontalSlider(screenRect, sliderValue, 0.5f, sliderMaxValue);
        return sliderValue;
    }
}