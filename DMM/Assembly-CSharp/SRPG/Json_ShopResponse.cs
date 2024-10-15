// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001116")]
  public class Json_ShopResponse
  {
    [Token(Token = "0x4003DD5")]
    [FieldOffset(Offset = "0x8")]
    public Json_ShopItem[] shopitems;
    [Token(Token = "0x4003DD6")]
    [FieldOffset(Offset = "0xC")]
    public int relcnt;
    [Token(Token = "0x4003DD7")]
    [FieldOffset(Offset = "0x10")]
    public string msg;
    [Token(Token = "0x4003DD8")]
    [FieldOffset(Offset = "0x14")]
    public int concept_count;
    [Token(Token = "0x4003DD9")]
    [FieldOffset(Offset = "0x18")]
    public int crystal_count;

    [Token(Token = "0x6004866")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopResponse()
    {
    }
  }
}
