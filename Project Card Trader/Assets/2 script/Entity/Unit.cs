using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum wealthValue
{ rich, moderate, poor }

public class Unit : MonoBehaviour
{
    public wealthValue wealth;
    public int money;
    public int investsiment;
    public int hapiness;
    public int anger;
}