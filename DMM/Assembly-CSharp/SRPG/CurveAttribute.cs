// Decompiled with JetBrains decompiler
// Type: SRPG.CurveAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200115F")]
  public class CurveAttribute : PropertyAttribute
  {
    [Token(Token = "0x4003EDE")]
    [FieldOffset(Offset = "0xC")]
    public float PosX;
    [Token(Token = "0x4003EDF")]
    [FieldOffset(Offset = "0x10")]
    public float PosY;
    [Token(Token = "0x4003EE0")]
    [FieldOffset(Offset = "0x14")]
    public float RangeX;
    [Token(Token = "0x4003EE1")]
    [FieldOffset(Offset = "0x18")]
    public float RangeY;
    [Token(Token = "0x4003EE2")]
    [FieldOffset(Offset = "0x1C")]
    public bool b;
    [Token(Token = "0x4003EE3")]
    [FieldOffset(Offset = "0x20")]
    public int x;

    [Token(Token = "0x6004A02")]
    [Address(RVA = "0x11FF2D0", Offset = "0x11FE0D0", VA = "0x111FF2D0")]
    public CurveAttribute(float PosX, float PosY, float RangeX, float RangeY, bool b)
    {
    }
  }
}
