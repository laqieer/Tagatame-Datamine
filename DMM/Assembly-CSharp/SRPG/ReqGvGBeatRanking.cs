// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGBeatRanking
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
  [Token(Token = "0x200327D")]
  public class ReqGvGBeatRanking : WebAPI
  {
    [Token(Token = "0x600DF1E")]
    [Address(RVA = "0xA99400", Offset = "0xA98200", VA = "0x10A99400")]
    public ReqGvGBeatRanking(
      int gid,
      int gvg_group_id,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200327E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEFC")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400EEFD")]
      [FieldOffset(Offset = "0xC")]
      public int gvg_group_id;
      [Token(Token = "0x400EEFE")]
      [FieldOffset(Offset = "0x10")]
      public int page;

      [Token(Token = "0x600DF1F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200327F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEFF")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGScoreRanking[] ranking_beat;
      [Token(Token = "0x400EF00")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;

      [Token(Token = "0x600DF20")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
