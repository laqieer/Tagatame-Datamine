// Decompiled with JetBrains decompiler
// Type: SRPG.BondMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019B4")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondMissionParam
  {
    [Token(Token = "0x17000B18")]
    public string Iname
    {
      [Token(Token = "0x60068DA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068DB"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000B19")]
    public string ConditionStr
    {
      [Token(Token = "0x60068DC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068DD"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000B1A")]
    public int ConditionNum
    {
      [Token(Token = "0x60068DE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60068DF"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17000B1B")]
    public string Expr
    {
      [Token(Token = "0x60068E0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068E1"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000B1C")]
    public List<BondMissionRewardParam> Rewards
    {
      [Token(Token = "0x60068E2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<BondMissionRewardParam>) null;
      }
      [Token(Token = "0x60068E3"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x60068E4")]
    [Address(RVA = "0x34D5F0", Offset = "0x34C3F0", VA = "0x1034D5F0")]
    public bool Deserialize(Json_BondMissionParam json) => new bool();

    [Token(Token = "0x60068E5")]
    [Address(RVA = "0x34D380", Offset = "0x34C180", VA = "0x1034D380")]
    public static void Deserialize(ref List<BondMissionParam> param, Json_BondMissionParam[] json)
    {
    }

    [Token(Token = "0x60068E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondMissionParam()
    {
    }
  }
}
