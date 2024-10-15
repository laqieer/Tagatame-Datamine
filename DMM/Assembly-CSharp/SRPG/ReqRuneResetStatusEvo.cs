// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneResetStatusEvo
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
  [Token(Token = "0x200301E")]
  public class ReqRuneResetStatusEvo : WebAPI
  {
    [Token(Token = "0x600DC7E")]
    [Address(RVA = "0xA7A700", Offset = "0xA79500", VA = "0x10A7A700")]
    public ReqRuneResetStatusEvo(
      ReqRuneResetStatusEvo.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200301F")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB79")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;
      [Token(Token = "0x400EB7A")]
      [FieldOffset(Offset = "0x10")]
      public int cost_index;
      [Token(Token = "0x400EB7B")]
      [FieldOffset(Offset = "0x14")]
      public int evo_slot;

      [Token(Token = "0x600DC7F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC80")]
      [Address(RVA = "0xA7DCA0", Offset = "0xA7CAA0", VA = "0x10A7DCA0")]
      public RequestParam(long _rune_id, int _cost_index, int _evo_slot)
      {
      }
    }

    [Token(Token = "0x2003020")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB7C")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EB7D")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EB7E")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC81")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
