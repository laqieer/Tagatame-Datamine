// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGenesisRewardStarMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031F5")]
  public class ReqGenesisRewardStarMission : WebAPI
  {
    [Token(Token = "0x600DE91")]
    [Address(RVA = "0xA98B00", Offset = "0xA97900", VA = "0x10A98B00")]
    public ReqGenesisRewardStarMission(
      string area_id,
      QuestDifficulties difficult,
      int[] star_index,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031F6")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDB9")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EDBA")]
      [FieldOffset(Offset = "0xC")]
      public int difficulty;
      [Token(Token = "0x400EDBB")]
      [FieldOffset(Offset = "0x10")]
      public int[] star_index;

      [Token(Token = "0x600DE92")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031F7")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDBC")]
      [FieldOffset(Offset = "0x8")]
      public ReqBtlCom.GenesisStar[] genesis_stars;
      [Token(Token = "0x400EDBD")]
      [FieldOffset(Offset = "0xC")]
      public Json_Gift[] reward;
      [Token(Token = "0x400EDBE")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;
      [Token(Token = "0x400EDBF")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;
      [Token(Token = "0x400EDC0")]
      [FieldOffset(Offset = "0x18")]
      public Json_Unit[] units;
      [Token(Token = "0x400EDC1")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EDC2")]
      [FieldOffset(Offset = "0x20")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EDC3")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EDC4")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DE93")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
