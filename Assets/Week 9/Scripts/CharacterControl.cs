using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public List<Villager> villagerList = new List<Villager>(); //open up the list
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;
    float interpolation;
    private void Start()
    {
        Instance = this;
    }
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }

    public void Selected(Int32 value)
    {
        SetSelectedVillager(villagerList[value]);
    }

    public void Scale (Single scale)
    {
        if (SelectedVillager != null)
        {
            SelectedVillager.transform.localScale = Vector3.one * scale; //size changes but there is a weird bug that doesnt allow it to stay, not sure how to fix it
        }
    }
}
