using UnityEngine;


public abstract class Buff_Base : MonoBehaviour
{
    [Header("---Status---")]
    public BuffType buttType;
    public NormalBuff normalType;
    public KeywordBuff keywordType;
    public int buffTime;
    public int buffPower;
}

/*
 * 키워드 세부 종류 - 버프_키워드
 * 일반 버프 종류 - 버프_노말
 * 버프 선언 / 인터페이스
 * 버프 호출 / 인터페이스
 * 전략 패턴
 */


