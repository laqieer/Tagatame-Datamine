// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidRankingMemberBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA8")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidRankingMemberBoss
  {
    [Token(Token = "0x4003725")]
    [FieldOffset(Offset = "0x8")]
    public int boss_id;
    [Token(Token = "0x4003726")]
    [FieldOffset(Offset = "0xC")]
    public int rank;

    [Token(Token = "0x60040D2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidRankingMemberBoss()
    {
    }
  }
}
