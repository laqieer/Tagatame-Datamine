// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRunePrideBoardReset
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
  [Token(Token = "0x20032CC")]
  public class ReqRunePrideBoardReset : WebAPI
  {
    [Token(Token = "0x600DF72")]
    [Address(RVA = "0xA9C000", Offset = "0xA9AE00", VA = "0x10A9C000")]
    public ReqRunePrideBoardReset(
      ReqRunePrideBoardReset.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032CD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF61")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;

      [Token(Token = "0x600DF73")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DF74")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long _unit_id)
      {
      }
    }

    [Token(Token = "0x20032CE")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF62")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;
      [Token(Token = "0x400EF63")]
      [FieldOffset(Offset = "0xC")]
      public JSON_RunePrideUsedItems return_items;
      [Token(Token = "0x400EF64")]
      [FieldOffset(Offset = "0x10")]
      public int pride_reset_cnt;

      [Token(Token = "0x600DF75")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
