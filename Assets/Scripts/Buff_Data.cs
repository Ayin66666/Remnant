using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff_Data : MonoBehaviour
{
    [Header("---Status---")]
    public BuffType buttType;
    public NormalBuff normalType;
    public KeywordBuff keywordType;
    public int buffTime;
    public int buffPower;
}
