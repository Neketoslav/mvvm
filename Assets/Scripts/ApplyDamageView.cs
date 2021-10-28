using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal sealed class ApplyDamageView : MonoBehaviour
{
    [SerializeField] private float _damage;
    private IHpViewModel _hpViewModel;

    public void Initialize(IHpViewModel hpViewModel)
    {
        _hpViewModel = hpViewModel;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        _hpViewModel.ApplyDamage(_damage);
    }
}


