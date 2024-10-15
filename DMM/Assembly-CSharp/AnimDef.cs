// Decompiled with JetBrains decompiler
// Type: AnimDef
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200003C")]
public class AnimDef : ScriptableObject
{
  [Token(Token = "0x4000129")]
  [FieldOffset(Offset = "0x0")]
  private static AnimDef mDefaultEmptyAnimation;
  [Token(Token = "0x400012A")]
  [FieldOffset(Offset = "0xC")]
  public AnimationClip animation;
  [Token(Token = "0x400012B")]
  [FieldOffset(Offset = "0x10")]
  public AnimationCurve rootTranslationX;
  [Token(Token = "0x400012C")]
  [FieldOffset(Offset = "0x14")]
  public AnimationCurve rootTranslationY;
  [Token(Token = "0x400012D")]
  [FieldOffset(Offset = "0x18")]
  public AnimationCurve rootTranslationZ;
  [Token(Token = "0x400012E")]
  [FieldOffset(Offset = "0x1C")]
  public bool UseRootMotion;
  [Token(Token = "0x400012F")]
  [FieldOffset(Offset = "0x20")]
  public string rootBoneName;
  [Token(Token = "0x4000130")]
  [FieldOffset(Offset = "0x24")]
  public bool IsParentPosZero;
  [Token(Token = "0x4000131")]
  [FieldOffset(Offset = "0x25")]
  public bool IsRidingUnitCHM;
  [Token(Token = "0x4000132")]
  [FieldOffset(Offset = "0x28")]
  public AnimEvent[] events;
  [Token(Token = "0x4000133")]
  [FieldOffset(Offset = "0x2C")]
  public List<string> CurveNames;
  [Token(Token = "0x4000134")]
  [FieldOffset(Offset = "0x30")]
  [HideInInspector]
  public AnimDef.CustomCurve[] CustomCurves;

  [Token(Token = "0x17000024")]
  public static AnimDef DefaultEmptyAnimation
  {
    [Token(Token = "0x6000177"), Address(RVA = "0x2CDFB0", Offset = "0x2CCDB0", VA = "0x102CDFB0")] get
    {
      return (AnimDef) null;
    }
  }

  [Token(Token = "0x17000025")]
  public float Length
  {
    [Token(Token = "0x6000178"), Address(RVA = "0x2CE130", Offset = "0x2CCF30", VA = "0x102CE130")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x6000179")]
  [Address(RVA = "0x2CDEF0", Offset = "0x2CCCF0", VA = "0x102CDEF0")]
  public AnimationCurve FindCustomCurve(string curveName) => (AnimationCurve) null;

  [Token(Token = "0x17000026")]
  public bool IsValid
  {
    [Token(Token = "0x600017A"), Address(RVA = "0x2CE0E0", Offset = "0x2CCEE0", VA = "0x102CE0E0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x600017B")]
  public T[] GetAnimationEvents<T>() where T : AnimEvent => (T[]) null;

  [Token(Token = "0x600017C")]
  [Address(RVA = "0x2CDF60", Offset = "0x2CCD60", VA = "0x102CDF60")]
  public AnimDef()
  {
  }

  [Token(Token = "0x200003D")]
  [Serializable]
  public struct CustomCurve
  {
    [Token(Token = "0x4000135")]
    [FieldOffset(Offset = "0x0")]
    public string Name;
    [Token(Token = "0x4000136")]
    [FieldOffset(Offset = "0x4")]
    public AnimationCurve CurveData;
    [Token(Token = "0x4000137")]
    [FieldOffset(Offset = "0x8")]
    public string Source;
  }
}
