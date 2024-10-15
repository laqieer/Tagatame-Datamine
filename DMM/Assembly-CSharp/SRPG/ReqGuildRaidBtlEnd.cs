// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidBtlEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F24")]
  public class ReqGuildRaidBtlEnd : WebAPI
  {
    [Token(Token = "0x600DB73")]
    [Address(RVA = "0xA71B20", Offset = "0xA70920", VA = "0x10A71B20")]
    public ReqGuildRaidBtlEnd(
      int gid,
      long btlid,
      BtlResultTypes result,
      int bossId,
      int turn,
      List<Unit> enemyUnits,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response,
      BattleCore.Record record = null,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x2002F25")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9BB")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400E9BC")]
      [FieldOffset(Offset = "0x10")]
      public string status;
      [Token(Token = "0x400E9BD")]
      [FieldOffset(Offset = "0x14")]
      public JSON_GuildRaidBossInfo boss_info;
      [Token(Token = "0x400E9BE")]
      [FieldOffset(Offset = "0x18")]
      public ReqGuildRaidBtlEnd.RequestEnd btlendparam;
      [Token(Token = "0x400E9BF")]
      [FieldOffset(Offset = "0x1C")]
      public int gid;

      [Token(Token = "0x600DB74")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F26")]
    [Serializable]
    public class RequestEnd
    {
      [Token(Token = "0x400E9C0")]
      [FieldOffset(Offset = "0x8")]
      public ReqGuildRaidBtlEnd.RequestEndInput[] inputs;
      [Token(Token = "0x400E9C1")]
      [FieldOffset(Offset = "0xC")]
      public string auto_status;
      [Token(Token = "0x400E9C2")]
      [FieldOffset(Offset = "0x10")]
      public int turn;

      [Token(Token = "0x600DB75")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEnd()
      {
      }
    }

    [Token(Token = "0x2002F27")]
    [Serializable]
    public class RequestEndInput
    {
      [Token(Token = "0x400E9C3")]
      [FieldOffset(Offset = "0x8")]
      public string use;
      [Token(Token = "0x400E9C4")]
      [FieldOffset(Offset = "0xC")]
      public int n;

      [Token(Token = "0x600DB76")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEndInput()
      {
      }
    }

    [Token(Token = "0x2002F28")]
    [Serializable]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400E9C5")]
      [FieldOffset(Offset = "0xB0")]
      public int total_damage;
      [Token(Token = "0x400E9C6")]
      [FieldOffset(Offset = "0xB8")]
      public long total_score;
      [Token(Token = "0x400E9C7")]
      [FieldOffset(Offset = "0xC0")]
      public JSON_GuildRaidBossInfo[] boss_info;

      [Token(Token = "0x600DB77")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }
  }
}
