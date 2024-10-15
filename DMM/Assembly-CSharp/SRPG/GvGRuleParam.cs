// Decompiled with JetBrains decompiler
// Type: SRPG.GvGRuleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B90")]
  public class GvGRuleParam : GvGMasterParam<JSON_GvGRuleParam>
  {
    [Token(Token = "0x4006913")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006914")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4006915")]
    [FieldOffset(Offset = "0x10")]
    private int mUnitCount;
    [Token(Token = "0x4006916")]
    [FieldOffset(Offset = "0x14")]
    private int mDefUnitCount;
    [Token(Token = "0x4006917")]
    [FieldOffset(Offset = "0x18")]
    private int mUnitCoolTime;
    [Token(Token = "0x4006918")]
    [FieldOffset(Offset = "0x1C")]
    private List<EBirth> mCndsBirth;

    [Token(Token = "0x17000DCF")]
    public string Iname
    {
      [Token(Token = "0x60071F7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DD0")]
    public string Name
    {
      [Token(Token = "0x60071F8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DD1")]
    public int UnitCount
    {
      [Token(Token = "0x60071F9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DD2")]
    public int DefUnitCount
    {
      [Token(Token = "0x60071FA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DD3")]
    public int UnitCoolTime
    {
      [Token(Token = "0x60071FB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DD4")]
    public List<EBirth> CndsBirth
    {
      [Token(Token = "0x60071FC"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<EBirth>) null;
      }
    }

    [Token(Token = "0x60071FD")]
    [Address(RVA = "0x375090", Offset = "0x373E90", VA = "0x10375090", Slot = "4")]
    public override bool Deserialize(JSON_GvGRuleParam json) => new bool();

    [Token(Token = "0x60071FE")]
    [Address(RVA = "0x375730", Offset = "0x374530", VA = "0x10375730")]
    public bool IsExistConditions() => new bool();

    [Token(Token = "0x60071FF")]
    [Address(RVA = "0x3751F0", Offset = "0x373FF0", VA = "0x103751F0")]
    public List<UnitData> GetDisableUnits(List<UnitData> units) => (List<UnitData>) null;

    [Token(Token = "0x6007200")]
    [Address(RVA = "0x3752C0", Offset = "0x3740C0", VA = "0x103752C0")]
    public List<UnitData> GetEnableUnits(List<UnitData> units) => (List<UnitData>) null;

    [Token(Token = "0x6007201")]
    [Address(RVA = "0x375650", Offset = "0x374450", VA = "0x10375650")]
    private bool IsEnableUnit(UnitData unit) => new bool();

    [Token(Token = "0x6007202")]
    [Address(RVA = "0x375390", Offset = "0x374190", VA = "0x10375390")]
    public static GvGRuleParam GetRule() => (GvGRuleParam) null;

    [Token(Token = "0x6007203")]
    [Address(RVA = "0x375770", Offset = "0x374570", VA = "0x10375770")]
    public GvGRuleParam()
    {
    }
  }
}
