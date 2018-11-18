using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManaController : MonoBehaviour {

    public PlayerStats PlayerStats;

    public Image HealthBar;
    public Image ResourcesBar;

    public Text HealthValue;
    public Text ResourcesValue;


	void Start () {

    }
	
	void Update () {

        HealthValue.text = "Health : " + PlayerStats.CurrentHealth + " / " + PlayerStats.MaxHealth;
        ResourcesValue.text = "Resources : " + PlayerStats.CurrentResources + " / " + PlayerStats.MaxResouces;

        Debug.Log(PlayerStats.CurrentHealth);
        Debug.Log(PlayerStats.MaxHealth);

        HealthBar.GetComponent<RectTransform>().localScale = new Vector3( Mathf.Clamp01(PlayerStats.CurrentHealth / PlayerStats.MaxHealth), 1, 1);
        ResourcesBar.GetComponent<RectTransform>().localScale = new Vector3( Mathf.Clamp01(PlayerStats.CurrentResources / PlayerStats.MaxResouces), 1, 1);

    }
}
