// Decompiled with JetBrains decompiler
// Type: SRPG.Json_LimitedShopResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FD7")]
  public class Json_LimitedShopResponse
  {
    [Token(Token = "0x40037F8")]
    [FieldOffset(Offset = "0x8")]
    public JSON_LimitedShopItemListSet[] shopitems;
    [Token(Token = "0x40037F9")]
    [FieldOffset(Offset = "0xC")]
    public int relcnt;
    [Token(Token = "0x40037FA")]
    [FieldOffset(Offset = "0x10")]
    public int concept_count;
    [Token(Token = "0x40037FB")]
    [FieldOffset(Offset = "0x14")]
    public int crystal_count;

    [Token(Token = "0x60041E8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_LimitedShopResponse()
    {
    }
  }
}
