using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private void Awake()
    {
        GameManager.Instance.OnPushMe.AddListener(Suscripcion);
    }

    private void Suscripcion()
    {
        var spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }
}
