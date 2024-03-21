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

    //private void Update()
    //{
    //    if(SelectedVillager != null)
    //    {
    //        currentSelection.text = SelectedVillager.GetType().ToString();
    //    }
    //}
}
