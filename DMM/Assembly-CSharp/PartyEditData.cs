// Decompiled with JetBrains decompiler
// Type: PartyEditData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
[Token(Token = "0x2000139")]
public class PartyEditData
{
  [Token(Token = "0x400057C")]
  [FieldOffset(Offset = "0x8")]
  public UnitData[] Units;
  [Token(Token = "0x400057D")]
  [FieldOffset(Offset = "0xC")]
  public PartyData PartyData;
  [Token(Token = "0x400057E")]
  [FieldOffset(Offset = "0x10")]
  public string Name;

  [Token(Token = "0x60007B3")]
  [Address(RVA = "0xD63D70", Offset = "0xD62B70", VA = "0x10D63D70")]
  public PartyEditData(UnitData[] src, string name, PartyData party)
  {
  }

  [Token(Token = "0x60007B4")]
  [Address(RVA = "0xD63C50", Offset = "0xD62A50", VA = "0x10D63C50")]
  public PartyEditData(string name, PartyData party)
  {
  }

  [Token(Token = "0x60007B5")]
  [Address(RVA = "0xD63870", Offset = "0xD62670", VA = "0x10D63870")]
  public int IndexOf(UnitData unit) => new int();

  [Token(Token = "0x60007B6")]
  [Address(RVA = "0xD639B0", Offset = "0xD627B0", VA = "0x10D639B0")]
  public void SetUnits(UnitData[] src)
  {
  }

  [Token(Token = "0x60007B7")]
  [Address(RVA = "0xD63910", Offset = "0xD62710", VA = "0x10D63910")]
  public void SetUnitsForce(UnitData[] src)
  {
  }

  [Token(Token = "0x60007B8")]
  [Address(RVA = "0xD636D0", Offset = "0xD624D0", VA = "0x10D636D0")]
  public int GetMainMemberCount() => new int();

  [Token(Token = "0x60007B9")]
  [Address(RVA = "0xD637A0", Offset = "0xD625A0", VA = "0x10D637A0")]
  public int GetSubMemberCount() => new int();

  [Token(Token = "0x60007BA")]
  [Address(RVA = "0xD63730", Offset = "0xD62530", VA = "0x10D63730")]
  public int GetMainSlotNum(long uniqId) => new int();

  [Token(Token = "0x60007BB")]
  [Address(RVA = "0xD63800", Offset = "0xD62600", VA = "0x10D63800")]
  public int GetSubSlotNum(long uniqId) => new int();

  [Token(Token = "0x60007BC")]
  [Address(RVA = "0xD638E0", Offset = "0xD626E0", VA = "0x10D638E0")]
  public bool IsSubSlot(int slotNo) => new bool();

  [Token(Token = "0x60007BD")]
  [Address(RVA = "0x368A50", Offset = "0x367850", VA = "0x10368A50")]
  public void Reset()
  {
  }
}
