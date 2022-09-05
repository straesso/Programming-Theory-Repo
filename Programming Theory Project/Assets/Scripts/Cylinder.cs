using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE from class Shape
public class Cylinder : Shape
{
    // EXAMPLE for POLYMORPHYSM
    protected override void OnStart()
    {
        _name = "Cylinder";
        _colorName = "green";
        _material = transform.GetComponent<MeshRenderer>().material;
        _materialName = _material.name;
    }

    public override void DisplayText()
    {
        UIManager.Instance.DisplayText("This is a " + _name + " with color " + _colorName + " and material " + _materialName);
    }
}