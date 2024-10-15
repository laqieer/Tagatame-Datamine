// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalUnitSet
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
  [Token(Token = "0x2002EC1")]
  public class ReqCrystalUnitSet : WebAPI
  {
    [Token(Token = "0x600DB0D")]
    [Address(RVA = "0xA6EDF0", Offset = "0xA6DBF0", VA = "0x10A6EDF0")]
    public ReqCrystalUnitSet(
      long _unit_iid,
      JSON_CrystalUnitSetReq[] _crystals,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EC2")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8FB")]
      [FieldOffset(Offset = "0x8")]
      public long unit_iid;
      [Token(Token = "0x400E8FC")]
      [FieldOffset(Offset = "0x10")]
      public JSON_CrystalUnitSetReq[] crystals;

      [Token(Token = "0x600DB0E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EC3")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8FD")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DB0F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
