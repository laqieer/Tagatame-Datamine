// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchPartySetName
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
  [Token(Token = "0x2002F77")]
  public class ReqLeagueMatchPartySetName : WebAPI
  {
    [Token(Token = "0x600DBCA")]
    [Address(RVA = "0xA76420", Offset = "0xA75220", VA = "0x10A76420")]
    public ReqLeagueMatchPartySetName(
      ReqLeagueMatchPartySetName.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F78")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA42")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EA43")]
      [FieldOffset(Offset = "0xC")]
      public string party_name;

      [Token(Token = "0x600DBCB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F79")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x600DBCC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F7A")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchPartySetNameResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA44")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchPartySetName.Response body;

      [Token(Token = "0x600DBCD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchPartySetNameResponse()
      {
      }
    }
  }
}
