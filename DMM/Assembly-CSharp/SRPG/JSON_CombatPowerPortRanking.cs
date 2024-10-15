// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CombatPowerPortRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200118D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CombatPowerPortRanking
  {
    [Token(Token = "0x4003FA6")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x4003FA7")]
    [FieldOffset(Offset = "0xC")]
    public int id;
    [Token(Token = "0x4003FA8")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4003FA9")]
    [FieldOffset(Offset = "0x14")]
    public int combat_power;
    [Token(Token = "0x4003FAA")]
    [FieldOffset(Offset = "0x18")]
    public string award_id;
    [Token(Token = "0x4003FAB")]
    [FieldOffset(Offset = "0x1C")]
    public string guild_master;
    [Token(Token = "0x4003FAC")]
    [FieldOffset(Offset = "0x20")]
    public int level;

    [Token(Token = "0x6004AFA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CombatPowerPortRanking()
    {
    }
  }
}
