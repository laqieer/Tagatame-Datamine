// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBondLvUp
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
  [Token(Token = "0x20032B6")]
  public class ReqBondLvUp : WebAPI
  {
    [Token(Token = "0x600DF59")]
    [Address(RVA = "0xA93AF0", Offset = "0xA928F0", VA = "0x10A93AF0")]
    public ReqBondLvUp(
      string _bond_iname,
      JSON_BondLvUpMaterials[] _bond_materials,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032B7")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF46")]
      [FieldOffset(Offset = "0x8")]
      public string bond_iname;
      [Token(Token = "0x400EF47")]
      [FieldOffset(Offset = "0xC")]
      public JSON_BondLvUpMaterials[] materials;

      [Token(Token = "0x600DF5A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20032B8")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF48")]
      [FieldOffset(Offset = "0x8")]
      public Json_BondData[] bonds;
      [Token(Token = "0x400EF49")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EF4A")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400EF4B")]
      [FieldOffset(Offset = "0x14")]
      public JSON_BondMissionData[] missions;

      [Token(Token = "0x600DF5B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
