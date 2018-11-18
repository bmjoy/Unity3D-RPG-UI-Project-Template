using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    [SerializeField]
    private float _MaxHealth;

    public float MaxHealth {
        get
        {
            return _MaxHealth;
        }
        set
        {
            _MaxHealth = value;
        }
    }

    [SerializeField]
    private float _CurrentHealth;

    public float CurrentHealth
    {
        get
        {
            return _CurrentHealth;
        }
        set
        {
            _CurrentHealth = value;
        }
    }

    [SerializeField]
    private float _MaxResouces;

    public float MaxResouces
    {
        get
        {
            return _MaxResouces;
        }
        set
        {
            _MaxResouces = value;
        }
    }

    [SerializeField]
    private float _CurrentResources;

    public float CurrentResources
    {
        get
        {
            return _CurrentResources;
        }
        set
        {
            _CurrentResources = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
