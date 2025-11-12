using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff_Base : MonoBehaviour
{
    [Header("---Status---")]
    public ButtType buffType;
    public int buffTime;
    public int buffPower;

    public enum ButtType { Buff, DeBuff }
}
