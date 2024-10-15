// Decompiled with JetBrains decompiler
// Type: SRPG.VersusUnitCondData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EEB")]
  public class VersusUnitCondData
  {
    [Token(Token = "0x4008211")]
    [FieldOffset(Offset = "0x8")]
    private List<string> mGroup;
    [Token(Token = "0x4008212")]
    [FieldOffset(Offset = "0xC")]
    private List<LimitSex> mSex;
    [Token(Token = "0x4008213")]
    [FieldOffset(Offset = "0x10")]
    private List<EElement> mElem;
    [Token(Token = "0x4008214")]
    [FieldOffset(Offset = "0x14")]
    private List<EBirth> mBirth;
    [Token(Token = "0x4008215")]
    [FieldOffset(Offset = "0x18")]
    private List<string> mUnit;

    [Token(Token = "0x170011DA")]
    public List<string> Group
    {
      [Token(Token = "0x6007E5B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x170011DB")]
    public List<LimitSex> Sex
    {
      [Token(Token = "0x6007E5C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<LimitSex>) null;
      }
    }

    [Token(Token = "0x170011DC")]
    public List<EElement> Elem
    {
      [Token(Token = "0x6007E5D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<EElement>) null;
      }
    }

    [Token(Token = "0x170011DD")]
    public List<EBirth> Birth
    {
      [Token(Token = "0x6007E5E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<EBirth>) null;
      }
    }

    [Token(Token = "0x170011DE")]
    public List<string> Unit
    {
      [Token(Token = "0x6007E5F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6007E60")]
    [Address(RVA = "0x3FCD50", Offset = "0x3FBB50", VA = "0x103FCD50")]
    public bool Deserialize(JSON_VersusUnitCondData json) => new bool();

    [Token(Token = "0x6007E61")]
    [Address(RVA = "0x3FD1B0", Offset = "0x3FBFB0", VA = "0x103FD1B0")]
    public bool IsPossibleUnit(UnitData unit, UnitCondType type) => new bool();

    [Token(Token = "0x6007E62")]
    [Address(RVA = "0x3FD290", Offset = "0x3FC090", VA = "0x103FD290")]
    public bool IsPossibleUnit(
      UnitParam unitParam,
      EElement elem,
      UnitCondType type,
      MasterParam masterparam)
    {
      return new bool();
    }

    [Token(Token = "0x6007E63")]
    [Address(RVA = "0x3FD190", Offset = "0x3FBF90", VA = "0x103FD190")]
    private bool IsAND(UnitCondType type) => new bool();

    [Token(Token = "0x6007E64")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusUnitCondData()
    {
    }
  }
}
