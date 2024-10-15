// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdvanceBossBtlEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200321C")]
  public class ReqAdvanceBossBtlEnd : WebAPI
  {
    [Token(Token = "0x600DEB8")]
    [Address(RVA = "0xA92620", Offset = "0xA91420", VA = "0x10A92620")]
    public ReqAdvanceBossBtlEnd(
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

    [Token(Token = "0x200321D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE0B")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400EE0C")]
      [FieldOffset(Offset = "0x10")]
      public string status;
      [Token(Token = "0x400EE0D")]
      [FieldOffset(Offset = "0x14")]
      public ReqAdvanceBossBtlEnd.RequestEnd btlendparam;

      [Token(Token = "0x600DEB9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200321E")]
    [Serializable]
    public class RequestEnd
    {
      [Token(Token = "0x400EE0E")]
      [FieldOffset(Offset = "0x8")]
      public BattleCore.Json_AdvanceEnemy[] enemies;
      [Token(Token = "0x400EE0F")]
      [FieldOffset(Offset = "0xC")]
      public ReqAdvanceBossBtlEnd.RequestEndInput[] inputs;
      [Token(Token = "0x400EE10")]
      [FieldOffset(Offset = "0x10")]
      public int[] missions;
      [Token(Token = "0x400EE11")]
      [FieldOffset(Offset = "0x14")]
      public int[] missions_log;
      [Token(Token = "0x400EE12")]
      [FieldOffset(Offset = "0x18")]
      public string auto_status;

      [Token(Token = "0x600DEBA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEnd()
      {
      }
    }

    [Token(Token = "0x200321F")]
    [Serializable]
    public class RequestEndInput
    {
      [Token(Token = "0x400EE13")]
      [FieldOffset(Offset = "0x8")]
      public string use;
      [Token(Token = "0x400EE14")]
      [FieldOffset(Offset = "0xC")]
      public int n;

      [Token(Token = "0x600DEBB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEndInput()
      {
      }
    }

    [Token(Token = "0x2003220")]
    [Serializable]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400EE15")]
      [FieldOffset(Offset = "0xB0")]
      public Json_Gift[] advance_boss_reward;

      [Token(Token = "0x600DEBC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }
  }
}
