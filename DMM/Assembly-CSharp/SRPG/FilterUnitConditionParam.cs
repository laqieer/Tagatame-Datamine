// Decompiled with JetBrains decompiler
// Type: SRPG.FilterUnitConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D40")]
  public class FilterUnitConditionParam
  {
    [Token(Token = "0x40072F1")]
    [FieldOffset(Offset = "0x8")]
    public FilterUnitParam parent;
    [Token(Token = "0x40072F2")]
    [FieldOffset(Offset = "0xC")]
    public string cnds_iname;
    [Token(Token = "0x40072F3")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40072F4")]
    [FieldOffset(Offset = "0x14")]
    public int is_done;
    [Token(Token = "0x40072F5")]
    [FieldOffset(Offset = "0x18")]
    public int rarity_ini;
    [Token(Token = "0x40072F6")]
    [FieldOffset(Offset = "0x1C")]
    public EBirth birth;
    [Token(Token = "0x40072F7")]
    [FieldOffset(Offset = "0x20")]
    public ESex sex;
    [Token(Token = "0x40072F8")]
    [FieldOffset(Offset = "0x24")]
    public string[] af_tags;
    [Token(Token = "0x40072F9")]
    [FieldOffset(Offset = "0x28")]
    public string[] unit_groups;
    [Token(Token = "0x40072FA")]
    [FieldOffset(Offset = "0x2C")]
    public string[] job_groups;
    [Token(Token = "0x40072FB")]
    [FieldOffset(Offset = "0x30")]
    public UnitGroupParam[] unit_group_params;
    [Token(Token = "0x40072FC")]
    [FieldOffset(Offset = "0x34")]
    public JobGroupParam[] job_group_params;

    [Token(Token = "0x17000FDF")]
    public string PrefsKey
    {
      [Token(Token = "0x60077E8"), Address(RVA = "0x390220", Offset = "0x38F020", VA = "0x10390220")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60077E9")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public FilterUnitConditionParam(FilterUnitParam parentParam)
    {
    }

    [Token(Token = "0x60077EA")]
    [Address(RVA = "0x391400", Offset = "0x390200", VA = "0x10391400")]
    public void Deserialize(JSON_FilterUnitConditionParam json)
    {
    }
  }
}
