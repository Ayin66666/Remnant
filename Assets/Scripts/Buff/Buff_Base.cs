using System;
using UnityEngine;


public abstract class Buff_Base : MonoBehaviour
{
    [Header("---Status---")]
    public BuffType buttType;
    public NormalBuff normalType;
    public KeywordBuff keywordType;
    public int buffTime;
    public int buffPower;


    /// <summary>
    /// TData 는 무조건 Enum 타입만 사용함! -> 키워드의 세부 특성 Enum 값임!
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    /// <param name="keyword"></param>
    /// <param name="subType"></param>
    /// <param name="data"></param>
    public abstract void Use<SubKeyword>(KeywordBuff mKeyword, int mPower, SubKeyword subKeyword, int sPower) where SubKeyword : Enum;
}

/*
 * 키워드 세부 종류 - 버프_키워드
 * 일반 버프 종류 - 버프_노말
 * 버프 선언 / 인터페이스
 * 버프 호출 / 인터페이스
 * 전략 패턴
 */


