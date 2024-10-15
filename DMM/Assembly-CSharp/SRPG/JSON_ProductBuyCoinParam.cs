// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ProductBuyCoinParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C1D")]
  [MessagePackObject(true)]
  public class JSON_ProductBuyCoinParam
  {
    [Token(Token = "0x4006CF1")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x4006CF2")]
    [FieldOffset(Offset = "0xC")]
    public string product_id;
    [Token(Token = "0x4006CF3")]
    [FieldOffset(Offset = "0x10")]
    public int remain_num;
    [Token(Token = "0x4006CF4")]
    [FieldOffset(Offset = "0x14")]
    public int is_display_only;

    [Token(Token = "0x60073D0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ProductBuyCoinParam()
    {
    }
  }
}
