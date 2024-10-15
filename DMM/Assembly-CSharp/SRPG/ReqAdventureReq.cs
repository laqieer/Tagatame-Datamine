// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureReq
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
  [Token(Token = "0x2002E43")]
  public class ReqAdventureReq : WebAPI
  {
    [Token(Token = "0x600DA87")]
    [Address(RVA = "0xA6B7E0", Offset = "0xA6A5E0", VA = "0x10A6B7E0")]
    public ReqAdventureReq(
      string area_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E44")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E855")]
      [FieldOffset(Offset = "0x8")]
      public string area_iname;

      [Token(Token = "0x600DA88")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E45")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E856")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureData[] adventure_areas;
      [Token(Token = "0x400E857")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400E858")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400E859")]
      [FieldOffset(Offset = "0x14")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400E85A")]
      [FieldOffset(Offset = "0x18")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400E85B")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] guild_trophies;

      [Token(Token = "0x600DA89")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
