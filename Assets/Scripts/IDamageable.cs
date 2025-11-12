

public interface IDamageable
{
    public void TakeDamage(HitEffect effect, bool isCritical, int damage);

    public void Groggy();

    public void Die();
}
