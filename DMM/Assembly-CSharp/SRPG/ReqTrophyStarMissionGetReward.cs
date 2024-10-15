// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTrophyStarMissionGetReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200323E")]
  public class ReqTrophyStarMissionGetReward : WebAPI
  {
    [Token(Token = "0x600DEDC")]
    [Address(RVA = "0xA9EFD0", Offset = "0xA9DDD0", VA = "0x10A9EFD0")]
    public ReqTrophyStarMissionGetReward(
      string tsm_iname,
      int get_index,
      int ymd,
      int daily_ymd,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200323F")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE50")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400EE51")]
      [FieldOffset(Offset = "0xC")]
      public int idx;
      [Token(Token = "0x400EE52")]
      [FieldOffset(Offset = "0x10")]
      public int ymd;
      [Token(Token = "0x400EE53")]
      [FieldOffset(Offset = "0x14")]
      public int daily_ymd;

      [Token(Token = "0x600DEDD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003240")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE54")]
      [FieldOffset(Offset = "0x8")]
      public ReqTrophyStarMission.StarMission star_mission;
      [Token(Token = "0x400EE55")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EE56")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400EE57")]
      [FieldOffset(Offset = "0x14")]
      public Json_Unit[] units;
      [Token(Token = "0x400EE58")]
      [FieldOffset(Offset = "0x18")]
      public ReqTrophyStarMissionGetReward.Response.JSON_StarMissionConceptCard[] cards;
      [Token(Token = "0x400EE59")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EE5A")]
      [FieldOffset(Offset = "0x20")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EE5B")]
      [FieldOffset(Offset = "0x24")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DEDE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }

      [Token(Token = "0x2003241")]
      [MessagePackObject(true)]
      [Serializable]
      public class JSON_StarMissionConceptCard
      {
        [Token(Token = "0x400EE5C")]
        [FieldOffset(Offset = "0x8")]
        public string iname;
        [Token(Token = "0x400EE5D")]
        [FieldOffset(Offset = "0xC")]
        public int num;
        [Token(Token = "0x400EE5E")]
        [FieldOffset(Offset = "0x10")]
        public string get_unit;
        [Token(Token = "0x400EE5F")]
        [FieldOffset(Offset = "0x14")]
        public int is_mail;

        [Token(Token = "0x600DEDF")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JSON_StarMissionConceptCard()
        {
        }
      }
    }
  }
}
