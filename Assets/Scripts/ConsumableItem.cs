using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemObject", menuName = "Create Object/Consumable Item")]
public class ConsumableItem : ScriptableObject {

    public string Name;
    public string Description;
    public Sprite Icon;

    public virtual void Consume()
    {
        Debug.Log("You have consumed " + Name);
    }
}
