// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ProductParamResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C1F")]
  [MessagePackObject(true)]
  public class JSON_ProductParamResponse
  {
    [Token(Token = "0x4006CF9")]
    [FieldOffset(Offset = "0x8")]
    public JSON_ProductParam[] products;
    [Token(Token = "0x4006CFA")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ProductBuyCoinParam[] buycoins;
    [Token(Token = "0x4006CFB")]
    [FieldOffset(Offset = "0x10")]
    public Json_HotDealInfo[] hot_deals;
    [Token(Token = "0x4006CFC")]
    [FieldOffset(Offset = "0x14")]
    public Json_BuyCoinSteps[] buycoinsteps;
    [Token(Token = "0x4006CFD")]
    [FieldOffset(Offset = "0x18")]
    public Json_ExpansionPurchase[] expansions;

    [Token(Token = "0x60073D2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ProductParamResponse()
    {
    }
  }
}
