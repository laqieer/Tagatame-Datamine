// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018BE")]
  public class Json_GachaCost
  {
    [Token(Token = "0x4005936")]
    [FieldOffset(Offset = "0x8")]
    public float gold;
    [Token(Token = "0x4005937")]
    [FieldOffset(Offset = "0xC")]
    public float coin;
    [Token(Token = "0x4005938")]
    [FieldOffset(Offset = "0x10")]
    public float coin_p;
    [Token(Token = "0x4005939")]
    [FieldOffset(Offset = "0x14")]
    public Json_GachaCostTicket ticket;
    [Token(Token = "0x400593A")]
    [FieldOffset(Offset = "0x18")]
    public Json_GachaCostItem item;
    [Token(Token = "0x400593B")]
    [FieldOffset(Offset = "0x1C")]
    public string discount_item;

    [Token(Token = "0x600636E")]
    [Address(RVA = "0x3168D0", Offset = "0x3156D0", VA = "0x103168D0")]
    public Json_GachaCost()
    {
    }
  }
}
