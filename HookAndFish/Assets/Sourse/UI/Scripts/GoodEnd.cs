using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodEnd : MonoBehaviour
{
    public void TurnOnObject()
    {
        gameObject.SetActive(true);
    }

    // Метод для выключения объекта
    public void TurnOffObject()
    {
        gameObject.SetActive(false);
    }
}
