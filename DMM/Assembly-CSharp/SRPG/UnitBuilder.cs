// Decompiled with JetBrains decompiler
// Type: SRPG.UnitBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001577")]
  internal class UnitBuilder
  {
    [Token(Token = "0x4004E28")]
    [FieldOffset(Offset = "0x8")]
    private string m_UnitIname;
    [Token(Token = "0x4004E29")]
    [FieldOffset(Offset = "0xC")]
    private int m_Exp;
    [Token(Token = "0x4004E2A")]
    [FieldOffset(Offset = "0x10")]
    private int m_Awake;
    [Token(Token = "0x4004E2B")]
    [FieldOffset(Offset = "0x14")]
    private string m_JobIname;
    [Token(Token = "0x4004E2C")]
    [FieldOffset(Offset = "0x18")]
    private int m_Rarity;
    [Token(Token = "0x4004E2D")]
    [FieldOffset(Offset = "0x1C")]
    private int m_JobRank;
    [Token(Token = "0x4004E2E")]
    [FieldOffset(Offset = "0x20")]
    private int m_UnlockTobiraNum;

    [Token(Token = "0x60058A1")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public UnitBuilder(string unitIname)
    {
    }

    [Token(Token = "0x60058A2")]
    [Address(RVA = "0x12DD0B0", Offset = "0x12DBEB0", VA = "0x112DD0B0")]
    public UnitBuilder SetLevelByExp(int exp) => (UnitBuilder) null;

    [Token(Token = "0x60058A3")]
    [Address(RVA = "0x12DD020", Offset = "0x12DBE20", VA = "0x112DD020")]
    public UnitBuilder SetExpByLevel(int level) => (UnitBuilder) null;

    [Token(Token = "0x60058A4")]
    [Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")]
    public UnitBuilder SetRarity(int value) => (UnitBuilder) null;

    [Token(Token = "0x60058A5")]
    [Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")]
    public UnitBuilder SetAwake(int value) => (UnitBuilder) null;

    [Token(Token = "0x60058A6")]
    [Address(RVA = "0x12DD080", Offset = "0x12DBE80", VA = "0x112DD080")]
    public UnitBuilder SetJob(string jobIname, int jobRank) => (UnitBuilder) null;

    [Token(Token = "0x60058A7")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public UnitBuilder SetUnlockTobiraNum(int value) => (UnitBuilder) null;

    [Token(Token = "0x60058A8")]
    [Address(RVA = "0x12DCF70", Offset = "0x12DBD70", VA = "0x112DCF70")]
    public UnitData Build() => (UnitData) null;
  }
}
