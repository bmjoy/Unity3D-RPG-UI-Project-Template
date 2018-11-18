using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="AbilityObject" , menuName = "Create Object/Ability")]
public class Ability : ScriptableObject {

    public Sprite Icon;
    public string Name;
    public string Description;
    public float CoolDown;

    public virtual void OnUse()
    {
        Debug.Log("You have used " + Name);
    }
}
