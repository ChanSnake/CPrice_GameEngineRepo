using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            GameObject gamObject = Instantiate(prefab, transform);
        }
    }
}
