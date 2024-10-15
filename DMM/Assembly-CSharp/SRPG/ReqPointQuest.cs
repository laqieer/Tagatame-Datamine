// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuest
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
  [Token(Token = "0x2002FAD")]
  public class ReqPointQuest : WebAPI
  {
    [Token(Token = "0x600DC01")]
    [Address(RVA = "0xA77EC0", Offset = "0xA76CC0", VA = "0x10A77EC0")]
    public ReqPointQuest(
      string eventIname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FAE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA89")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;

      [Token(Token = "0x600DC02")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FAF")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA8A")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestRewardStatusData[] reward_statuses;
      [Token(Token = "0x400EA8B")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PointQuestBestPointData[] best_points;
      [Token(Token = "0x400EA8C")]
      [FieldOffset(Offset = "0x10")]
      public JSON_ShopListArray.Shops shop;
      [Token(Token = "0x400EA8D")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PointQuestPlayerInfoData my_info;
      [Token(Token = "0x400EA8E")]
      [FieldOffset(Offset = "0x18")]
      public int is_reward;
      [Token(Token = "0x400EA8F")]
      [FieldOffset(Offset = "0x1C")]
      public int is_guild_reward;

      [Token(Token = "0x600DC03")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
