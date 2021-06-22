using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Element", order = 1)]
public class Element : ScriptableObject
{
    public List<Element> weaknesses = new List<Element>();

    public List<Element> Strengths = new List<Element>();
}
