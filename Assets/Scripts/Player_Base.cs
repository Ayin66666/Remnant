using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player_Base : Character_Base
{
    /// <summary>
    /// 스테이지 진입 시 최초 1회 실행
    /// </summary>
    public override void Status_Setting()
    {
        // 기본 스텟
        hp = status.BaseHp;
        attackPoint = status.BaseAttack;
        defencePoint = status.BaseDefence;

        // 레벨업 스텟
        int start = 1;
        int targetLevel = level;
        for (int i = 0; i < status.growthData.Count; i++)
        {
            var growth = status.growthData[i];
            int end = Mathf.Min(targetLevel, growth.level);

            int levelCount = end - start + 1; // 한 구간에서 적용할 레벨 수
            if (levelCount > 0)
            {
                hp += growth.hp * levelCount;
                attackPoint += growth.attackUp * levelCount;
                defencePoint += growth.defenceUp * levelCount;
                start = end + 1; // 다음 구간 시작
            }

            if (start > targetLevel) break; // 목표 레벨 도달
        }
    }

    
}
