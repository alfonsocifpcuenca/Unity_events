using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square1 : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.OnPushMe.AddListener(CambiarColor);
    }

    private void CambiarColor()
    {
        var spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.green;
    }
}
