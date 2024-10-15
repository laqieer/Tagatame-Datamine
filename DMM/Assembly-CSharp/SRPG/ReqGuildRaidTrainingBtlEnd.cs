// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidTrainingBtlEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F53")]
  public class ReqGuildRaidTrainingBtlEnd : WebAPI
  {
    [Token(Token = "0x600DBA4")]
    [Address(RVA = "0xA733A0", Offset = "0xA721A0", VA = "0x10A733A0")]
    public ReqGuildRaidTrainingBtlEnd(
      long btlid,
      BtlResultTypes result,
      int bossId,
      int turn,
      List<Unit> enemyUnits,
      Network.ResponseCallback response,
      BattleCore.Record record = null,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x2002F54")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA0B")]
      [FieldOffset(Offset = "0x8")]
      public string status;
      [Token(Token = "0x400EA0C")]
      [FieldOffset(Offset = "0x10")]
      public long btlid;
      [Token(Token = "0x400EA0D")]
      [FieldOffset(Offset = "0x18")]
      public JSON_GuildRaidBossInfo boss_info;
      [Token(Token = "0x400EA0E")]
      [FieldOffset(Offset = "0x1C")]
      public ReqGuildRaidTrainingBtlEnd.RequestEnd btlendparam;

      [Token(Token = "0x600DBA5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F55")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response : ReqGuildRaidBtlEnd.Response
    {
      [Token(Token = "0x600DBA6")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F56")]
    [Serializable]
    public class RequestEnd
    {
      [Token(Token = "0x400EA0F")]
      [FieldOffset(Offset = "0x8")]
      public string auto_status;
      [Token(Token = "0x400EA10")]
      [FieldOffset(Offset = "0xC")]
      public int turn;

      [Token(Token = "0x600DBA7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEnd()
      {
      }
    }
  }
}
