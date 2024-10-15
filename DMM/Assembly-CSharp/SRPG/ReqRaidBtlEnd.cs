// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidBtlEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FDD")]
  public class ReqRaidBtlEnd : WebAPI
  {
    [Token(Token = "0x600DC31")]
    [Address(RVA = "0xA780A0", Offset = "0xA76EA0", VA = "0x10A780A0")]
    public ReqRaidBtlEnd(
      long btlid,
      BtlResultTypes result,
      int bossId,
      List<Unit> enemyUnits,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response,
      BattleCore.Record record = null,
      string trophyProgs = "",
      string bingoProgs = "")
    {
    }

    [Token(Token = "0x2002FDE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB0C")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400EB0D")]
      [FieldOffset(Offset = "0x10")]
      public string status;
      [Token(Token = "0x400EB0E")]
      [FieldOffset(Offset = "0x14")]
      public JSON_RaidBossInfo boss_info;
      [Token(Token = "0x400EB0F")]
      [FieldOffset(Offset = "0x18")]
      public ReqRaidBtlEnd.RequestEnd btlendparam;

      [Token(Token = "0x600DC32")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FDF")]
    [Serializable]
    public class RequestEnd
    {
      [Token(Token = "0x400EB10")]
      [FieldOffset(Offset = "0x8")]
      public ReqRaidBtlEnd.RequestEndInput[] inputs;
      [Token(Token = "0x400EB11")]
      [FieldOffset(Offset = "0xC")]
      public string auto_status;

      [Token(Token = "0x600DC33")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEnd()
      {
      }
    }

    [Token(Token = "0x2002FE0")]
    [Serializable]
    public class RequestEndInput
    {
      [Token(Token = "0x400EB12")]
      [FieldOffset(Offset = "0x8")]
      public string use;
      [Token(Token = "0x400EB13")]
      [FieldOffset(Offset = "0xC")]
      public int n;

      [Token(Token = "0x600DC34")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEndInput()
      {
      }
    }

    [Token(Token = "0x2002FE1")]
    [Serializable]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400EB14")]
      [FieldOffset(Offset = "0xB0")]
      public Json_Gift[] raid_battle_reward;
      [Token(Token = "0x400EB15")]
      [FieldOffset(Offset = "0xB4")]
      public int total_damage;
      [Token(Token = "0x400EB16")]
      [FieldOffset(Offset = "0xB8")]
      public string[] damage_ratio_reward_ids;
      [Token(Token = "0x400EB17")]
      [FieldOffset(Offset = "0xBC")]
      public string[] damage_amount_reward_ids;
      [Token(Token = "0x400EB18")]
      [FieldOffset(Offset = "0xC0")]
      public int is_timeover;
      [Token(Token = "0x400EB19")]
      [FieldOffset(Offset = "0xC4")]
      public Json_RuneData[] runes_detail;

      [Token(Token = "0x600DC35")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }
  }
}
