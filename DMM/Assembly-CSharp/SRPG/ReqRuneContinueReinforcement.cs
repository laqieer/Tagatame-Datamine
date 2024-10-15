// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneContinueReinforcement
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
  [Token(Token = "0x2003013")]
  public class ReqRuneContinueReinforcement : WebAPI
  {
    [Token(Token = "0x600DC70")]
    [Address(RVA = "0xA79CF0", Offset = "0xA78AF0", VA = "0x10A79CF0")]
    public ReqRuneContinueReinforcement(
      ReqRuneContinueReinforcement.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003014")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB61")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;
      [Token(Token = "0x400EB62")]
      [FieldOffset(Offset = "0x10")]
      public int enforce_num;
      [Token(Token = "0x400EB63")]
      [FieldOffset(Offset = "0x14")]
      public int evo_num;

      [Token(Token = "0x600DC71")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC72")]
      [Address(RVA = "0xA7DCA0", Offset = "0xA7CAA0", VA = "0x10A7DCA0")]
      public RequestParam(long _rune_id, int _enforce_num, int _evo_num)
      {
      }
    }

    [Token(Token = "0x2003015")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB64")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EB65")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EB66")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC73")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
