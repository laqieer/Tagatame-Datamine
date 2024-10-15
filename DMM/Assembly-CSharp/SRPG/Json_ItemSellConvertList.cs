// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ItemSellConvertList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001032")]
  [MessagePackObject(true)]
  public class Json_ItemSellConvertList
  {
    [Token(Token = "0x4003999")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400399A")]
    [FieldOffset(Offset = "0xC")]
    public int sellNum;
    [Token(Token = "0x400399B")]
    [FieldOffset(Offset = "0x10")]
    public int sellGold;

    [Token(Token = "0x6004298")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ItemSellConvertList()
    {
    }
  }
}
