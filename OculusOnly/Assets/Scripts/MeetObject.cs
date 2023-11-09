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
    // 충돌 시 컨트롤러의 Left, Right와 Meets의 Left, Right 가 같은지 확인한 후 Destroy
}
