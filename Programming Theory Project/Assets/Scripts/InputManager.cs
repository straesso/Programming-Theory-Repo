using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                Transform hitTransform = hit.transform;
                switch (hit.transform.tag)
                {
                    case "Sphere":
                        hitTransform.GetComponent<Sphere>().DisplayText();
                        break;
                    case "Capsule":
                        hitTransform.GetComponent<Capsule>().DisplayText();
                        break;
                    case "Cube":
                        hitTransform.GetComponent<Cube>().DisplayText();
                        break;
                    case "Cylinder":
                        hitTransform.GetComponent<Cylinder>().DisplayText();
                        break;
                }
            }
        }
    }
}
