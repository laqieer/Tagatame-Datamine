// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGPGSDisrelateAccount
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
  [Token(Token = "0x2002EF0")]
  public class ReqGPGSDisrelateAccount : WebAPI
  {
    [Token(Token = "0x600DB3C")]
    [Address(RVA = "0xA6FE60", Offset = "0xA6EC60", VA = "0x10A6FE60")]
    public ReqGPGSDisrelateAccount(
      ReqGPGSDisrelateAccount.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EF1")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E966")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;
      [Token(Token = "0x400E967")]
      [FieldOffset(Offset = "0xC")]
      public string secret_key;
      [Token(Token = "0x400E968")]
      [FieldOffset(Offset = "0x10")]
      public string auth_code;

      [Token(Token = "0x600DB3D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EF2")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E969")]
      [FieldOffset(Offset = "0x8")]
      public int is_succeeded;

      [Token(Token = "0x600DB3E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
