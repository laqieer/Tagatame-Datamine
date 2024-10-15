// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRunePridePotentialSet
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
  [Token(Token = "0x20032CF")]
  public class ReqRunePridePotentialSet : WebAPI
  {
    [Token(Token = "0x600DF76")]
    [Address(RVA = "0xA9C140", Offset = "0xA9AF40", VA = "0x10A9C140")]
    public ReqRunePridePotentialSet(
      ReqRunePridePotentialSet.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032D0")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF65")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400EF66")]
      [FieldOffset(Offset = "0x10")]
      public string bonus_iname;
      [Token(Token = "0x400EF67")]
      [FieldOffset(Offset = "0x14")]
      public int slot_num;
      [Token(Token = "0x400EF68")]
      [FieldOffset(Offset = "0x18")]
      public JSON_RunePrideSubMats[] materials;

      [Token(Token = "0x600DF77")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DF78")]
      [Address(RVA = "0xA9FA90", Offset = "0xA9E890", VA = "0x10A9FA90")]
      public RequestParam(
        long _unit_id,
        string _bonus_iname,
        int _slot_num,
        JSON_RunePrideSubMats[] _materials)
      {
      }
    }

    [Token(Token = "0x20032D1")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF69")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayer difference_update;

      [Token(Token = "0x600DF79")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
