// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRunePrideUsedItems
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
  [Token(Token = "0x20032C9")]
  public class ReqRunePrideUsedItems : WebAPI
  {
    [Token(Token = "0x600DF6E")]
    [Address(RVA = "0xA9C1E0", Offset = "0xA9AFE0", VA = "0x10A9C1E0")]
    public ReqRunePrideUsedItems(
      ReqRunePrideUsedItems.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032CA")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF5F")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;

      [Token(Token = "0x600DF6F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DF70")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long _unit_id)
      {
      }
    }

    [Token(Token = "0x20032CB")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF60")]
      [FieldOffset(Offset = "0x8")]
      public JSON_RunePrideUsedItems used_items;

      [Token(Token = "0x600DF71")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
