using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour {

    public ConsumableItem ConsumableItemData;

    Image Icon;
    Button ItemButton;
    Action OnRemove;

    // Use this for initialization
    void Start()
    {
        SetItemSettings();
    }

    public void SetItemSettings()
    {
        ItemButton = GetComponent<Button>();
        Icon = ItemButton.image;

        Icon.sprite = ConsumableItemData.Icon;

        ItemButton.onClick.AddListener(() =>
        {

            ConsumableItemData.Consume();

            Destroy(this.transform.parent.gameObject);

        });
    }

    public void SetItemSettings(Action OnRemove)
    {
        this.OnRemove = OnRemove;
        ItemButton = GetComponent<Button>();
        Icon = ItemButton.image;

        Icon.sprite = ConsumableItemData.Icon;

        ItemButton.onClick.AddListener(() =>
        {

            ConsumableItemData.Consume();

            OnRemove.Invoke();

        });
    }

}
