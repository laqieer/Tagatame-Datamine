// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGDefenseRanking
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
  [Token(Token = "0x2003280")]
  public class ReqGvGDefenseRanking : WebAPI
  {
    [Token(Token = "0x600DF21")]
    [Address(RVA = "0xA994E0", Offset = "0xA982E0", VA = "0x10A994E0")]
    public ReqGvGDefenseRanking(
      int gid,
      int gvg_group_id,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003281")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF01")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400EF02")]
      [FieldOffset(Offset = "0xC")]
      public int gvg_group_id;
      [Token(Token = "0x400EF03")]
      [FieldOffset(Offset = "0x10")]
      public int page;

      [Token(Token = "0x600DF22")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003282")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF04")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGScoreRanking[] ranking_defense_num;
      [Token(Token = "0x400EF05")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;

      [Token(Token = "0x600DF23")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
