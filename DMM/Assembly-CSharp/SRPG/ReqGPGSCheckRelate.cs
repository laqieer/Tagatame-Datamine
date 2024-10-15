// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGPGSCheckRelate
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
  [Token(Token = "0x2002EF3")]
  public class ReqGPGSCheckRelate : WebAPI
  {
    [Token(Token = "0x600DB3F")]
    [Address(RVA = "0xA6FCC0", Offset = "0xA6EAC0", VA = "0x10A6FCC0")]
    public ReqGPGSCheckRelate(
      ReqGPGSCheckRelate.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EF4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E96A")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;
      [Token(Token = "0x400E96B")]
      [FieldOffset(Offset = "0xC")]
      public string secret_key;

      [Token(Token = "0x600DB40")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EF5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E96C")]
      [FieldOffset(Offset = "0x8")]
      public int is_related;

      [Token(Token = "0x600DB41")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
