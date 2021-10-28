using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpViewModel : IHpViewModel
{
    private bool _isDead;
    public IHpModel HpModel{ get; }

    public bool IsDead => _isDead;

    public event Action<float> OnHpChange;
    public HpViewModel(IHpModel hpModel)
    {
        HpModel = hpModel;
    }

    public void ApplyDamage(float damage)
    {
        HpModel.currentHp -= damage;
        if (HpModel.currentHp <= 0)
        {
            _isDead = true;
        }
        OnHpChange?.Invoke(HpModel.currentHp);
    }
}
