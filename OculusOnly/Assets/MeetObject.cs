using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MeetType
{
    Left,
    Right
}
public class MeetObject : MonoBehaviour
{
    public MeetType type;


    public void Test()
    {
        Debug.Log(this.name + " is Activated");
    }

    // �浹 �� ��Ʈ�ѷ��� Left, Right�� Meets�� Left, Right �� ������ Ȯ���� �� Destroy
}
