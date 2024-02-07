using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square3 : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.OnPushMe.AddListener(Destruccion);
    }

    private void Destruccion()
    {
        Destroy(this.gameObject);
    }
}
