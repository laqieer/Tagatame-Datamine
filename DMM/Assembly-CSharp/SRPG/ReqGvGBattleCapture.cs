// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGBattleCapture
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
  [Token(Token = "0x2003275")]
  public class ReqGvGBattleCapture : WebAPI
  {
    [Token(Token = "0x600DF16")]
    [Address(RVA = "0xA99050", Offset = "0xA97E50", VA = "0x10A99050")]
    public ReqGvGBattleCapture(
      int id,
      int gid,
      int gvg_group_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003276")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEEE")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEEF")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EEF0")]
      [FieldOffset(Offset = "0x10")]
      public int gvg_group_id;

      [Token(Token = "0x600DF17")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003277")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEF1")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGNodeData[] nodes;
      [Token(Token = "0x400EEF2")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GvGUsedUnitData[] used_units;
      [Token(Token = "0x400EEF3")]
      [FieldOffset(Offset = "0x10")]
      public int refresh_wait_sec;
      [Token(Token = "0x400EEF4")]
      [FieldOffset(Offset = "0x14")]
      public int auto_refresh_wait_sec;

      [Token(Token = "0x600DF18")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
