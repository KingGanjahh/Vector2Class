using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyVector 
{
    public float x;
    public float y;

    public MyVector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public MyVector AddVector(MyVector other)
    {
        return this + other;
    }

    public MyVector SubVector(MyVector other)
    {
        return this - other;
    }

    public MyVector Multiply(float scalar)
    {
        return this * scalar;
    }

    public float CalculateMagnitude()
    {
        float result = Mathf.Sqrt(this.x * this.x + this.y * this.y);

        return result;
    }

    public MyVector Normalize()
    {
        float magnitude = this.CalculateMagnitude();

        return new MyVector(this.x / magnitude, this.y / magnitude);
    }

    public void Draw(MyVector newOrigin)
    {
        Debug.DrawLine(new Vector2(newOrigin.x, newOrigin.y), new Vector2(x + newOrigin.x, y + newOrigin.y));
    }

    public void DrawZero()
    {
        Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y));
    }

    public MyVector Lerp(MyVector start, MyVector end, float scale)
    {
        MyVector c = end - start;
        c = c * scale;

        MyVector result = start + c;

        return result;
    }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y);
    }

    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y);
    }

    public static MyVector operator *(MyVector a, float scalar)
    {
        return new MyVector(a.x * scalar, a.y * scalar);
    }

    public static MyVector operator *(float scalar, MyVector a)
    {
        return new MyVector(a.x * scalar, a.y * scalar);
    }

    public static MyVector operator /(MyVector a, float scalar)
    {
        return new MyVector(a.x / scalar, a.y / scalar);
    }
}
