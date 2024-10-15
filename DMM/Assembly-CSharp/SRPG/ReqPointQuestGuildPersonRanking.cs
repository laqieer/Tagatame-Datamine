// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuestGuildPersonRanking
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
  [Token(Token = "0x2002FB6")]
  public class ReqPointQuestGuildPersonRanking : WebAPI
  {
    [Token(Token = "0x600DC0A")]
    [Address(RVA = "0xA77840", Offset = "0xA76640", VA = "0x10A77840")]
    public ReqPointQuestGuildPersonRanking(
      string eventIname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FB7")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA9A")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;

      [Token(Token = "0x600DC0B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FB8")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA9B")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestRankingData[] ranking;
      [Token(Token = "0x400EA9C")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PointQuestRankingData my_ranking;

      [Token(Token = "0x600DC0C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
