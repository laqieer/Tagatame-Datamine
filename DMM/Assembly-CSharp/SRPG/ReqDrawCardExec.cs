// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDrawCardExec
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
  [Token(Token = "0x2003234")]
  public class ReqDrawCardExec : WebAPI
  {
    [Token(Token = "0x600DED2")]
    [Address(RVA = "0xA96690", Offset = "0xA95490", VA = "0x10A96690")]
    public ReqDrawCardExec(
      int select_card_index,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003235")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE3B")]
      [FieldOffset(Offset = "0x8")]
      public int select_card_index;

      [Token(Token = "0x600DED3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003236")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE3C")]
      [FieldOffset(Offset = "0x8")]
      public ReqDrawCard.CardInfo draw_info;
      [Token(Token = "0x400EE3D")]
      [FieldOffset(Offset = "0xC")]
      public ReqDrawCard.Response.Status drawcard_current_status;
      [Token(Token = "0x400EE3E")]
      [FieldOffset(Offset = "0x10")]
      public ReqDrawCard.CardInfo.Card[] rewards;
      [Token(Token = "0x400EE3F")]
      [FieldOffset(Offset = "0x14")]
      public Json_PlayerData player;
      [Token(Token = "0x400EE40")]
      [FieldOffset(Offset = "0x18")]
      public Json_Item[] items;
      [Token(Token = "0x400EE41")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Unit[] units;
      [Token(Token = "0x400EE42")]
      [FieldOffset(Offset = "0x20")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EE43")]
      [FieldOffset(Offset = "0x24")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400EE44")]
      [FieldOffset(Offset = "0x28")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400EE45")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DED4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
