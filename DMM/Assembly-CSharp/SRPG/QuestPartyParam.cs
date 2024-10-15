// Decompiled with JetBrains decompiler
// Type: SRPG.QuestPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C5E")]
  public class QuestPartyParam
  {
    [Token(Token = "0x4006F73")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006F74")]
    [FieldOffset(Offset = "0xC")]
    public PartySlotType type_1;
    [Token(Token = "0x4006F75")]
    [FieldOffset(Offset = "0x10")]
    public PartySlotType type_2;
    [Token(Token = "0x4006F76")]
    [FieldOffset(Offset = "0x14")]
    public PartySlotType type_3;
    [Token(Token = "0x4006F77")]
    [FieldOffset(Offset = "0x18")]
    public PartySlotType type_4;
    [Token(Token = "0x4006F78")]
    [FieldOffset(Offset = "0x1C")]
    public PartySlotType support_type;
    [Token(Token = "0x4006F79")]
    [FieldOffset(Offset = "0x20")]
    public PartySlotType subtype_1;
    [Token(Token = "0x4006F7A")]
    [FieldOffset(Offset = "0x24")]
    public PartySlotType subtype_2;
    [Token(Token = "0x4006F7B")]
    [FieldOffset(Offset = "0x28")]
    public string unit_1;
    [Token(Token = "0x4006F7C")]
    [FieldOffset(Offset = "0x2C")]
    public string unit_2;
    [Token(Token = "0x4006F7D")]
    [FieldOffset(Offset = "0x30")]
    public string unit_3;
    [Token(Token = "0x4006F7E")]
    [FieldOffset(Offset = "0x34")]
    public string unit_4;
    [Token(Token = "0x4006F7F")]
    [FieldOffset(Offset = "0x38")]
    public string subunit_1;
    [Token(Token = "0x4006F80")]
    [FieldOffset(Offset = "0x3C")]
    public string subunit_2;
    [Token(Token = "0x4006F81")]
    [FieldOffset(Offset = "0x40")]
    public int l_npc_rare;

    [Token(Token = "0x600751C")]
    [Address(RVA = "0x392050", Offset = "0x390E50", VA = "0x10392050")]
    public bool Deserialize(JSON_QuestPartyParam json) => new bool();

    [Token(Token = "0x600751D")]
    [Address(RVA = "0x392110", Offset = "0x390F10", VA = "0x10392110")]
    public PartySlotTypeUnitPair[] GetMainSlots() => (PartySlotTypeUnitPair[]) null;

    [Token(Token = "0x600751E")]
    [Address(RVA = "0x392630", Offset = "0x391430", VA = "0x10392630")]
    public PartySlotTypeUnitPair[] GetSubSlots() => (PartySlotTypeUnitPair[]) null;

    [Token(Token = "0x600751F")]
    [Address(RVA = "0x392320", Offset = "0x391120", VA = "0x10392320")]
    public PartySlotTypeUnitPair[] GetMainSubSlots() => (PartySlotTypeUnitPair[]) null;

    [Token(Token = "0x6007520")]
    [Address(RVA = "0x392760", Offset = "0x391560", VA = "0x10392760")]
    public PartySlotTypeUnitPair[] GetSupportSlots() => (PartySlotTypeUnitPair[]) null;

    [Token(Token = "0x6007521")]
    [Address(RVA = "0x392610", Offset = "0x391410", VA = "0x10392610")]
    public string GetNpcLeaderUnitIname() => (string) null;

    [Token(Token = "0x6007522")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestPartyParam()
    {
    }
  }
}
