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

    // 충돌 시 컨트롤러의 Left, Right와 Meets의 Left, Right 가 같은지 확인한 후 Destroy
}
