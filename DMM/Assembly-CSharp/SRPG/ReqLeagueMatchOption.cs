// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchOption
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
  [Token(Token = "0x2002F90")]
  public class ReqLeagueMatchOption : WebAPI
  {
    [Token(Token = "0x600DBE3")]
    [Address(RVA = "0xA76350", Offset = "0xA75150", VA = "0x10A76350")]
    public ReqLeagueMatchOption(
      ReqLeagueMatchOption.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F91")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA5C")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchOption options;

      [Token(Token = "0x600DBE4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F92")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA5D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchOption options;

      [Token(Token = "0x600DBE5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
