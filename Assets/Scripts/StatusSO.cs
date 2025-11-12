using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class StatusGrowth
{
    public int level;
    public int hp;
    public int attackUp;
    public int defenceUp;
    public Vector2Int speed;
}


[CreateAssetMenu(fileName = "Status", menuName ="Character/Status", order = int.MaxValue)]
public class StatusSO : ScriptableObject
{
    [Header("---Status---")]
    [SerializeField] private int baseHp;
    [SerializeField] private List<int> groggy;
    [SerializeField] private int baseAttack;
    [SerializeField] private int baseDefence;
    [SerializeField] private Vector2Int baseSpeed;
    public List<StatusGrowth> growthData;


    public int BaseHp {  get { return baseHp; } private set { baseHp = value; } }
    public List<int> Groggy {  get { return groggy; } private set { groggy = value; } }
    public int BaseAttack {  get { return baseAttack; } private set { baseAttack = value; } }
    public int BaseDefence {  get { return baseDefence; } private set { baseDefence = value; } }
    public Vector2Int BaseSpeed {  get { return baseSpeed; } private set { baseSpeed = value; } }
    public List<StatusGrowth> GrowthData {  get { return growthData; } private set { growthData = value; } }
}
