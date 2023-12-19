using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [field: SerializeField] public Attributes Attributes { get; private set; }
}
