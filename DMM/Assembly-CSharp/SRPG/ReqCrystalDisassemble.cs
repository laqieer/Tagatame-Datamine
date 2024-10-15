// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalDisassemble
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
  [Token(Token = "0x2002EB8")]
  public class ReqCrystalDisassemble : WebAPI
  {
    [Token(Token = "0x600DB04")]
    [Address(RVA = "0xA6E510", Offset = "0xA6D310", VA = "0x10A6E510")]
    public ReqCrystalDisassemble(
      long _crystal_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EB9")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8EF")]
      [FieldOffset(Offset = "0x8")]
      public long crystal_id;

      [Token(Token = "0x600DB05")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EBA")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8F0")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CrystalData[] new_crystals;
      [Token(Token = "0x400E8F1")]
      [FieldOffset(Offset = "0xC")]
      public JSON_CrystalDifference difference_update;
      [Token(Token = "0x400E8F2")]
      [FieldOffset(Offset = "0x10")]
      public long material_id;

      [Token(Token = "0x600DB06")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
