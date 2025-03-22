using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIArrowControls : MonoBehaviour
{
    [SerializeField]
    private GameObject _character;

    public void RotateLeft()
    {
        transform.rotation *= Quaternion.Euler(0, -20f, 0);
    }

    public void RotateRight()
    {
        transform.rotation *= Quaternion.Euler(0, 20f, 0);
    }
}
