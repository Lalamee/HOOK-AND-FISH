using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodEnd : MonoBehaviour
{
    public void TurnOnObject()
    {
        gameObject.SetActive(true);
    }

    // ����� ��� ���������� �������
    public void TurnOffObject()
    {
        gameObject.SetActive(false);
    }
}
