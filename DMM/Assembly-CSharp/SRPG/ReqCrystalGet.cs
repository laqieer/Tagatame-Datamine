// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalGet
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
  [Token(Token = "0x2002EAF")]
  public class ReqCrystalGet : WebAPI
  {
    [Token(Token = "0x600DAFB")]
    [Address(RVA = "0xA6E750", Offset = "0xA6D550", VA = "0x10A6E750")]
    public ReqCrystalGet(
      long last_iid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EB0")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8E2")]
      [FieldOffset(Offset = "0x8")]
      public long last_iid;

      [Token(Token = "0x600DAFC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EB1")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8E3")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CrystalData[] crystals;

      [Token(Token = "0x600DAFD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
