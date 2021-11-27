using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCubeController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            GameManager.instance.FalseAnsverText();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Other")
        {
            GameManager.instance.TrueAnsverText();
            Destroy(collision.gameObject);
        }
    }
}
