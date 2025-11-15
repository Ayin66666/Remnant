

public interface IDamageable
{
    /// <summary>
    /// 일반 데미지
    /// </summary>
    /// <param name="isCritical"></param>
    /// <param name="damage"></param>
    public void TakeDamage(bool isCritical, int damage);

    /// <summary>
    /// 키워드 적용
    /// </summary>
    /// <param name="buff"></param>
    /// <param name="time"></param>
    /// <param name="power"></param>
    public void AddKeyword(KeywordBuff buff, int time, int power);

    public void Groggy();

    public void Die();
}
