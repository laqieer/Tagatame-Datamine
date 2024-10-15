// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMasteryReward
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
  [Token(Token = "0x2002F98")]
  public class ReqMasteryReward : WebAPI
  {
    [Token(Token = "0x600DBEB")]
    [Address(RVA = "0xA76AD0", Offset = "0xA758D0", VA = "0x10A76AD0")]
    public ReqMasteryReward(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F99")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA65")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EA66")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;
      [Token(Token = "0x400EA67")]
      [FieldOffset(Offset = "0x10")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EA68")]
      [FieldOffset(Offset = "0x14")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400EA69")]
      [FieldOffset(Offset = "0x18")]
      public JSON_MasteryRewardsItemData[] rewards;
      [Token(Token = "0x400EA6A")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_MasteryRewardStatusData[] mastery_rewards;
      [Token(Token = "0x400EA6B")]
      [FieldOffset(Offset = "0x20")]
      public int mastery_rank;

      [Token(Token = "0x600DBEC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
