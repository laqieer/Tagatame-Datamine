// Decompiled with JetBrains decompiler
// Type: SRPG.FilterConceptCardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D32")]
  public class FilterConceptCardParam
  {
    [Token(Token = "0x4007296")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007297")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x4007298")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4007299")]
    [FieldOffset(Offset = "0x14")]
    public eConceptCardFilterTypes filter_type;
    [Token(Token = "0x400729A")]
    [FieldOffset(Offset = "0x18")]
    public FilterConceptCardConditionParam[] conditions;

    [Token(Token = "0x60077AC")]
    [Address(RVA = "0x390520", Offset = "0x38F320", VA = "0x10390520")]
    public bool IsEnableFilterType(eConceptCardFilterTypes type) => new bool();

    [Token(Token = "0x60077AD")]
    [Address(RVA = "0x390250", Offset = "0x38F050", VA = "0x10390250")]
    public void Deserialize(JSON_FilterConceptCardParam json)
    {
    }

    [Token(Token = "0x60077AE")]
    [Address(RVA = "0x390410", Offset = "0x38F210", VA = "0x10390410")]
    public static void Deserialize(
      ref FilterConceptCardParam[] param,
      JSON_FilterConceptCardParam[] json)
    {
    }

    [Token(Token = "0x60077AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterConceptCardParam()
    {
    }
  }
}
