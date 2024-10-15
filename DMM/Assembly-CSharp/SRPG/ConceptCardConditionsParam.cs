// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardConditionsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A7A")]
  public class ConceptCardConditionsParam
  {
    [Token(Token = "0x40061EC")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40061ED")]
    [FieldOffset(Offset = "0xC")]
    public string unit_group;
    [Token(Token = "0x40061EE")]
    [FieldOffset(Offset = "0x10")]
    public EUseConditionsType units_conditions_type;
    [Token(Token = "0x40061EF")]
    [FieldOffset(Offset = "0x14")]
    public string job_group;
    [Token(Token = "0x40061F0")]
    [FieldOffset(Offset = "0x18")]
    public EUseConditionsType jobs_conditions_type;
    [Token(Token = "0x40061F1")]
    [FieldOffset(Offset = "0x1C")]
    public ESex sex;
    [Token(Token = "0x40061F2")]
    [FieldOffset(Offset = "0x20")]
    public int[] birth_id;
    [Token(Token = "0x40061F3")]
    [FieldOffset(Offset = "0x24")]
    private Dictionary<EElement, int> conditions_elements;
    [Token(Token = "0x40061F4")]
    [FieldOffset(Offset = "0x28")]
    private int element_sum;

    [Token(Token = "0x6006CC6")]
    [Address(RVA = "0x353FD0", Offset = "0x352DD0", VA = "0x10353FD0")]
    public bool Deserialize(JSON_ConceptCardConditionsParam json) => new bool();

    [Token(Token = "0x6006CC7")]
    [Address(RVA = "0x3549A0", Offset = "0x3537A0", VA = "0x103549A0")]
    public bool IsMatchConditions(UnitParam unit_param, JobData job_data) => new bool();

    [Token(Token = "0x6006CC8")]
    [Address(RVA = "0x354B80", Offset = "0x353980", VA = "0x10354B80")]
    private bool IsMatchElement(EElement element) => new bool();

    [Token(Token = "0x6006CC9")]
    [Address(RVA = "0x354950", Offset = "0x353750", VA = "0x10354950")]
    private bool IsMatchBirth(int unit_birth) => new bool();

    [Token(Token = "0x6006CCA")]
    [Address(RVA = "0x354C70", Offset = "0x353A70", VA = "0x10354C70")]
    private bool IsMatchUnitGroup(string unit_iname) => new bool();

    [Token(Token = "0x6006CCB")]
    [Address(RVA = "0x354BE0", Offset = "0x3539E0", VA = "0x10354BE0")]
    private bool IsMatchJobGroup(string job_iname) => new bool();

    [Token(Token = "0x6006CCC")]
    [Address(RVA = "0x3541F0", Offset = "0x352FF0", VA = "0x103541F0")]
    public string GetConditionDescriptionEquip() => (string) null;

    [Token(Token = "0x6006CCD")]
    [Address(RVA = "0x354260", Offset = "0x353060", VA = "0x10354260")]
    public string GetConditionDescription() => (string) null;

    [Token(Token = "0x6006CCE")]
    [Address(RVA = "0x3548F0", Offset = "0x3536F0", VA = "0x103548F0")]
    public UnitGroupParam GetUnitGroupParam() => (UnitGroupParam) null;

    [Token(Token = "0x6006CCF")]
    [Address(RVA = "0x354890", Offset = "0x353690", VA = "0x10354890")]
    public JobGroupParam GetJobGroupParam() => (JobGroupParam) null;

    [Token(Token = "0x6006CD0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardConditionsParam()
    {
    }
  }
}
