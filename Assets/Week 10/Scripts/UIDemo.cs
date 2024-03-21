using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;
    public void SliderValueHasChanged(Single value) //can say float instead of single
    {
        interpolation = value;
    }

    public void DropdownHasChanged(Int32 value) //can say int instead of int32
    {
        Debug.Log(dropdown.options[value].text);
    }

    private void Update()
    {
        sr.color = Color.Lerp(start, end, (interpolation/60));
    }
}
