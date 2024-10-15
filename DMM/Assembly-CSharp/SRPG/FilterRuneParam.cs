// Decompiled with JetBrains decompiler
// Type: SRPG.FilterRuneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D38")]
  public class FilterRuneParam
  {
    [Token(Token = "0x40072BE")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40072BF")]
    [FieldOffset(Offset = "0xC")]
    public string tab_name;
    [Token(Token = "0x40072C0")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40072C1")]
    [FieldOffset(Offset = "0x14")]
    public eRuneFilterTypes filter_type;
    [Token(Token = "0x40072C2")]
    [FieldOffset(Offset = "0x18")]
    public FilterRuneConditionParam[] conditions;

    [Token(Token = "0x60077C1")]
    [Address(RVA = "0x390520", Offset = "0x38F320", VA = "0x10390520")]
    public bool IsEnableFilterType(eRuneFilterTypes type) => new bool();

    [Token(Token = "0x60077C2")]
    [Address(RVA = "0x3909B0", Offset = "0x38F7B0", VA = "0x103909B0")]
    public void Deserialize(JSON_FilterRuneParam json)
    {
    }

    [Token(Token = "0x60077C3")]
    [Address(RVA = "0x390BF0", Offset = "0x38F9F0", VA = "0x10390BF0")]
    public static void Deserialize(ref FilterRuneParam[] param, JSON_FilterRuneParam[] json)
    {
    }

    [Token(Token = "0x60077C4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FilterRuneParam()
    {
    }
  }
}
