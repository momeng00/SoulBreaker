using UnityEngine;

[CreateAssetMenu(fileName = "DamageFxData", menuName = "Data/FxEventData/DamageFxData")]
public class DamageFxData : FxEventData
{
    public int DamageCoefficient;

    public override void OnEventToTarget(Unit owner, Unit target)
    {
        float damageCoefficient = DamageCoefficient / 100f; // ������ ����� ��� (100 ����)
        (int damage, bool isCritical) = owner.LastDamage();
        int totalDamage = (int)(damage * damageCoefficient); // ���� ������ ���
        if (target == null) return;
        target.OnHit(totalDamage, owner, isCritical);
    }
}