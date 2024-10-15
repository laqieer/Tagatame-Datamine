// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRunePrideOpen
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
  [Token(Token = "0x20032C3")]
  public class ReqRunePrideOpen : WebAPI
  {
    [Token(Token = "0x600DF66")]
    [Address(RVA = "0xA9C0A0", Offset = "0xA9AEA0", VA = "0x10A9C0A0")]
    public ReqRunePrideOpen(
      ReqRunePrideOpen.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032C4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF59")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;

      [Token(Token = "0x600DF67")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DF68")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long _unit_id)
      {
      }
    }

    [Token(Token = "0x20032C5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF5A")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;

      [Token(Token = "0x600DF69")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
