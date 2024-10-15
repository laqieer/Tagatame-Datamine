// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitTruthEquipLvup
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
  [Token(Token = "0x20032BC")]
  public class ReqUnitTruthEquipLvup : WebAPI
  {
    [Token(Token = "0x600DF5F")]
    [Address(RVA = "0xA9F6C0", Offset = "0xA9E4C0", VA = "0x10A9F6C0")]
    public ReqUnitTruthEquipLvup(
      long unit_iid,
      int add_level,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20032BD")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF51")]
      [FieldOffset(Offset = "0x8")]
      public long uiid;
      [Token(Token = "0x400EF52")]
      [FieldOffset(Offset = "0x10")]
      public int lvup_count;

      [Token(Token = "0x600DF60")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20032BE")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF53")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EF54")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EF55")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;

      [Token(Token = "0x600DF61")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
