// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CombatPowerRankingGuildMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F87")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CombatPowerRankingGuildMember : JSON_GuildMember
  {
    [Token(Token = "0x400368D")]
    [FieldOffset(Offset = "0x50")]
    public int rank;
    [Token(Token = "0x400368E")]
    [FieldOffset(Offset = "0x58")]
    public long combat_power;

    [Token(Token = "0x600405B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CombatPowerRankingGuildMember()
    {
    }
  }
}
