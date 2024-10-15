// Decompiled with JetBrains decompiler
// Type: SRPG.FilterConceptCardConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D33")]
  public class FilterConceptCardConditionParam
  {
    [Token(Token = "0x400729B")]
    [FieldOffset(Offset = "0x8")]
    public FilterConceptCardParam parent;
    [Token(Token = "0x400729C")]
    [FieldOffset(Offset = "0xC")]
    public string cnds_iname;
    [Token(Token = "0x400729D")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400729E")]
    [FieldOffset(Offset = "0x14")]
    public int rarity;
    [Token(Token = "0x400729F")]
    [FieldOffset(Offset = "0x18")]
    public EBirth birth;
    [Token(Token = "0x40072A0")]
    [FieldOffset(Offset = "0x1C")]
    public string card_group;
    [Token(Token = "0x40072A1")]
    [FieldOffset(Offset = "0x20")]
    public eExtraRarityStateTypes extra_rarity;

    [Token(Token = "0x60077B0")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public FilterConceptCardConditionParam(FilterConceptCardParam _parent)
    {
    }

    [Token(Token = "0x60077B1")]
    [Address(RVA = "0x390190", Offset = "0x38EF90", VA = "0x10390190")]
    public void Deserialize(JSON_FilterConceptCardConditionParam json)
    {
    }

    [Token(Token = "0x17000FDC")]
    public string PrefsKey
    {
      [Token(Token = "0x60077B2"), Address(RVA = "0x390220", Offset = "0x38F020", VA = "0x10390220")] get
      {
        return (string) null;
      }
    }
  }
}
