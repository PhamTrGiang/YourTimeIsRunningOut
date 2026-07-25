using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Required Data", menuName = "Scriptable Objects/New Required Data", order = 0)]
public class Required : ScriptableObject
{
    public string content;
    public List<HiddenTag> allTags;
}
