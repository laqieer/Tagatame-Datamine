// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGHalfTime
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
  [Token(Token = "0x2003283")]
  public class ReqGvGHalfTime : WebAPI
  {
    [Token(Token = "0x600DF24")]
    [Address(RVA = "0xA995C0", Offset = "0xA983C0", VA = "0x10A995C0")]
    public ReqGvGHalfTime(
      int gid,
      int gvg_group_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003284")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF06")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400EF07")]
      [FieldOffset(Offset = "0xC")]
      public int gvg_group_id;

      [Token(Token = "0x600DF25")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003285")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF08")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGHalfTime[] half_times;

      [Token(Token = "0x600DF26")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
