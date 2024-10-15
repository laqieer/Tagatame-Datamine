// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018BC")]
  public class Json_GachaParam
  {
    [Token(Token = "0x400590F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005910")]
    [FieldOffset(Offset = "0xC")]
    public string ticket;
    [Token(Token = "0x4005911")]
    [FieldOffset(Offset = "0x10")]
    public string cat;
    [Token(Token = "0x4005912")]
    [FieldOffset(Offset = "0x18")]
    public long startat;
    [Token(Token = "0x4005913")]
    [FieldOffset(Offset = "0x20")]
    public long endat;
    [Token(Token = "0x4005914")]
    [FieldOffset(Offset = "0x28")]
    public Json_GachaCost cost;
    [Token(Token = "0x4005915")]
    [FieldOffset(Offset = "0x2C")]
    public int num;
    [Token(Token = "0x4005916")]
    [FieldOffset(Offset = "0x30")]
    public string msg;
    [Token(Token = "0x4005917")]
    [FieldOffset(Offset = "0x34")]
    public string name;
    [Token(Token = "0x4005918")]
    [FieldOffset(Offset = "0x38")]
    public string movie;
    [Token(Token = "0x4005919")]
    [FieldOffset(Offset = "0x3C")]
    public string bg;
    [Token(Token = "0x400591A")]
    [FieldOffset(Offset = "0x40")]
    public string asset_bg;
    [Token(Token = "0x400591B")]
    [FieldOffset(Offset = "0x44")]
    public string asset_title;
    [Token(Token = "0x400591C")]
    [FieldOffset(Offset = "0x48")]
    public string detail_url;
    [Token(Token = "0x400591D")]
    [FieldOffset(Offset = "0x4C")]
    public string[] units;
    [Token(Token = "0x400591E")]
    [FieldOffset(Offset = "0x50")]
    public string[] ext_type;
    [Token(Token = "0x400591F")]
    [FieldOffset(Offset = "0x54")]
    public Json_GachaExtParam ext_param;
    [Token(Token = "0x4005920")]
    [FieldOffset(Offset = "0x58")]
    public string group;
    [Token(Token = "0x4005921")]
    [FieldOffset(Offset = "0x5C")]
    public string btext;
    [Token(Token = "0x4005922")]
    [FieldOffset(Offset = "0x60")]
    public string confirm;
    [Token(Token = "0x4005923")]
    [FieldOffset(Offset = "0x64")]
    public Json_GachaBonus[] bonus_items;
    [Token(Token = "0x4005924")]
    [FieldOffset(Offset = "0x68")]
    public string[] pickup_art;
    [Token(Token = "0x4005925")]
    [FieldOffset(Offset = "0x6C")]
    public int disabled;
    [Token(Token = "0x4005926")]
    [FieldOffset(Offset = "0x70")]
    public string bonus_msg;
    [Token(Token = "0x4005927")]
    [FieldOffset(Offset = "0x74")]
    public Json_GachaAppealParam appeal;
    [Token(Token = "0x4005928")]
    [FieldOffset(Offset = "0x78")]
    public int isHide;
    [Token(Token = "0x4005929")]
    [FieldOffset(Offset = "0x7C")]
    public int isLoop;
    [Token(Token = "0x400592A")]
    [FieldOffset(Offset = "0x80")]
    public int isFreePause;
    [Token(Token = "0x400592B")]
    [FieldOffset(Offset = "0x84")]
    public int isDiscount;
    [Token(Token = "0x400592C")]
    [FieldOffset(Offset = "0x88")]
    public Json_GachaCost cost_discount;
    [Token(Token = "0x400592D")]
    [FieldOffset(Offset = "0x8C")]
    public int isRateViewOff;
    [Token(Token = "0x400592E")]
    [FieldOffset(Offset = "0x90")]
    public int isDailyFree;
    [Token(Token = "0x400592F")]
    [FieldOffset(Offset = "0x94")]
    public int isSimpleAnim;
    [Token(Token = "0x4005930")]
    [FieldOffset(Offset = "0x98")]
    public int isPickupViewOff;
    [Token(Token = "0x4005931")]
    [FieldOffset(Offset = "0x9C")]
    public int pickup_select_type;
    [Token(Token = "0x4005932")]
    [FieldOffset(Offset = "0xA0")]
    public int pickup_select_num;
    [Token(Token = "0x4005933")]
    [FieldOffset(Offset = "0xA4")]
    public Json_GachaSelectedPickup[] pickup_selected;

    [Token(Token = "0x600636C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GachaParam()
    {
    }
  }
}
