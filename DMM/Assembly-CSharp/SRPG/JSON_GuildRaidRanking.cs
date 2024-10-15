// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidRanking
  {
    [Token(Token = "0x4003718")]
    [FieldOffset(Offset = "0x8")]
    public int rank;
    [Token(Token = "0x4003719")]
    [FieldOffset(Offset = "0x10")]
    public long score;
    [Token(Token = "0x400371A")]
    [FieldOffset(Offset = "0x18")]
    public JSON_GuildRaidRankingGuild guild;

    [Token(Token = "0x60040CF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidRanking()
    {
    }
  }
}
