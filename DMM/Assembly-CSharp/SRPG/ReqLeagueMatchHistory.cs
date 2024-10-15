// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchHistory
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
  [Token(Token = "0x2002F7B")]
  public class ReqLeagueMatchHistory : WebAPI
  {
    [Token(Token = "0x600DBCE")]
    [Address(RVA = "0xA75FE0", Offset = "0xA74DE0", VA = "0x10A75FE0")]
    public ReqLeagueMatchHistory(
      int page_num,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F7C")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA45")]
      [FieldOffset(Offset = "0x8")]
      public int page_id;

      [Token(Token = "0x600DBCF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F7D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA46")]
      [FieldOffset(Offset = "0x8")]
      public int yymmdd;
      [Token(Token = "0x400EA47")]
      [FieldOffset(Offset = "0xC")]
      public JSON_LeagueMatchHistory[] histories;
      [Token(Token = "0x400EA48")]
      [FieldOffset(Offset = "0x10")]
      public int count;

      [Token(Token = "0x600DBD0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
