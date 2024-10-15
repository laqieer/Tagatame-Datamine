// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002392")]
  public class EventShopInfo
  {
    [Token(Token = "0x400A05A")]
    [FieldOffset(Offset = "0x8")]
    public JSON_ShopListArray.Shops shops;
    [Token(Token = "0x400A05B")]
    [FieldOffset(Offset = "0xC")]
    public string shop_cost_iname;
    [Token(Token = "0x400A05C")]
    [FieldOffset(Offset = "0x10")]
    public bool btn_update;
    [Token(Token = "0x400A05D")]
    [FieldOffset(Offset = "0x14")]
    public string banner_sprite;

    [Token(Token = "0x60099C4")]
    [Address(RVA = "0x5E0990", Offset = "0x5DF790", VA = "0x105E0990")]
    public void Setup(JSON_ShopListArray.Shops _shops, Json_ShopMsgResponse _msg)
    {
    }

    [Token(Token = "0x60099C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EventShopInfo()
    {
    }
  }
}
