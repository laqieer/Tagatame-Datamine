// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetSupportRanking
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
  [Token(Token = "0x20031BD")]
  public class ReqSetSupportRanking : WebAPI
  {
    [Token(Token = "0x600DE56")]
    [Address(RVA = "0xA9CCF0", Offset = "0xA9BAF0", VA = "0x10A9CCF0")]
    public ReqSetSupportRanking(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20031BE")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED7C")]
      [FieldOffset(Offset = "0x8")]
      public string date;
      [Token(Token = "0x400ED7D")]
      [FieldOffset(Offset = "0xC")]
      public JSON_SupportRankingUser user_ranking;
      [Token(Token = "0x400ED7E")]
      [FieldOffset(Offset = "0x10")]
      public JSON_SupportRankingUnit unit_ranking;

      [Token(Token = "0x600DE57")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
