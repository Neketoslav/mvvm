using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    float speed { get; }

    Vector3 direction { get; }

    Rigidbody rb { get; }

}
