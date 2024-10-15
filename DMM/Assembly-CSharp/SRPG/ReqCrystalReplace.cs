// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalReplace
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
  [Token(Token = "0x2002ECD")]
  public class ReqCrystalReplace : WebAPI
  {
    [Token(Token = "0x600DB19")]
    [Address(RVA = "0xA6EA90", Offset = "0xA6D890", VA = "0x10A6EA90")]
    public ReqCrystalReplace(
      long _unit_id,
      long _replace_unit_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002ECE")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E90B")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400E90C")]
      [FieldOffset(Offset = "0x10")]
      public long replace_unit_id;

      [Token(Token = "0x600DB1A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002ECF")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E90D")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DB1B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
