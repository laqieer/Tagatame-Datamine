// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ProductSaleInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C1E")]
  [MessagePackObject(true)]
  public class JSON_ProductSaleInfo
  {
    [Token(Token = "0x4006CF5")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4006CF6")]
    [FieldOffset(Offset = "0xC")]
    public string description;
    [Token(Token = "0x4006CF7")]
    [FieldOffset(Offset = "0x10")]
    public int additional_free_coin;
    [Token(Token = "0x4006CF8")]
    [FieldOffset(Offset = "0x14")]
    public int remain_num;

    [Token(Token = "0x60073D1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ProductSaleInfo()
    {
    }
  }
}
