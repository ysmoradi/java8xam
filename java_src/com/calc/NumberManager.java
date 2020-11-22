package com.calc;

public interface NumberManager
{
    public default int change(int input)
    {
        return input * 2;
    }
}