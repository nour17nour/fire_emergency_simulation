using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguisher : MonoBehaviour
{
    public GameObject fireExtinguisher;

    // Start is called before the first frame update

    public void ShowFireExtinguisher()
    {
        fireExtinguisher.SetActive(true);
    }
}
