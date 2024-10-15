// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopBuyConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200111B")]
  public class Json_ShopBuyConceptCard
  {
    [Token(Token = "0x4003DF8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003DF9")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4003DFA")]
    [FieldOffset(Offset = "0x10")]
    public string get_unit;

    [Token(Token = "0x17000782")]
    public bool IsGetConceptCardUnit
    {
      [Token(Token = "0x600486B"), Address(RVA = "0xAAABE0", Offset = "0xAA99E0", VA = "0x10AAABE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600486C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopBuyConceptCard()
    {
    }
  }
}
