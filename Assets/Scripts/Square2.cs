using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square2 : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.OnPushMe.AddListener(Mover);
    }

    private void Mover()
    {
        Vector3 actualPosition = this.transform.position;

        this.transform.position = actualPosition + (Vector3.left * 5);
    }
}
