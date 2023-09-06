using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private List<Image> icons = new List<Image> ();
    [SerializeField] private List<Text> nameItem = new List<Text> ();
    [SerializeField] private List<Text> description = new List<Text>();

    private bool isObjectVisible = true; // Флаг для отслеживания видимости объекта

    public void ToggleObjectVisibility()
    {
        isObjectVisible = !isObjectVisible;
        gameObject.SetActive(false);
    }
    public void UpdateUI(Inventory inventory)
    {
        for(int i = 0; i < inventory.GetSize() && i < icons.Count; i++)
        {
            icons[i].color = new Color(1, 1, 1, 1);

            icons[i].sprite = inventory.GetItem(i).icon;
            nameItem[i].text = inventory.GetItem(i).name;
            description[i].text = inventory.GetItem(i).description;
        }

        for(int i = inventory.GetSize(); i< icons.Count; i++)
        {
            icons[i].color = new Color (1, 1, 1, 0);

            icons[i].sprite = null;
            nameItem[i].text = null;
            description[i].text = null;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            gameObject.SetActive(false);
        }
    }

}
