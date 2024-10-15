// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneResetParamBase
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
  [Token(Token = "0x200301B")]
  public class ReqRuneResetParamBase : WebAPI
  {
    [Token(Token = "0x600DC7A")]
    [Address(RVA = "0xA7A630", Offset = "0xA79430", VA = "0x10A7A630")]
    public ReqRuneResetParamBase(
      ReqRuneResetParamBase.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200301C")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB74")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;
      [Token(Token = "0x400EB75")]
      [FieldOffset(Offset = "0x10")]
      public int cost_index;

      [Token(Token = "0x600DC7B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC7C")]
      [Address(RVA = "0xA7DD30", Offset = "0xA7CB30", VA = "0x10A7DD30")]
      public RequestParam(long _rune_id, int _cost_index)
      {
      }
    }

    [Token(Token = "0x200301D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB76")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EB77")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EB78")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC7D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
