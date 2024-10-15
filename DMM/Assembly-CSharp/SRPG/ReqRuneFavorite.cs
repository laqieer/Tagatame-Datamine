// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneFavorite
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
  [Token(Token = "0x2003026")]
  public class ReqRuneFavorite : WebAPI
  {
    [Token(Token = "0x600DC88")]
    [Address(RVA = "0xA7A2A0", Offset = "0xA790A0", VA = "0x10A7A2A0")]
    public ReqRuneFavorite(
      ReqRuneFavorite.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003027")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB88")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;
      [Token(Token = "0x400EB89")]
      [FieldOffset(Offset = "0x10")]
      public int favorite;

      [Token(Token = "0x600DC89")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC8A")]
      [Address(RVA = "0xA7DCD0", Offset = "0xA7CAD0", VA = "0x10A7DCD0")]
      public RequestParam(long runeId, bool isFavorite)
      {
      }
    }

    [Token(Token = "0x2003028")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB8A")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData rune;

      [Token(Token = "0x600DC8B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
