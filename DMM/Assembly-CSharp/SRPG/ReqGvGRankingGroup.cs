// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGRankingGroup
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
  [Token(Token = "0x2003278")]
  public class ReqGvGRankingGroup : WebAPI
  {
    [Token(Token = "0x600DF19")]
    [Address(RVA = "0xA99E40", Offset = "0xA98C40", VA = "0x10A99E40")]
    public ReqGvGRankingGroup(
      int gid,
      int gvg_group_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003279")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEF5")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400EEF6")]
      [FieldOffset(Offset = "0xC")]
      public int gvg_group_id;

      [Token(Token = "0x600DF1A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200327A")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEF7")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGRankingData[] ranking;
      [Token(Token = "0x400EEF8")]
      [FieldOffset(Offset = "0x10")]
      public long update_at;

      [Token(Token = "0x600DF1B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
