// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopItemDesc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001113")]
  public class Json_ShopItemDesc
  {
    [Token(Token = "0x4003DBF")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003DC0")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4003DC1")]
    [FieldOffset(Offset = "0x10")]
    public string itype;
    [Token(Token = "0x4003DC2")]
    [FieldOffset(Offset = "0x14")]
    public int maxnum;
    [Token(Token = "0x4003DC3")]
    [FieldOffset(Offset = "0x18")]
    public int boughtnum;
    [Token(Token = "0x4003DC4")]
    [FieldOffset(Offset = "0x1C")]
    public int step;
    [Token(Token = "0x4003DC5")]
    [FieldOffset(Offset = "0x20")]
    public int has_count;
    [Token(Token = "0x4003DC6")]
    [FieldOffset(Offset = "0x24")]
    public int rank;
    [Token(Token = "0x4003DC7")]
    [FieldOffset(Offset = "0x28")]
    public string lottery_id;
    [Token(Token = "0x4003DC8")]
    [FieldOffset(Offset = "0x2C")]
    public int crystal_amount;

    [Token(Token = "0x1700077E")]
    public bool IsItem
    {
      [Token(Token = "0x600485F"), Address(RVA = "0x11EDD60", Offset = "0x11ECB60", VA = "0x111EDD60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700077F")]
    public bool IsArtifact
    {
      [Token(Token = "0x6004860"), Address(RVA = "0x11EDCA0", Offset = "0x11ECAA0", VA = "0x111EDCA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000780")]
    public bool IsConceptCard
    {
      [Token(Token = "0x6004861"), Address(RVA = "0x11EDCE0", Offset = "0x11ECAE0", VA = "0x111EDCE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000781")]
    public bool IsCrystal
    {
      [Token(Token = "0x6004862"), Address(RVA = "0x11EDD20", Offset = "0x11ECB20", VA = "0x111EDD20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004863")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopItemDesc()
    {
    }
  }
}
