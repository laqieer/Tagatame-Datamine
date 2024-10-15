// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBondRest
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
  [Token(Token = "0x20032B9")]
  public class ReqBondRest : WebAPI
  {
    [Token(Token = "0x600DF5C")]
    [Address(RVA = "0xA93D70", Offset = "0xA92B70", VA = "0x10A93D70")]
    public ReqBondRest(
      string _bond_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032BA")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF4C")]
      [FieldOffset(Offset = "0x8")]
      public string bond_iname;

      [Token(Token = "0x600DF5D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20032BB")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF4D")]
      [FieldOffset(Offset = "0x8")]
      public Json_BondData[] bonds;
      [Token(Token = "0x400EF4E")]
      [FieldOffset(Offset = "0xC")]
      public JSON_BondMaterialDatas[] mats;
      [Token(Token = "0x400EF4F")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;
      [Token(Token = "0x400EF50")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;

      [Token(Token = "0x600DF5E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
