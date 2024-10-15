// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGenesisBossBtlEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031F0")]
  public class ReqGenesisBossBtlEnd : WebAPI
  {
    [Token(Token = "0x600DE8C")]
    [Address(RVA = "0xA97E70", Offset = "0xA96C70", VA = "0x10A97E70")]
    public ReqGenesisBossBtlEnd(
      long btlid,
      BtlResultTypes result,
      List<Unit> all_units,
      int start_index,
      int[] missions,
      int[] missions_log,
      Dictionary<OString, OInt> used_items,
      Network.ResponseCallback response,
      BattleCore.Record record = null,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x20031F1")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDAE")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400EDAF")]
      [FieldOffset(Offset = "0x10")]
      public string status;
      [Token(Token = "0x400EDB0")]
      [FieldOffset(Offset = "0x14")]
      public ReqGenesisBossBtlEnd.RequestEnd btlendparam;

      [Token(Token = "0x600DE8D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031F2")]
    [Serializable]
    public class RequestEnd
    {
      [Token(Token = "0x400EDB1")]
      [FieldOffset(Offset = "0x8")]
      public BattleCore.Json_GenesisEnemy[] enemies;
      [Token(Token = "0x400EDB2")]
      [FieldOffset(Offset = "0xC")]
      public ReqGenesisBossBtlEnd.RequestEndInput[] inputs;
      [Token(Token = "0x400EDB3")]
      [FieldOffset(Offset = "0x10")]
      public int[] missions;
      [Token(Token = "0x400EDB4")]
      [FieldOffset(Offset = "0x14")]
      public int[] missions_log;
      [Token(Token = "0x400EDB5")]
      [FieldOffset(Offset = "0x18")]
      public string auto_status;

      [Token(Token = "0x600DE8E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEnd()
      {
      }
    }

    [Token(Token = "0x20031F3")]
    [Serializable]
    public class RequestEndInput
    {
      [Token(Token = "0x400EDB6")]
      [FieldOffset(Offset = "0x8")]
      public string use;
      [Token(Token = "0x400EDB7")]
      [FieldOffset(Offset = "0xC")]
      public int n;

      [Token(Token = "0x600DE8F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEndInput()
      {
      }
    }

    [Token(Token = "0x20031F4")]
    [Serializable]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400EDB8")]
      [FieldOffset(Offset = "0xB0")]
      public Json_Gift[] genesis_boss_reward;

      [Token(Token = "0x600DE90")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }
  }
}
