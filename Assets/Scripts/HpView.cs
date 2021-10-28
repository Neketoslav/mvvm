using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal sealed class HpView : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody rb;
    private IHpViewModel _hpViewModel;
    private Move _move;
    private float speed = 5f;

    public void Initialize(IHpViewModel hpViewModel)
    {
        _hpViewModel = hpViewModel;
        _hpViewModel.OnHpChange += OnHpChange;
        OnHpChange(_hpViewModel.HpModel.currentHp);

        _move = new Move(rb, speed);
    }

    private void OnHpChange(float currentHp)
    {
        text.text = currentHp.ToString();
        if(currentHp <= 0)
        {
            Destroy(player);
        }
    }

    public void Move()
    {
        _move.MovePlayer("Horizontal", "Vertical");  
    }

    ~HpView()
    {
        _hpViewModel.OnHpChange -= OnHpChange;
    }
}
