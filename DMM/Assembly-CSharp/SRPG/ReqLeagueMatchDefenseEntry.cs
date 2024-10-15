// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchDefenseEntry
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
  [Token(Token = "0x2002F66")]
  public class ReqLeagueMatchDefenseEntry : WebAPI
  {
    [Token(Token = "0x600DBB9")]
    [Address(RVA = "0xA75D60", Offset = "0xA74B60", VA = "0x10A75D60")]
    public ReqLeagueMatchDefenseEntry(
      ReqLeagueMatchDefenseEntry.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F67")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA2D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchDefenseEntry[] parties;

      [Token(Token = "0x600DBBA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F68")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA2E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchDefenseInfo defense_info;

      [Token(Token = "0x600DBBB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
