// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCustomApi
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
  [Token(Token = "0x20032AE")]
  public class ReqCustomApi : WebAPI
  {
    [Token(Token = "0x600DF50")]
    [Address(RVA = "0xA96610", Offset = "0xA95410", VA = "0x10A96610")]
    public ReqCustomApi(
      string api_name,
      string req_body,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x600DF51")]
    [Address(RVA = "0xA96540", Offset = "0xA95340", VA = "0x10A96540")]
    public ReqCustomApi(
      string api_name,
      string[] req_values,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032AF")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF3B")]
      [FieldOffset(Offset = "0x8")]
      public string[] req_values;

      [Token(Token = "0x600DF52")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20032B0")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF3C")]
      [FieldOffset(Offset = "0x8")]
      public string[] res_values;

      [Token(Token = "0x600DF53")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
