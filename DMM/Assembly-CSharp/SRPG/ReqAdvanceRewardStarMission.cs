// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdvanceRewardStarMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003221")]
  public class ReqAdvanceRewardStarMission : WebAPI
  {
    [Token(Token = "0x600DEBD")]
    [Address(RVA = "0xA932B0", Offset = "0xA920B0", VA = "0x10A932B0")]
    public ReqAdvanceRewardStarMission(
      string area_id,
      QuestDifficulties difficult,
      int[] star_index,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003222")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE16")]
      [FieldOffset(Offset = "0x8")]
      public string area_id;
      [Token(Token = "0x400EE17")]
      [FieldOffset(Offset = "0xC")]
      public int difficulty;
      [Token(Token = "0x400EE18")]
      [FieldOffset(Offset = "0x10")]
      public int[] star_index;

      [Token(Token = "0x600DEBE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003223")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE19")]
      [FieldOffset(Offset = "0x8")]
      public ReqBtlCom.AdvanceStar[] advance_stars;
      [Token(Token = "0x400EE1A")]
      [FieldOffset(Offset = "0xC")]
      public Json_Gift[] reward;
      [Token(Token = "0x400EE1B")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;
      [Token(Token = "0x400EE1C")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;
      [Token(Token = "0x400EE1D")]
      [FieldOffset(Offset = "0x18")]
      public Json_Unit[] units;
      [Token(Token = "0x400EE1E")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EE1F")]
      [FieldOffset(Offset = "0x20")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EE20")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EE21")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DEBF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
