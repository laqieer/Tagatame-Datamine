// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopUpdateResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001117")]
  public class Json_ShopUpdateResponse
  {
    [Token(Token = "0x4003DDA")]
    [FieldOffset(Offset = "0x8")]
    public Json_Currencies currencies;
    [Token(Token = "0x4003DDB")]
    [FieldOffset(Offset = "0xC")]
    public Json_ShopItem[] shopitems;
    [Token(Token = "0x4003DDC")]
    [FieldOffset(Offset = "0x10")]
    public int relcnt;
    [Token(Token = "0x4003DDD")]
    [FieldOffset(Offset = "0x14")]
    public int concept_count;
    [Token(Token = "0x4003DDE")]
    [FieldOffset(Offset = "0x18")]
    public int crystal_count;

    [Token(Token = "0x6004867")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopUpdateResponse()
    {
    }
  }
}
