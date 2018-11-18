using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagButtonController : MonoBehaviour {

    bool isOpen = false;
    public GameObject BagUI;

	// Use this for initialization
	void Start () {

        isOpen = BagUI.activeInHierarchy;

        GetComponent<Button>().onClick.AddListener(() =>
        {
            if(!isOpen)
            {
                BagUI.SetActive(true);
                isOpen = true;
                return;
            }

            BagUI.SetActive(false);
            isOpen = false;
            return;


        });
	}

}
