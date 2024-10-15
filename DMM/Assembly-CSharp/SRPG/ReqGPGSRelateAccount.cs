// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGPGSRelateAccount
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
  [Token(Token = "0x2002EED")]
  public class ReqGPGSRelateAccount : WebAPI
  {
    [Token(Token = "0x600DB39")]
    [Address(RVA = "0xA6FF30", Offset = "0xA6ED30", VA = "0x10A6FF30")]
    public ReqGPGSRelateAccount(
      ReqGPGSRelateAccount.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EEE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E962")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;
      [Token(Token = "0x400E963")]
      [FieldOffset(Offset = "0xC")]
      public string secret_key;
      [Token(Token = "0x400E964")]
      [FieldOffset(Offset = "0x10")]
      public string auth_code;

      [Token(Token = "0x600DB3A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EEF")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E965")]
      [FieldOffset(Offset = "0x8")]
      public int is_succeeded;

      [Token(Token = "0x600DB3B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
