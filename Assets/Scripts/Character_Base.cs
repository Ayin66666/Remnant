using System.Collections.Generic;
using UnityEngine;


public abstract class Character_Base : MonoBehaviour, IDamageable
{
    [Header("---State---")]
    public State state;
    public enum State { Idle, Movement, Attack, Groggy, Die }


    [Header("---Status---")]
    public StatusSO status;
    public int level;
    public int attackPoint;
    public int defencePoint;
    public int hp;
    public int[] groggy;


    [Header("---Attack---")]
    public List<GameObject> slots;


    /*
    데이터
     - 스테이터스 데이터 (체력, 흐트러짐, 공격력, 방어력, 속도 / 레벨 당 상승값)
     - 스테이트 데이터 (그로기 유무, 현제 상태 등등)
     - 스킬 데이터 (스킬 갯수, 슬롯 갯수)
     - UI 데이터

    컴포넌트
     - 바디 오브젝트
     - 콜라이더 & 리지드 바디 & 스프라이트

    기능
     - 속도 지정 (슬롯 리스트에서 함수 호출 방식)
     - 데미지 (인터페이스로 빼고 상속받도록)
     - 피격 효과 (데미지 출력, 바디 흔들림)
     - 사망 (abstract 선언 - 상속받아 세부 구현? - 근데 스프라이트 터지는게 끝 아닌가?)
     */



    /// <summary>
    /// 플레이어 = 최초 1회 스테이지 진입 시 데이터 설정
    /// 몬스터 = 노드 진입 시 스테이지 매니저에서 호출
    /// </summary>
    public abstract void Status_Setting();

    /// <summary>
    /// 슬롯 속도 셋팅
    /// </summary>
    public void Speed_Setting()
    {
    }

    public void TakeDamage(bool isCritical, int damage)
    {
        // 데미지 계산
        float criticalValue = isCritical ? 1.2f : 1f;
        int dam = (int)(damage * criticalValue - (0.5f * defencePoint));

        // 데미지 적용
        hp -= dam;
        if(hp <= 0)
        {
            Die();
        }
    }

    public void Groggy()
    {
        throw new System.NotImplementedException();
    }

    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public void AddKeyword(KeywordBuff buff, int time, int power)
    {
        throw new System.NotImplementedException();
    }

    public void Normal()
    {
        throw new System.NotImplementedException();
    }


}
