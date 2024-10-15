// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGNodeDetail
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
  [Token(Token = "0x2003260")]
  public class ReqGvGNodeDetail : WebAPI
  {
    [Token(Token = "0x600DF01")]
    [Address(RVA = "0xA99970", Offset = "0xA98770", VA = "0x10A99970")]
    public ReqGvGNodeDetail(
      int id,
      int gid,
      int gvg_group_id,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003261")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEA8")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEA9")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EEAA")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;
      [Token(Token = "0x400EEAB")]
      [FieldOffset(Offset = "0x14")]
      public int page;

      [Token(Token = "0x600DF02")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003262")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEAC")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGParty[] defenses;
      [Token(Token = "0x400EEAD")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;
      [Token(Token = "0x400EEAE")]
      [FieldOffset(Offset = "0x10")]
      public int total_beat_num;

      [Token(Token = "0x600DF03")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
