// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitUsedItem
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
  [Token(Token = "0x2003039")]
  public class ReqUnitUsedItem : WebAPI
  {
    [Token(Token = "0x600DC9F")]
    [Address(RVA = "0xA7BCB0", Offset = "0xA7AAB0", VA = "0x10A7BCB0")]
    public ReqUnitUsedItem(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x200303A")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB9A")]
      [FieldOffset(Offset = "0x8")]
      public long[] used_crystals;

      [Token(Token = "0x600DCA0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x200303B")]
    [MessagePackObject(true)]
    [Serializable]
    public class UnitUsedItemResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EB9B")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitUsedItem.Response body;

      [Token(Token = "0x600DCA1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitUsedItemResponse()
      {
      }
    }
  }
}
