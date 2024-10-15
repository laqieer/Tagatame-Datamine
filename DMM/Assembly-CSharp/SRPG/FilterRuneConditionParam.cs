// Decompiled with JetBrains decompiler
// Type: SRPG.FilterRuneConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D39")]
  public class FilterRuneConditionParam
  {
    [Token(Token = "0x40072C3")]
    [FieldOffset(Offset = "0x8")]
    public FilterRuneParam parent;
    [Token(Token = "0x40072C4")]
    [FieldOffset(Offset = "0xC")]
    public string cnds_iname;
    [Token(Token = "0x40072C5")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x40072C6")]
    [FieldOffset(Offset = "0x14")]
    public byte rarity;
    [Token(Token = "0x40072C7")]
    [FieldOffset(Offset = "0x15")]
    public byte slot_index;
    [Token(Token = "0x40072C8")]
    [FieldOffset(Offset = "0x16")]
    public byte set_eff;
    [Token(Token = "0x40072C9")]
    [FieldOffset(Offset = "0x17")]
    public byte evo_status;
    [Token(Token = "0x40072CA")]
    [FieldOffset(Offset = "0x18")]
    public byte dedicated;
    [Token(Token = "0x40072CB")]
    [FieldOffset(Offset = "0x1C")]
    public byte[] party_types;

    [Token(Token = "0x60077C5")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public FilterRuneConditionParam(FilterRuneParam _parent)
    {
    }

    [Token(Token = "0x60077C6")]
    [Address(RVA = "0x3908D0", Offset = "0x38F6D0", VA = "0x103908D0")]
    public void Deserialize(JSON_FilterRuneConditionParam json)
    {
    }

    [Token(Token = "0x17000FDD")]
    public string PrefsKey
    {
      [Token(Token = "0x60077C7"), Address(RVA = "0x390220", Offset = "0x38F020", VA = "0x10390220")] get
      {
        return (string) null;
      }
    }
  }
}
