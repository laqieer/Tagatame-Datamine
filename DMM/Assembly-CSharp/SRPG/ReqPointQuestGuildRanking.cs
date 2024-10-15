// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPointQuestGuildRanking
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
  [Token(Token = "0x2002FB3")]
  public class ReqPointQuestGuildRanking : WebAPI
  {
    [Token(Token = "0x600DC07")]
    [Address(RVA = "0xA77950", Offset = "0xA76750", VA = "0x10A77950")]
    public ReqPointQuestGuildRanking(
      string eventIname,
      int eventPage,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002FB4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA95")]
      [FieldOffset(Offset = "0x8")]
      public string event_iname;
      [Token(Token = "0x400EA96")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DC08")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FB5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA97")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PointQuestGuildRankingData[] ranking;
      [Token(Token = "0x400EA98")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PointQuestGuildRankingData my_ranking;
      [Token(Token = "0x400EA99")]
      [FieldOffset(Offset = "0x10")]
      public int total_page;

      [Token(Token = "0x600DC09")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
