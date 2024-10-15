// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGPGSDevice
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
  [Token(Token = "0x2002EEA")]
  public class ReqGPGSDevice : WebAPI
  {
    [Token(Token = "0x600DB36")]
    [Address(RVA = "0xA6FD90", Offset = "0xA6EB90", VA = "0x10A6FD90")]
    public ReqGPGSDevice(
      ReqGPGSDevice.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EEB")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E95F")]
      [FieldOffset(Offset = "0x8")]
      public string auth_code;

      [Token(Token = "0x600DB37")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EEC")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E960")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;
      [Token(Token = "0x400E961")]
      [FieldOffset(Offset = "0xC")]
      public string secret_key;

      [Token(Token = "0x600DB38")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
