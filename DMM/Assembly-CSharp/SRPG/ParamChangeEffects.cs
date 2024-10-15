// Decompiled with JetBrains decompiler
// Type: SRPG.ParamChangeEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE6")]
  public class ParamChangeEffects : ScriptableObject
  {
    [Token(Token = "0x4003831")]
    [FieldOffset(Offset = "0xC")]
    [HideInInspector]
    public ParamChangeEffects.EffectData[] Effects;

    [Token(Token = "0x600421F")]
    [Address(RVA = "0x119AE80", Offset = "0x1199C80", VA = "0x1119AE80")]
    public Sprite FindSprite(string type, bool isDebuff) => (Sprite) null;

    [Token(Token = "0x6004220")]
    [Address(RVA = "0x119AF10", Offset = "0x1199D10", VA = "0x1119AF10")]
    public ParamChangeEffects()
    {
    }

    [Token(Token = "0x2000FE7")]
    [Serializable]
    public struct EffectData
    {
      [Token(Token = "0x4003832")]
      [FieldOffset(Offset = "0x0")]
      public string TypeName;
      [Token(Token = "0x4003833")]
      [FieldOffset(Offset = "0x4")]
      public Sprite OnBuff;
      [Token(Token = "0x4003834")]
      [FieldOffset(Offset = "0x8")]
      public Sprite OnDebuff;
    }
  }
}
