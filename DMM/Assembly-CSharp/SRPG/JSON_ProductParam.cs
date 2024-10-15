// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ProductParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C1C")]
  [MessagePackObject(true)]
  public class JSON_ProductParam
  {
    [Token(Token = "0x4006CE8")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x4006CE9")]
    [FieldOffset(Offset = "0xC")]
    public string product_id;
    [Token(Token = "0x4006CEA")]
    [FieldOffset(Offset = "0x10")]
    public string platform;
    [Token(Token = "0x4006CEB")]
    [FieldOffset(Offset = "0x14")]
    public string name;
    [Token(Token = "0x4006CEC")]
    [FieldOffset(Offset = "0x18")]
    public string description;
    [Token(Token = "0x4006CED")]
    [FieldOffset(Offset = "0x1C")]
    public int additional_paid_coin;
    [Token(Token = "0x4006CEE")]
    [FieldOffset(Offset = "0x20")]
    public int additional_free_coin;
    [Token(Token = "0x4006CEF")]
    [FieldOffset(Offset = "0x24")]
    public int remain_num;
    [Token(Token = "0x4006CF0")]
    [FieldOffset(Offset = "0x28")]
    public JSON_ProductSaleInfo sale;

    [Token(Token = "0x60073CF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ProductParam()
    {
    }
  }
}
