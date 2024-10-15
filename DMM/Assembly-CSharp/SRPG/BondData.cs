// Decompiled with JetBrains decompiler
// Type: SRPG.BondData
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
  [Token(Token = "0x2002098")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondData
  {
    [Token(Token = "0x1700132C")]
    public string BoundGroupIname
    {
      [Token(Token = "0x60087A6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60087A7"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700132D")]
    public int Lv
    {
      [Token(Token = "0x60087A8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60087A9"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x60087AA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondData()
    {
    }

    [Token(Token = "0x60087AB")]
    [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
    public BondData(string bg_iname, int lv)
    {
    }

    [Token(Token = "0x60087AC")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(Json_BondData json) => new bool();

    [Token(Token = "0x60087AD")]
    [Address(RVA = "0x492C60", Offset = "0x491A60", VA = "0x10492C60")]
    public Json_BondData Serialize() => (Json_BondData) null;

    [Token(Token = "0x60087AE")]
    [Address(RVA = "0x4918F0", Offset = "0x4906F0", VA = "0x104918F0")]
    public static BondData CreateDummyData() => (BondData) null;

    [Token(Token = "0x60087AF")]
    [Address(RVA = "0x491A30", Offset = "0x490830", VA = "0x10491A30")]
    public static List<BondGroupParam> GetBondGroupParamByUnitIname(string unit_iname)
    {
      return (List<BondGroupParam>) null;
    }

    [Token(Token = "0x60087B0")]
    [Address(RVA = "0x4915B0", Offset = "0x4903B0", VA = "0x104915B0")]
    public static void CheckNewOpenBondGroup(UnitData unit)
    {
    }

    [Token(Token = "0x60087B1")]
    [Address(RVA = "0x491CE0", Offset = "0x490AE0", VA = "0x10491CE0")]
    public static List<BuffEffectParam> GetUnitEnableBuffEffectParams(
      string unit_iname,
      List<BondData> bond_datas = null)
    {
      return (List<BuffEffectParam>) null;
    }

    [Token(Token = "0x60087B2")]
    [Address(RVA = "0x4921F0", Offset = "0x490FF0", VA = "0x104921F0")]
    public static bool IsLevelUpMaterialEnough(BondGroupBuffDetaillParam target) => new bool();

    [Token(Token = "0x60087B3")]
    [Address(RVA = "0x4913B0", Offset = "0x4901B0", VA = "0x104913B0")]
    public static bool CalcNeedMaterial(
      string item_iname,
      int item_rate,
      ref int need_amount,
      ref Dictionary<string, int> materials)
    {
      return new bool();
    }
  }
}
