using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{

    protected override void OnStart()
    {
        _name = "Sphere";
        _colorName = "red";
        _material = transform.GetComponent<MeshRenderer>().material;
        _materialName = _material.name;
    }

    public override void DisplayText()
    {
        UIManager.Instance.DisplayText("This is a " + _name + " with color " + _colorName + "and material " + _materialName);
    }
}