// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlComCombatPowerOpen
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
  [Token(Token = "0x2002E89")]
  public class ReqBtlComCombatPowerOpen : WebAPI
  {
    [Token(Token = "0x600DAD0")]
    [Address(RVA = "0xA6D630", Offset = "0xA6C430", VA = "0x10A6D630")]
    public ReqBtlComCombatPowerOpen(
      ReqBtlComCombatPowerOpen.Request requestParam,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E8A")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8B6")]
      [FieldOffset(Offset = "0x8")]
      public ReqBtlComCombatPowerOpen.RequestArea[] areas;
      [Token(Token = "0x400E8B7")]
      [FieldOffset(Offset = "0xC")]
      public ReqBtlComCombatPowerOpen.RequestQuest[] quests;

      [Token(Token = "0x600DAD1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }

    [Token(Token = "0x2002E8B")]
    [Serializable]
    public class RequestArea
    {
      [Token(Token = "0x400E8B8")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400E8B9")]
      [FieldOffset(Offset = "0xC")]
      public int combat_power;
      [Token(Token = "0x400E8BA")]
      [FieldOffset(Offset = "0x10")]
      public long[] unit_iids;

      [Token(Token = "0x600DAD2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestArea()
      {
      }
    }

    [Token(Token = "0x2002E8C")]
    [Serializable]
    public class RequestQuest
    {
      [Token(Token = "0x400E8BB")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400E8BC")]
      [FieldOffset(Offset = "0xC")]
      public int combat_power;
      [Token(Token = "0x400E8BD")]
      [FieldOffset(Offset = "0x10")]
      public long[] unit_iids;

      [Token(Token = "0x600DAD3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestQuest()
      {
      }
    }

    [Token(Token = "0x2002E8D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8BE")]
      [FieldOffset(Offset = "0x8")]
      public JSON_QuestCombatPowers combat_powers;

      [Token(Token = "0x600DAD4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
