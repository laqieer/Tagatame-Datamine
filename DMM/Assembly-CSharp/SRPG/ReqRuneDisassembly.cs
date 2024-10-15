// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneDisassembly
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
  [Token(Token = "0x2003016")]
  public class ReqRuneDisassembly : WebAPI
  {
    [Token(Token = "0x600DC74")]
    [Address(RVA = "0xA79E90", Offset = "0xA78C90", VA = "0x10A79E90")]
    public ReqRuneDisassembly(
      ReqRuneDisassembly.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003017")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB67")]
      [FieldOffset(Offset = "0x8")]
      public long[] rune_ids;

      [Token(Token = "0x600DC75")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC76")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public RequestParam(long[] _rune_ids)
      {
      }
    }

    [Token(Token = "0x2003018")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB68")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] items;
      [Token(Token = "0x400EB69")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EB6A")]
      [FieldOffset(Offset = "0x10")]
      public ReqRuneDisassembly.Response.Rewards[] rewards;
      [Token(Token = "0x400EB6B")]
      [FieldOffset(Offset = "0x14")]
      public long[] rune_ids;
      [Token(Token = "0x400EB6C")]
      [FieldOffset(Offset = "0x18")]
      public string result;
      [Token(Token = "0x400EB6D")]
      [FieldOffset(Offset = "0x1C")]
      public int rune_storage_used;

      [Token(Token = "0x600DC77")]
      [Address(RVA = "0xA7DFA0", Offset = "0xA7CDA0", VA = "0x10A7DFA0")]
      public ReqRuneDisassembly.Response.Result GetResult()
      {
        return new ReqRuneDisassembly.Response.Result();
      }

      [Token(Token = "0x600DC78")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }

      [Token(Token = "0x2003019")]
      public enum Result
      {
        [Token(Token = "0x400EB6F")] success,
        [Token(Token = "0x400EB70")] great,
        [Token(Token = "0x400EB71")] super,
      }

      [Token(Token = "0x200301A")]
      [MessagePackObject(true)]
      [Serializable]
      public class Rewards
      {
        [Token(Token = "0x400EB72")]
        [FieldOffset(Offset = "0x8")]
        public string iname;
        [Token(Token = "0x400EB73")]
        [FieldOffset(Offset = "0xC")]
        public int num;

        [Token(Token = "0x600DC79")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Rewards()
        {
        }
      }
    }
  }
}
