using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour {

    public Ability AbilityData;

    Image Icon;
    Button AbilityButton;

    float CurrentCooldown;

	// Use this for initialization
	void Start () {

        AbilityButton = GetComponent<Button>();
        Icon = AbilityButton.image;

        CurrentCooldown = AbilityData.CoolDown;
        Icon.sprite = AbilityData.Icon;

        AbilityButton.onClick.AddListener(() =>
        {
            AbilityButton.interactable = false;

            AbilityData.OnUse();

            StartCoroutine(setOnCoolDown());
        });
	}

    private IEnumerator setOnCoolDown()
    {
        CurrentCooldown = 0;

        while (CurrentCooldown < AbilityData.CoolDown)
        {
            CurrentCooldown += Time.deltaTime;

            Icon.fillAmount = (CurrentCooldown / AbilityData.CoolDown);

            yield return null;

        }

        Icon.fillAmount = 1;
        CurrentCooldown = AbilityData.CoolDown;
        AbilityButton.interactable = true;

        yield return null;
    }
}
