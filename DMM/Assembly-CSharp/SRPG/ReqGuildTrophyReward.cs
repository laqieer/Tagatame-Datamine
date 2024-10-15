// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildTrophyReward
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
  [Token(Token = "0x2003298")]
  public class ReqGuildTrophyReward : WebAPI
  {
    [Token(Token = "0x600DF39")]
    [Address(RVA = "0xA98F10", Offset = "0xA97D10", VA = "0x10A98F10")]
    public ReqGuildTrophyReward(
      ReqGuildTrophyReward.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003299")]
    [Serializable]
    public class RequestTrophy
    {
      [Token(Token = "0x400EF1E")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400EF1F")]
      [FieldOffset(Offset = "0xC")]
      public int ymd;

      [Token(Token = "0x600DF3A")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public RequestTrophy(string _iname, int _ymd)
      {
      }
    }

    [Token(Token = "0x200329A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF20")]
      [FieldOffset(Offset = "0x8")]
      public ReqGuildTrophyReward.RequestTrophy[] guild_trophies;

      [Token(Token = "0x600DF3B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DF3C")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public RequestParam(
        ReqGuildTrophyReward.RequestTrophy[] request_trophies)
      {
      }
    }

    [Token(Token = "0x200329B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF21")]
      [FieldOffset(Offset = "0x8")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x400EF22")]
      [FieldOffset(Offset = "0xC")]
      public Json_TrophyPlayerData player;
      [Token(Token = "0x400EF23")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400EF24")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;
      [Token(Token = "0x400EF25")]
      [FieldOffset(Offset = "0x18")]
      public Json_TrophyConceptCards cards;
      [Token(Token = "0x400EF26")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Artifact[] artifacts;

      [Token(Token = "0x600DF3D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
