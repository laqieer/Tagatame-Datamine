// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyObjective
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D93")]
  public class TrophyObjective
  {
    [Token(Token = "0x4007506")]
    [FieldOffset(Offset = "0x8")]
    public TrophyParam Param;
    [Token(Token = "0x4007507")]
    [FieldOffset(Offset = "0xC")]
    public int index;
    [Token(Token = "0x4007508")]
    [FieldOffset(Offset = "0x10")]
    public TrophyConditionTypes type;
    [Token(Token = "0x4007509")]
    [FieldOffset(Offset = "0x14")]
    public List<string> sval;
    [Token(Token = "0x400750A")]
    [FieldOffset(Offset = "0x18")]
    public int ival;

    [Token(Token = "0x1700104C")]
    public string sval_base
    {
      [Token(Token = "0x600790C"), Address(RVA = "0x3AE390", Offset = "0x3AD190", VA = "0x103AE390")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700104D")]
    public int RequiredCount
    {
      [Token(Token = "0x600790D"), Address(RVA = "0x3AE240", Offset = "0x3AD040", VA = "0x103AE240")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600790E")]
    [Address(RVA = "0x3A8EB0", Offset = "0x3A7CB0", VA = "0x103A8EB0")]
    public bool ContainsSval(string value) => new bool();

    [Token(Token = "0x1700104E")]
    public int SvalCount
    {
      [Token(Token = "0x600790F"), Address(RVA = "0x3AE350", Offset = "0x3AD150", VA = "0x103AE350")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007910")]
    [Address(RVA = "0x3A94B0", Offset = "0x3A82B0", VA = "0x103A94B0", Slot = "4")]
    public virtual string GetDescription() => (string) null;

    [Token(Token = "0x6007911")]
    [Address(RVA = "0x3A8F10", Offset = "0x3A7D10", VA = "0x103A8F10")]
    private string DelNewLine(string str) => (string) null;

    [Token(Token = "0x6007912")]
    [Address(RVA = "0x3A8E20", Offset = "0x3A7C20", VA = "0x103A8E20")]
    protected bool CheckUnexpectedMultipleSval() => new bool();

    [Token(Token = "0x6007913")]
    [Address(RVA = "0x3A8F90", Offset = "0x3A7D90", VA = "0x103A8F90")]
    protected string GetAreaList(List<string> svals) => (string) null;

    [Token(Token = "0x6007914")]
    [Address(RVA = "0x3AE050", Offset = "0x3ACE50", VA = "0x103AE050")]
    private string GetUnitName(string unitid) => (string) null;

    [Token(Token = "0x6007915")]
    [Address(RVA = "0x3AE0F0", Offset = "0x3ACEF0", VA = "0x103AE0F0")]
    private string GetUnitNames(List<string> units) => (string) null;

    [Token(Token = "0x6007916")]
    [Address(RVA = "0x3AD920", Offset = "0x3AC720", VA = "0x103AD920")]
    private string GetItemName(string itemid) => (string) null;

    [Token(Token = "0x6007917")]
    [Address(RVA = "0x3AD9C0", Offset = "0x3AC7C0", VA = "0x103AD9C0")]
    private string GetItemNames(List<string> items) => (string) null;

    [Token(Token = "0x6007918")]
    [Address(RVA = "0x3A9150", Offset = "0x3A7F50", VA = "0x103A9150")]
    private string GetArtifactName(string itemid) => (string) null;

    [Token(Token = "0x6007919")]
    [Address(RVA = "0x3A91F0", Offset = "0x3A7FF0", VA = "0x103A91F0")]
    private string GetArtifactNames(List<string> artifacts) => (string) null;

    [Token(Token = "0x600791A")]
    [Address(RVA = "0x3ADAE0", Offset = "0x3AC8E0", VA = "0x103ADAE0")]
    protected string GetQuestName(string questid) => (string) null;

    [Token(Token = "0x600791B")]
    [Address(RVA = "0x3ADB80", Offset = "0x3AC980", VA = "0x103ADB80")]
    protected string GetQuestNames(List<string> quests) => (string) null;

    [Token(Token = "0x600791C")]
    [Address(RVA = "0x3ADE60", Offset = "0x3ACC60", VA = "0x103ADE60")]
    protected string GetTowerQuestNames(List<string> quests) => (string) null;

    [Token(Token = "0x600791D")]
    [Address(RVA = "0x3A9310", Offset = "0x3A8110", VA = "0x103A9310")]
    private string GetConceptCardNames(List<string> cards) => (string) null;

    [Token(Token = "0x600791E")]
    [Address(RVA = "0x3ADCA0", Offset = "0x3ACAA0", VA = "0x103ADCA0")]
    private string GetTipsName(string iname) => (string) null;

    [Token(Token = "0x600791F")]
    [Address(RVA = "0x3ADD40", Offset = "0x3ACB40", VA = "0x103ADD40")]
    private string GetTipsNames(List<string> inames) => (string) null;

    [Token(Token = "0x6007920")]
    [Address(RVA = "0x3AE210", Offset = "0x3AD010", VA = "0x103AE210")]
    public bool IsExternalType() => new bool();

    [Token(Token = "0x6007921")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TrophyObjective()
    {
    }
  }
}
