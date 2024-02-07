using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.Instance.OnPushMe.Invoke();
    }
}
