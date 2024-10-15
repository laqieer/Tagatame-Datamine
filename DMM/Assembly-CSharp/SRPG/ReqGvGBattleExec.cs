// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGBattleExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003272")]
  public class ReqGvGBattleExec : WebAPI
  {
    [Token(Token = "0x600DF13")]
    [Address(RVA = "0xA99220", Offset = "0xA98020", VA = "0x10A99220")]
    public ReqGvGBattleExec(
      int id,
      int gid,
      int gvg_group_id,
      JSON_GvGBattleEndParam btlendparam,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003273")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EEE8")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x400EEE9")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GvGBattleEndParam btlendparam;
      [Token(Token = "0x400EEEA")]
      [FieldOffset(Offset = "0x10")]
      public int gid;
      [Token(Token = "0x400EEEB")]
      [FieldOffset(Offset = "0x14")]
      public int gvg_group_id;

      [Token(Token = "0x600DF14")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003274")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EEEC")]
      [FieldOffset(Offset = "0x8")]
      public int is_capture;
      [Token(Token = "0x400EEED")]
      [FieldOffset(Offset = "0xC")]
      public JSON_TrophyProgress[] guild_trophies;

      [Token(Token = "0x600DF15")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
