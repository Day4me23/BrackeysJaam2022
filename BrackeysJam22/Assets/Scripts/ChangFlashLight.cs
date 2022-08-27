using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ChangFlashLight : MonoBehaviour
{
    public Light2D light;
    bool isUnderGround = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (!isUnderGround)
            {
                light.color = Color.magenta;
                isUnderGround = true;
            }
            else
            {
                light.color = Color.white;
                isUnderGround = false;
            }

        }
    }
}
