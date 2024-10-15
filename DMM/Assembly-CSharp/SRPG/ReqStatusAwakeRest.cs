// Decompiled with JetBrains decompiler
// Type: SRPG.ReqStatusAwakeRest
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
  [Token(Token = "0x2003048")]
  public class ReqStatusAwakeRest : WebAPI
  {
    [Token(Token = "0x600DCAE")]
    [Address(RVA = "0xA7B8F0", Offset = "0xA7A6F0", VA = "0x10A7B8F0")]
    public ReqStatusAwakeRest(
      long iid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003049")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBA9")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;

      [Token(Token = "0x600DCAF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200304A")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EBAA")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;
      [Token(Token = "0x400EBAB")]
      [FieldOffset(Offset = "0xC")]
      public Json_StatusAwakeData[] used_items;

      [Token(Token = "0x600DCB0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x200304B")]
    [MessagePackObject(true)]
    [Serializable]
    public class StatusAwakeRestResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EBAC")]
      [FieldOffset(Offset = "0x28")]
      public ReqStatusAwakeRest.Response body;

      [Token(Token = "0x600DCB1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StatusAwakeRestResponse()
      {
      }
    }
  }
}
