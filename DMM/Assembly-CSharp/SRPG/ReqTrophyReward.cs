// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTrophyReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030F0")]
  public class ReqTrophyReward : WebAPI
  {
    [Token(Token = "0x600DD7C")]
    [Address(RVA = "0xA8BE20", Offset = "0xA8AC20", VA = "0x10A8BE20")]
    public static ReqTrophyReward.RequestParam CreateRequestParam(List<TrophyState> trophyprogs)
    {
      return (ReqTrophyReward.RequestParam) null;
    }

    [Token(Token = "0x600DD7D")]
    [Address(RVA = "0xA8C110", Offset = "0xA8AF10", VA = "0x10A8C110")]
    public ReqTrophyReward(
      ReqTrophyReward.RequestParam requestParam,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20030F1")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC4B")]
      [FieldOffset(Offset = "0x8")]
      public ReqTrophyReward.RequestParam_TrophyState[] trophyprogs;
      [Token(Token = "0x400EC4C")]
      [FieldOffset(Offset = "0xC")]
      public int trophy_star_ymd;
      [Token(Token = "0x400EC4D")]
      [FieldOffset(Offset = "0x10")]
      public int is_bulk_daily;

      [Token(Token = "0x600DD7E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20030F2")]
    [Serializable]
    public class RequestParam_TrophyState
    {
      [Token(Token = "0x400EC4E")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400EC4F")]
      [FieldOffset(Offset = "0xC")]
      public int[] pts;
      [Token(Token = "0x400EC50")]
      [FieldOffset(Offset = "0x10")]
      public int ymd;
      [Token(Token = "0x400EC51")]
      [FieldOffset(Offset = "0x14")]
      public int rewarded_at;

      [Token(Token = "0x600DD7F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam_TrophyState()
      {
      }
    }

    [Token(Token = "0x20030F3")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC52")]
      [FieldOffset(Offset = "0x8")]
      public Json_TrophyPlayerData player;
      [Token(Token = "0x400EC53")]
      [FieldOffset(Offset = "0xC")]
      public Json_Unit[] units;
      [Token(Token = "0x400EC54")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400EC55")]
      [FieldOffset(Offset = "0x14")]
      public Json_TrophyConceptCards concept_cards;
      [Token(Token = "0x400EC56")]
      [FieldOffset(Offset = "0x18")]
      public ReqTrophyStarMission.StarMission star_mission;
      [Token(Token = "0x400EC57")]
      [FieldOffset(Offset = "0x1C")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x600DD80")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
