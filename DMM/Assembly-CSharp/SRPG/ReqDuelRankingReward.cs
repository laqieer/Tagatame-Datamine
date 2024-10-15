// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDuelRankingReward
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
  [Token(Token = "0x2002ED6")]
  public class ReqDuelRankingReward : WebAPI
  {
    [Token(Token = "0x600DB22")]
    [Address(RVA = "0xA6F780", Offset = "0xA6E580", VA = "0x10A6F780")]
    public ReqDuelRankingReward(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002ED7")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E91C")]
      [FieldOffset(Offset = "0x8")]
      public JSON_DuelDailyRankingRewardData daily;
      [Token(Token = "0x400E91D")]
      [FieldOffset(Offset = "0xC")]
      public JSON_DuelSeasonRankingRewardData season;
      [Token(Token = "0x400E91E")]
      [FieldOffset(Offset = "0x10")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400E91F")]
      [FieldOffset(Offset = "0x14")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400E920")]
      [FieldOffset(Offset = "0x18")]
      public Json_Item[] items;
      [Token(Token = "0x400E921")]
      [FieldOffset(Offset = "0x1C")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x600DB23")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
