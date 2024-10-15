// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitUsedUnit
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
  [Token(Token = "0x200303C")]
  public class ReqUnitUsedUnit : WebAPI
  {
    [Token(Token = "0x600DCA2")]
    [Address(RVA = "0xA7BD80", Offset = "0xA7AB80", VA = "0x10A7BD80")]
    public ReqUnitUsedUnit(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x200303D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB9C")]
      [FieldOffset(Offset = "0x8")]
      public long[] used_units;

      [Token(Token = "0x600DCA3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x200303E")]
    [MessagePackObject(true)]
    [Serializable]
    public class UnitUsedResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EB9D")]
      [FieldOffset(Offset = "0x28")]
      public ReqUnitUsedUnit.Response body;

      [Token(Token = "0x600DCA4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UnitUsedResponse()
      {
      }
    }
  }
}
