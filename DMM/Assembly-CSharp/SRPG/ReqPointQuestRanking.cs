// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuestRanking
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
  [Token(Token = "0x2002FB0")]
  public class ReqPointQuestRanking : WebAPI
  {
    [Token(Token = "0x600DC04")]
    [Address(RVA = "0xA77C90", Offset = "0xA76A90", VA = "0x10A77C90")]
    public ReqPointQuestRanking(
      string eventIname,
      int eventPage,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FB1")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA90")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;
      [Token(Token = "0x400EA91")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DC05")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FB2")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA92")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestRankingData[] ranking;
      [Token(Token = "0x400EA93")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PointQuestRankingData my_ranking;
      [Token(Token = "0x400EA94")]
      [FieldOffset(Offset = "0x10")]
      public int total_page;

      [Token(Token = "0x600DC06")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
