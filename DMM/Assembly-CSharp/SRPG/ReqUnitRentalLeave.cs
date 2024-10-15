// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitRentalLeave
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
  [Token(Token = "0x200322C")]
  public class ReqUnitRentalLeave : WebAPI
  {
    [Token(Token = "0x600DEC8")]
    [Address(RVA = "0xA9F5D0", Offset = "0xA9E3D0", VA = "0x10A9F5D0")]
    public ReqUnitRentalLeave(
      string rental_iname,
      string unit_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200322D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE2C")]
      [FieldOffset(Offset = "0x8")]
      public string rental_iname;
      [Token(Token = "0x400EE2D")]
      [FieldOffset(Offset = "0xC")]
      public string unit_iname;

      [Token(Token = "0x600DEC9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200322E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE2E")]
      [FieldOffset(Offset = "0x8")]
      public string leave_unit_iname;
      [Token(Token = "0x400EE2F")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] return_items;
      [Token(Token = "0x400EE30")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;

      [Token(Token = "0x600DECA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
