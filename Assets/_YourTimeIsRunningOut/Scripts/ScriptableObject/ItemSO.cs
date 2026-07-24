using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Scriptable Objects/New Item Data", order = 0)]
public class ItemSO : ScriptableObject
{
    public Item itemName;
    public List<HiddenTag> allTags;
    public Sprite itemImg;
    public int itemPrice;
}
