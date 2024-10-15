// Decompiled with JetBrains decompiler
// Type: CurveAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200009B")]
public class CurveAsset : ScriptableObject
{
  [Token(Token = "0x40002FB")]
  [FieldOffset(Offset = "0xC")]
  public CurveAsset.CurveStruct[] Curves;

  [Token(Token = "0x60003C8")]
  [Address(RVA = "0xB83890", Offset = "0xB82690", VA = "0x10B83890")]
  public AnimationCurve FindCurve(string name) => (AnimationCurve) null;

  [Token(Token = "0x60003C9")]
  [Address(RVA = "0xB83900", Offset = "0xB82700", VA = "0x10B83900")]
  public CurveAsset()
  {
  }

  [Token(Token = "0x200009C")]
  [Serializable]
  public struct CurveStruct
  {
    [Token(Token = "0x40002FC")]
    [FieldOffset(Offset = "0x0")]
    public string Name;
    [Token(Token = "0x40002FD")]
    [FieldOffset(Offset = "0x4")]
    public AnimationCurve Curve;
  }
}
