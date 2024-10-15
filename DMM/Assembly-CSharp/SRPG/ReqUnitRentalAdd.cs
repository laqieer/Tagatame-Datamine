// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitRentalAdd
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
  [Token(Token = "0x2003229")]
  public class ReqUnitRentalAdd : WebAPI
  {
    [Token(Token = "0x600DEC5")]
    [Address(RVA = "0xA9F3F0", Offset = "0xA9E1F0", VA = "0x10A9F3F0")]
    public ReqUnitRentalAdd(
      string rental_iname,
      string unit_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200322A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE29")]
      [FieldOffset(Offset = "0x8")]
      public string rental_iname;
      [Token(Token = "0x400EE2A")]
      [FieldOffset(Offset = "0xC")]
      public string unit_iname;

      [Token(Token = "0x600DEC6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200322B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE2B")]
      [FieldOffset(Offset = "0x8")]
      public Json_Unit[] units;

      [Token(Token = "0x600DEC7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
