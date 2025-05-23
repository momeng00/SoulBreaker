using UnityEngine;

[CreateAssetMenu(fileName = "NewUnitData", menuName = "Data/Unit/Create UnitData")]
public class UnitData : ScriptableObject, IStats
{
    [Header("Config")] [SerializeField] private string _id;
    [SerializeField] private Sprite _icon;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _hitPrefab;

    [Header("원거리")] [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private GameObject _warningPrefab;

    [Header("drop exp")] [Tooltip("몬스터가 죽을때 드롭하는 경험치")] [SerializeField]
    private int _dropExp;

    [Header("Stats")] [SerializeField] private IntStat _health;
    [SerializeField] private IntStat _attack;
    [SerializeField] private FloatStat _ap;
    [SerializeField] private FloatStat _ad;
    [SerializeField] private IntStat _defense;
    [SerializeField] private IntStat _mp;
    private FloatStat _mpPercent;
    [SerializeField] private IntStat _exp;
    private FloatStat _expPercent;
    [SerializeField] private IntStat _level;
    [SerializeField] private IntStat _stageLevel;
    [SerializeField] private FloatStat _speed;
    [SerializeField] private FloatStat _attackSpeed;
    [SerializeField] private FloatStat _attackRange;

    [Tooltip("크리티컬발생 확률")] [SerializeField] private FloatStat _criticalRate;

    [Tooltip("크리티컬 배수(일반 공격에 몇배)")] [SerializeField]
    private FloatStat _criticalPercent;

    [SerializeField] private FloatStat _stunRate;
    [Tooltip("흡혈발생 확률")] [SerializeField] private FloatStat _lifestealRate;
    [Tooltip("흡혈 배수(입힌 피해 퍼센트)")] [SerializeField] private FloatStat _lifestealPercent;

    public string Id => _id;
    public Sprite Icon => _icon;
    public GameObject Prefab => _prefab;
    public GameObject HitPrefab => _hitPrefab;

    public GameObject ProjectilePrefab => _projectilePrefab;
    public GameObject WarningPrefab => _warningPrefab;

    public int DropExp => _dropExp;

    public IntStat Health => _health;
    public IntStat Attack => _attack;
    public FloatStat AP => _ap;
    public FloatStat AD => _ad;
    public IntStat Defense => _defense;
    public IntStat Mp => _mp;
    public FloatStat MpPercent => _mpPercent;
    public IntStat Exp => _exp;
    public FloatStat ExpPercent => _expPercent;
    public IntStat Level => _level;
    public IntStat StageLevel => _stageLevel;
    public FloatStat Speed => _speed;
    public FloatStat AttackSpeed => _attackSpeed;
    public FloatStat AttackRange => _attackRange;

    public FloatStat CriticalRate => _criticalRate;
    public FloatStat CriticalPercent => _criticalPercent;
    public FloatStat AttackStunRate => _stunRate;
    public FloatStat LifestealRate => _lifestealRate;
    public FloatStat LifestealPercent => _lifestealPercent;
}