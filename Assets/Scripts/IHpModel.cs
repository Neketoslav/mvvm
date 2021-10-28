using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHpModel
{
    float maxHp { get; }
    float currentHp { get; set; }
}

