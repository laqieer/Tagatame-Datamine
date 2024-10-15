// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGPartyNameSet
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
  [Token(Token = "0x200328E")]
  public class ReqGvGPartyNameSet : WebAPI
  {
    [Token(Token = "0x600DF2F")]
    [Address(RVA = "0xA99BF0", Offset = "0xA989F0", VA = "0x10A99BF0")]
    public ReqGvGPartyNameSet(
      int party_no,
      string party_name,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200328F")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF18")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EF19")]
      [FieldOffset(Offset = "0xC")]
      public string party_name;

      [Token(Token = "0x600DF30")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003290")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x600DF31")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
