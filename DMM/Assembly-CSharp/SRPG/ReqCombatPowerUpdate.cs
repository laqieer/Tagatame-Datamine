// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCombatPowerUpdate
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
  [Token(Token = "0x2002E7F")]
  public class ReqCombatPowerUpdate : WebAPI
  {
    [Token(Token = "0x600DAC5")]
    [Address(RVA = "0xA6DF50", Offset = "0xA6CD50", VA = "0x10A6DF50")]
    public static ReqCombatPowerUpdate.Request.CombatPowers CreateValue(long value, EElement elem)
    {
      return (ReqCombatPowerUpdate.Request.CombatPowers) null;
    }

    [Token(Token = "0x600DAC6")]
    [Address(RVA = "0xA6E0B0", Offset = "0xA6CEB0", VA = "0x10A6E0B0")]
    public ReqCombatPowerUpdate(
      ReqCombatPowerUpdate.Request requst,
      string trophyProgs,
      string bingoProgs,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E80")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8AA")]
      [FieldOffset(Offset = "0x8")]
      public ReqCombatPowerUpdate.Request.CombatPowers[] combat_powers;
      [Token(Token = "0x400E8AB")]
      [FieldOffset(Offset = "0xC")]
      public UnitCombatPowers[] unit_combat_powers;
      [Token(Token = "0x400E8AC")]
      [FieldOffset(Offset = "0x10")]
      public string trophyProgs;
      [Token(Token = "0x400E8AD")]
      [FieldOffset(Offset = "0x14")]
      public string bingoProgs;

      [Token(Token = "0x600DAC7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }

      [Token(Token = "0x2002E81")]
      [Serializable]
      public class CombatPowers
      {
        [Token(Token = "0x400E8AE")]
        [FieldOffset(Offset = "0x8")]
        public string type;
        [Token(Token = "0x400E8AF")]
        [FieldOffset(Offset = "0x10")]
        public long power;

        [Token(Token = "0x600DAC8")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public CombatPowers()
        {
        }
      }
    }

    [Token(Token = "0x2002E82")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8B0")]
      [FieldOffset(Offset = "0x8")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x600DAC9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
