// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSetEff
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CE4")]
  [MessagePackObject(true)]
  [Serializable]
  public class RuneSetEff
  {
    [Token(Token = "0x4007143")]
    public const int DEFAULT_SET_EFFECT_TYPE = 0;
    [Token(Token = "0x4007144")]
    [FieldOffset(Offset = "0x8")]
    public int seteff_type;
    [Token(Token = "0x4007145")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007146")]
    [FieldOffset(Offset = "0x10")]
    public byte icon_index;
    [Token(Token = "0x4007147")]
    [FieldOffset(Offset = "0x11")]
    public byte cost;
    [Token(Token = "0x4007148")]
    [FieldOffset(Offset = "0x14")]
    public RuneSetEffState[] state;

    [Token(Token = "0x60076AE")]
    [Address(RVA = "0x39DBB0", Offset = "0x39C9B0", VA = "0x1039DBB0")]
    public bool Deserialize(JSON_RuneSetEff json) => new bool();

    [Token(Token = "0x60076AF")]
    [Address(RVA = "0x39DD30", Offset = "0x39CB30", VA = "0x1039DD30")]
    public static bool IsDefaultEffectType(int effect_type) => new bool();

    [Token(Token = "0x60076B0")]
    [Address(RVA = "0x39D970", Offset = "0x39C770", VA = "0x1039D970")]
    public void AddRuneSetEffectBaseStatus(
      EElement buffTargetElement,
      ref BaseStatus addStatus,
      ref BaseStatus scaleStatus,
      bool isDrawBaseStatus)
    {
    }

    [Token(Token = "0x60076B1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneSetEff()
    {
    }
  }
}
