// Decompiled with JetBrains decompiler
// Type: SRPG.Json_EventShopResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EB4")]
  public class Json_EventShopResponse
  {
    [Token(Token = "0x4002D2E")]
    [FieldOffset(Offset = "0x8")]
    public JSON_EventShopItemListSet[] shopitems;
    [Token(Token = "0x4002D2F")]
    [FieldOffset(Offset = "0xC")]
    public int relcnt;
    [Token(Token = "0x4002D30")]
    [FieldOffset(Offset = "0x10")]
    public int concept_count;
    [Token(Token = "0x4002D31")]
    [FieldOffset(Offset = "0x14")]
    public int crystal_count;

    [Token(Token = "0x6003D27")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_EventShopResponse()
    {
    }
  }
}
