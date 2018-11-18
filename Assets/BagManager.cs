using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BagManager : MonoBehaviour {

    public List<ConsumableItem> BagItems;

    public GameObject ItemPrefab;

    public Transform BagContainer;

    public InputField ItemsSearch;

	// Use this for initialization
	void Start () {

        ShowItemList(BagItems);

        ItemsSearch.onValueChanged.AddListener((query) =>
        {
            if(string.IsNullOrEmpty(query.Trim()))
            {
                ShowItemList(BagItems);
                return;
            }

            ShowItemList(BagItems.Where(x => x.Name.Trim().ToLower().Contains(query.ToLower())).ToList());

        });

    }
	
	void ShowItemList(List<ConsumableItem> list)
    {

        foreach (Transform child in BagContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (var item in list)
        {
            var tmp = Instantiate(ItemPrefab, BagContainer);

            tmp.transform.GetChild(0).GetComponent<ItemController>().ConsumableItemData = item;
            tmp.transform.GetChild(0).GetComponent<ItemController>().SetItemSettings(() =>
            {
                Destroy(tmp);
                BagItems.Remove(item);
            });
        }
    }


}
