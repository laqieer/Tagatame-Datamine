// Decompiled with JetBrains decompiler
// Type: SRPG.BondMissionRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019B5")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondMissionRewardParam
  {
    [Token(Token = "0x17000B1D")]
    public RewardIcon.eType ItemType
    {
      [Token(Token = "0x60068E7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RewardIcon.eType();
      }
      [Token(Token = "0x60068E8"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000B1E")]
    public string ItemIname
    {
      [Token(Token = "0x60068E9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068EA"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000B1F")]
    public int ItemNum
    {
      [Token(Token = "0x60068EB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60068EC"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x60068ED")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(Json_BondMissionRewardParam json) => new bool();

    [Token(Token = "0x60068EE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondMissionRewardParam()
    {
    }
  }
}
