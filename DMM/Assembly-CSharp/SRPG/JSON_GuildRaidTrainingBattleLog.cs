// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidTrainingBattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FAE")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidTrainingBattleLog
  {
    [Token(Token = "0x4003740")]
    [FieldOffset(Offset = "0x8")]
    public int btl_log_id;
    [Token(Token = "0x4003741")]
    [FieldOffset(Offset = "0xC")]
    public int period_id;
    [Token(Token = "0x4003742")]
    [FieldOffset(Offset = "0x10")]
    public int boss_id;
    [Token(Token = "0x4003743")]
    [FieldOffset(Offset = "0x14")]
    public int round;
    [Token(Token = "0x4003744")]
    [FieldOffset(Offset = "0x18")]
    public int damage;
    [Token(Token = "0x4003745")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Unit[] deck;
    [Token(Token = "0x4003746")]
    [FieldOffset(Offset = "0x20")]
    public int battle_time;

    [Token(Token = "0x60040D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidTrainingBattleLog()
    {
    }
  }
}
