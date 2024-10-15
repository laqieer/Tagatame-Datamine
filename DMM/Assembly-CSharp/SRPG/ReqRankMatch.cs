// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003131")]
  public class ReqRankMatch : WebAPI
  {
    [Token(Token = "0x600DDC6")]
    [Address(RVA = "0xA8AEC0", Offset = "0xA89CC0", VA = "0x10A8AEC0")]
    public ReqRankMatch(
      string iname,
      int plid,
      int seat,
      string uid,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003132")]
    [Serializable]
    private class RequestParam
    {
      [Token(Token = "0x400ECD0")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400ECD1")]
      [FieldOffset(Offset = "0xC")]
      public string token;
      [Token(Token = "0x400ECD2")]
      [FieldOffset(Offset = "0x10")]
      public int plid;
      [Token(Token = "0x400ECD3")]
      [FieldOffset(Offset = "0x14")]
      public int seat;
      [Token(Token = "0x400ECD4")]
      [FieldOffset(Offset = "0x18")]
      public string uid;

      [Token(Token = "0x600DDC7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003133")]
    [Serializable]
    private class RequestParamNpc
    {
      [Token(Token = "0x400ECD5")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400ECD6")]
      [FieldOffset(Offset = "0xC")]
      public string token;
      [Token(Token = "0x400ECD7")]
      [FieldOffset(Offset = "0x10")]
      public int plid;
      [Token(Token = "0x400ECD8")]
      [FieldOffset(Offset = "0x14")]
      public int seat;
      [Token(Token = "0x400ECD9")]
      [FieldOffset(Offset = "0x18")]
      public int npc_id;

      [Token(Token = "0x600DDC8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParamNpc()
      {
      }
    }
  }
}
