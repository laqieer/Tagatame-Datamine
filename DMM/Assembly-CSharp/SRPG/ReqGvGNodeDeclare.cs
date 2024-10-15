// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGNodeDeclare
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
  [Token(Token = "0x2003263")]
  public class ReqGvGNodeDeclare : WebAPI
  {
    [Token(Token = "0x600DF04")]
    [Address(RVA = "0xA99790", Offset = "0xA98590", VA = "0x10A99790")]
    public ReqGvGNodeDeclare(
      int id,
      int gid,
      int gvg_group_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003264")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEAF")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEB0")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EEB1")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;

      [Token(Token = "0x600DF05")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003265")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEB2")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGNodeData[] nodes;
      [Token(Token = "0x400EEB3")]
      [FieldOffset(Offset = "0xC")]
      public int declare_num;
      [Token(Token = "0x400EEB4")]
      [FieldOffset(Offset = "0x10")]
      public int refresh_wait_sec;
      [Token(Token = "0x400EEB5")]
      [FieldOffset(Offset = "0x14")]
      public int auto_refresh_wait_sec;
      [Token(Token = "0x400EEB6")]
      [FieldOffset(Offset = "0x18")]
      public int declare_cool_time;

      [Token(Token = "0x600DF06")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
