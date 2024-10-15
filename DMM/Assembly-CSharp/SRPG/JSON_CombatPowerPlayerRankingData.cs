// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CombatPowerPlayerRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200118B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CombatPowerPlayerRankingData
  {
    [Token(Token = "0x4003F9D")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4003F9E")]
    [FieldOffset(Offset = "0xC")]
    public int level;
    [Token(Token = "0x4003F9F")]
    [FieldOffset(Offset = "0x10")]
    public int support_unit;
    [Token(Token = "0x4003FA0")]
    [FieldOffset(Offset = "0x14")]
    public JSON_CombatPowerPlayerRankingInfo target_unit;
    [Token(Token = "0x4003FA1")]
    [FieldOffset(Offset = "0x18")]
    public string selected_award;
    [Token(Token = "0x4003FA2")]
    [FieldOffset(Offset = "0x1C")]
    public int combat_power;
    [Token(Token = "0x4003FA3")]
    [FieldOffset(Offset = "0x20")]
    public string uid;

    [Token(Token = "0x6004AF8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CombatPowerPlayerRankingData()
    {
    }
  }
}
