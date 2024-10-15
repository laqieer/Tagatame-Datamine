// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitRentalExec
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
  [Token(Token = "0x2003226")]
  public class ReqUnitRentalExec : WebAPI
  {
    [Token(Token = "0x600DEC2")]
    [Address(RVA = "0xA9F4E0", Offset = "0xA9E2E0", VA = "0x10A9F4E0")]
    public ReqUnitRentalExec(
      string rental_iname,
      string unit_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003227")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE26")]
      [FieldOffset(Offset = "0x8")]
      public string rental_iname;
      [Token(Token = "0x400EE27")]
      [FieldOffset(Offset = "0xC")]
      public string unit_iname;

      [Token(Token = "0x600DEC3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003228")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE28")]
      [FieldOffset(Offset = "0x8")]
      public Json_Unit[] units;

      [Token(Token = "0x600DEC4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
