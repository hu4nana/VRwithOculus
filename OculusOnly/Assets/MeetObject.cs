using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public enum MeetType
{
    Left,
    Right
}
public class MeetObject : MonoBehaviour
{
    public MeetType type;
    bool col = false;

    public void Test()
    {
        Debug.Log(this.name + " is Activated");
    }
    public bool GetCollision()
    {
        return col;
    }
    public void SetCollision(bool value)
    {
        col = value;
    }
    // �浹 �� ��Ʈ�ѷ��� Left, Right�� Meets�� Left, Right �� ������ Ȯ���� �� Destroy
}
