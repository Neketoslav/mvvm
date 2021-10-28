using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpModel : IHpModel
{
    public float maxHp { get; }

    public float currentHp { get; set; }

    public HpModel(float _maxHp)
    {
        maxHp = _maxHp;
        currentHp = maxHp;
    }
}
