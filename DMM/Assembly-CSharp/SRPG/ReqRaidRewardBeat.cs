// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRewardBeat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FC9")]
  public class ReqRaidRewardBeat : WebAPI
  {
    [Token(Token = "0x600DC1D")]
    [Address(RVA = "0xA795D0", Offset = "0xA783D0", VA = "0x10A795D0")]
    public ReqRaidRewardBeat(
      int area_id,
      int boss_id,
      int round,
      string uid,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FCA")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EAD1")]
      [FieldOffset(Offset = "0x8")]
      public int area_id;
      [Token(Token = "0x400EAD2")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400EAD3")]
      [FieldOffset(Offset = "0x10")]
      public int round;
      [Token(Token = "0x400EAD4")]
      [FieldOffset(Offset = "0x14")]
      public string uid;

      [Token(Token = "0x600DC1E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FCB")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EAD5")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EAD6")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EAD7")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400EAD8")]
      [FieldOffset(Offset = "0x14")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EAD9")]
      [FieldOffset(Offset = "0x18")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EADA")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Gift[] raid_beat_reward;
      [Token(Token = "0x400EADB")]
      [FieldOffset(Offset = "0x20")]
      public Json_Gift[] raid_damage_ratio_reward;
      [Token(Token = "0x400EADC")]
      [FieldOffset(Offset = "0x24")]
      public Json_Gift[] raid_damage_amount_reward;
      [Token(Token = "0x400EADD")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EADE")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400EADF")]
      [FieldOffset(Offset = "0x30")]
      public int rune_storage_used;
      [Token(Token = "0x400EAE0")]
      [FieldOffset(Offset = "0x34")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400EAE1")]
      [FieldOffset(Offset = "0x38")]
      public Json_Disassemble[] disassemble_rewards;

      [Token(Token = "0x600DC1F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
