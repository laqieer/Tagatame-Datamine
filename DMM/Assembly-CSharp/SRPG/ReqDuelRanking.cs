// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDuelRanking
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
  [Token(Token = "0x2002ED8")]
  public class ReqDuelRanking : WebAPI
  {
    [Token(Token = "0x600DB24")]
    [Address(RVA = "0xA6F850", Offset = "0xA6E650", VA = "0x10A6F850")]
    public ReqDuelRanking(
      int _type,
      int _page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002ED9")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E922")]
      [FieldOffset(Offset = "0x8")]
      public int type;
      [Token(Token = "0x400E923")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DB25")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EDA")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E924")]
      [FieldOffset(Offset = "0x8")]
      public JSON_DuelPlayerData[] duel_ranking;
      [Token(Token = "0x400E925")]
      [FieldOffset(Offset = "0xC")]
      public JSON_DuelPlayerData my_ranking;
      [Token(Token = "0x400E926")]
      [FieldOffset(Offset = "0x10")]
      public int total_page;

      [Token(Token = "0x600DB26")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
