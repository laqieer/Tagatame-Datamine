// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidBtlEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200306A")]
  public class ReqWorldRaidBtlEnd : WebAPI
  {
    [Token(Token = "0x600DCD2")]
    [Address(RVA = "0xA7CEA0", Offset = "0xA7BCA0", VA = "0x10A7CEA0")]
    public ReqWorldRaidBtlEnd(
      long btlid,
      BtlResultTypes result,
      string bossId,
      int[] damages,
      List<Unit> enemyUnits,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response,
      BattleCore.Record record = null,
      string trophyprog = null,
      string bingoprog = null)
    {
    }

    [Token(Token = "0x200306B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBDA")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;
      [Token(Token = "0x400EBDB")]
      [FieldOffset(Offset = "0x10")]
      public string status;
      [Token(Token = "0x400EBDC")]
      [FieldOffset(Offset = "0x14")]
      public JSON_WorldRaidBossData boss_info;
      [Token(Token = "0x400EBDD")]
      [FieldOffset(Offset = "0x18")]
      public ReqWorldRaidBtlEnd.RequestEnd btlendparam;

      [Token(Token = "0x600DCD3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200306C")]
    [Serializable]
    public class RequestEnd
    {
      [Token(Token = "0x400EBDE")]
      [FieldOffset(Offset = "0x8")]
      public ReqWorldRaidBtlEnd.RequestEndInput[] inputs;
      [Token(Token = "0x400EBDF")]
      [FieldOffset(Offset = "0xC")]
      public string auto_status;
      [Token(Token = "0x400EBE0")]
      [FieldOffset(Offset = "0x10")]
      public int[] damages;

      [Token(Token = "0x600DCD4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEnd()
      {
      }
    }

    [Token(Token = "0x200306D")]
    [Serializable]
    public class RequestEndInput
    {
      [Token(Token = "0x400EBE1")]
      [FieldOffset(Offset = "0x8")]
      public string use;
      [Token(Token = "0x400EBE2")]
      [FieldOffset(Offset = "0xC")]
      public int n;

      [Token(Token = "0x600DCD5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestEndInput()
      {
      }
    }

    [Token(Token = "0x200306E")]
    [Serializable]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400EBE3")]
      [FieldOffset(Offset = "0xB0")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400EBE4")]
      [FieldOffset(Offset = "0xB4")]
      public int is_mail_cards;
      [Token(Token = "0x400EBE5")]
      [FieldOffset(Offset = "0xB8")]
      public Json_BtlRewardConceptCard[] cards;
      [Token(Token = "0x400EBE6")]
      [FieldOffset(Offset = "0xBC")]
      public JSON_WorldRaidBossData boss_info;
      [Token(Token = "0x400EBE7")]
      [FieldOffset(Offset = "0xC0")]
      public ReqWorldRaidBtlEnd.ResponseReward reward;
      [Token(Token = "0x400EBE8")]
      [FieldOffset(Offset = "0xC8")]
      public long total_damage;
      [Token(Token = "0x400EBE9")]
      [FieldOffset(Offset = "0xD0")]
      public Json_Disassemble[] disassemble_rewards;

      [Token(Token = "0x600DCD6")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }

    [Token(Token = "0x200306F")]
    [Serializable]
    public class ResponseReward
    {
      [Token(Token = "0x400EBEA")]
      [FieldOffset(Offset = "0x8")]
      public JSON_WorldRaidBattleRewardData[] drop_lottery;
      [Token(Token = "0x400EBEB")]
      [FieldOffset(Offset = "0xC")]
      public JSON_WorldRaidBattleRewardData[] last_attack;

      [Token(Token = "0x600DCD7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ResponseReward()
      {
      }
    }
  }
}
