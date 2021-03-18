using System;

namespace LabWork6Classes
{
    public interface ICloneable
    {
        object Clone();
    }

    public interface IComparable
    {
        int CompareTo(object obj);
    }
}
