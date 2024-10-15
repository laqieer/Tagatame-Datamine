// Decompiled with JetBrains decompiler
// Type: YuremonoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001A3")]
public class YuremonoParam : ScriptableObject
{
  [Token(Token = "0x40007C9")]
  [FieldOffset(Offset = "0xC")]
  public YuremonoParam.TargetParam[] Targets;
  [Token(Token = "0x40007CA")]
  [FieldOffset(Offset = "0x10")]
  public YuremonoParam.SkirtTraceParam[] SkirtTraceTargets;

  [Token(Token = "0x6000A05")]
  [Address(RVA = "0xF5A3C0", Offset = "0xF591C0", VA = "0x10F5A3C0")]
  public YuremonoParam()
  {
  }

  [Token(Token = "0x20001A4")]
  public enum Axes
  {
    [Token(Token = "0x40007CC")] XNegative,
    [Token(Token = "0x40007CD")] XPositive,
    [Token(Token = "0x40007CE")] YNegative,
    [Token(Token = "0x40007CF")] YPositive,
    [Token(Token = "0x40007D0")] ZNegative,
    [Token(Token = "0x40007D1")] ZPositive,
  }

  [Token(Token = "0x20001A5")]
  [Serializable]
  public class TargetParam
  {
    [Token(Token = "0x40007D2")]
    [FieldOffset(Offset = "0x8")]
    public string TargetName;
    [Token(Token = "0x40007D3")]
    [FieldOffset(Offset = "0xC")]
    [Range(0.0f, 1f)]
    public float Kinematic;
    [Token(Token = "0x40007D4")]
    [FieldOffset(Offset = "0x10")]
    [Range(0.0f, 1f)]
    public float Gravity;
    [Token(Token = "0x40007D5")]
    [FieldOffset(Offset = "0x14")]
    public float Length;
    [Token(Token = "0x40007D6")]
    [FieldOffset(Offset = "0x18")]
    public YuremonoParam.Axes ForwardAxis;
    [Token(Token = "0x40007D7")]
    [FieldOffset(Offset = "0x1C")]
    public float Damping;
    [Token(Token = "0x40007D8")]
    [FieldOffset(Offset = "0x20")]
    public float Acceleration;
    [Token(Token = "0x40007D9")]
    [FieldOffset(Offset = "0x24")]
    [Range(0.0f, 90f)]
    public float AngularLimit;

    [Token(Token = "0x6000A06")]
    [Address(RVA = "0xF502E0", Offset = "0xF4F0E0", VA = "0x10F502E0")]
    public TargetParam()
    {
    }
  }

  [Token(Token = "0x20001A6")]
  [Serializable]
  public class SkirtTraceParam
  {
    [Token(Token = "0x40007DA")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x40007DB")]
    [FieldOffset(Offset = "0xC")]
    [Range(0.0f, 1f)]
    public float SkirtRatio;
    [Token(Token = "0x40007DC")]
    [FieldOffset(Offset = "0x10")]
    [Range(0.0f, 360f)]
    public float RotWaitAng;
    [Token(Token = "0x40007DD")]
    [FieldOffset(Offset = "0x14")]
    public string TargetName;
    [Token(Token = "0x40007DE")]
    [FieldOffset(Offset = "0x18")]
    public YuremonoParam.SkirtTraceParam.EikyoSkirt[] EikyoSkirts;

    [Token(Token = "0x6000A07")]
    [Address(RVA = "0xF4FEC0", Offset = "0xF4ECC0", VA = "0x10F4FEC0")]
    public SkirtTraceParam()
    {
    }

    [Token(Token = "0x20001A7")]
    [Serializable]
    public class EikyoSkirt
    {
      [Token(Token = "0x40007DF")]
      [FieldOffset(Offset = "0x8")]
      public string Name;
      [Token(Token = "0x40007E0")]
      [FieldOffset(Offset = "0xC")]
      [Range(0.0f, 1f)]
      public float Ratio;

      [Token(Token = "0x6000A08")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EikyoSkirt()
      {
      }
    }
  }
}
