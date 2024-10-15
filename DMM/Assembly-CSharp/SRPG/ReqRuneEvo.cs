// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneEvo
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
  [Token(Token = "0x2003010")]
  public class ReqRuneEvo : WebAPI
  {
    [Token(Token = "0x600DC6C")]
    [Address(RVA = "0xA7A1D0", Offset = "0xA78FD0", VA = "0x10A7A1D0")]
    public ReqRuneEvo(
      ReqRuneEvo.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003011")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB5D")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;

      [Token(Token = "0x600DC6D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC6E")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long _rune_id)
      {
      }
    }

    [Token(Token = "0x2003012")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB5E")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EB5F")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EB60")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;

      [Token(Token = "0x600DC6F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
