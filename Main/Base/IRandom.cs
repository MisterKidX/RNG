﻿using System.Collections;
using System.Collections.Generic;

namespace RNG.Base;
public interface IRandom
{
    double Value { get; }
    double Next();
}

public interface IDeterministicRandom : IRandom
{
    int Seed { get; }
}

public abstract class RandomGenerator : IRandom
{
    protected double _value;
    public double Value => _value;

    #region IEnumerator Implementation

    public double Current => _value;

    public abstract double Next();

    #endregion
}

public abstract class DeterministicRandomGenerator : RandomGenerator, IDeterministicRandom
{
    protected int _seed;
    public int Seed => _seed;
}
