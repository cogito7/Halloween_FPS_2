using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Enemy", order = 1)]

public class batEnemyData : ScriptableObject
{
    public int hp;
    public int damage;
    public float speed;
}
