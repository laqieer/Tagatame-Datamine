// Decompiled with JetBrains decompiler
// Type: SRPG.FilterUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D3F")]
  public class FilterUnitParam
  {
    [Token(Token = "0x40072EC")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40072ED")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x40072EE")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40072EF")]
    [FieldOffset(Offset = "0x14")]
    public FilterUnitConditionParam[] conditions;
    [Token(Token = "0x40072F0")]
    [FieldOffset(Offset = "0x18")]
    private eFilterUnitTypes filter_type;

    [Token(Token = "0x17000FDE")]
    public eFilterUnitTypes FilterType
    {
      [Token(Token = "0x60077E2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new eFilterUnitTypes();
      }
    }

    [Token(Token = "0x60077E3")]
    [Address(RVA = "0x391A60", Offset = "0x390860", VA = "0x10391A60")]
    public bool IsEnableFilterType(eFilterUnitTypes type) => new bool();

    [Token(Token = "0x60077E4")]
    [Address(RVA = "0x391A40", Offset = "0x390840", VA = "0x10391A40")]
    public bool IsAddFiltertype() => new bool();

    [Token(Token = "0x60077E5")]
    [Address(RVA = "0x3918C0", Offset = "0x3906C0", VA = "0x103918C0")]
    public void Deserialize(JSON_FilterUnitParam json)
    {
    }

    [Token(Token = "0x60077E6")]
    [Address(RVA = "0x3917B0", Offset = "0x3905B0", VA = "0x103917B0")]
    public static void Deserialize(ref FilterUnitParam[] param, JSON_FilterUnitParam[] json)
    {
    }

    [Token(Token = "0x60077E7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterUnitParam()
    {
    }
  }
}
