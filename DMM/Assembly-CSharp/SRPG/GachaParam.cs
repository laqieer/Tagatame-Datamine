// Decompiled with JetBrains decompiler
// Type: SRPG.GachaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AF2")]
  public class GachaParam
  {
    [Token(Token = "0x4006627")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006628")]
    [FieldOffset(Offset = "0xC")]
    public string category;
    [Token(Token = "0x4006629")]
    [FieldOffset(Offset = "0x10")]
    public long startat;
    [Token(Token = "0x400662A")]
    [FieldOffset(Offset = "0x18")]
    public long endat;
    [Token(Token = "0x400662B")]
    [FieldOffset(Offset = "0x20")]
    public int gold;
    [Token(Token = "0x400662C")]
    [FieldOffset(Offset = "0x24")]
    public int coin;
    [Token(Token = "0x400662D")]
    [FieldOffset(Offset = "0x28")]
    public int coin_p;
    [Token(Token = "0x400662E")]
    [FieldOffset(Offset = "0x2C")]
    public string ticket_iname;
    [Token(Token = "0x400662F")]
    [FieldOffset(Offset = "0x30")]
    public int ticket_num;
    [Token(Token = "0x4006630")]
    [FieldOffset(Offset = "0x34")]
    public string item_iname;
    [Token(Token = "0x4006631")]
    [FieldOffset(Offset = "0x38")]
    public int item_num;
    [Token(Token = "0x4006632")]
    [FieldOffset(Offset = "0x3C")]
    public int num;
    [Token(Token = "0x4006633")]
    [FieldOffset(Offset = "0x40")]
    public string msg;
    [Token(Token = "0x4006634")]
    [FieldOffset(Offset = "0x44")]
    public string name;
    [Token(Token = "0x4006635")]
    [FieldOffset(Offset = "0x48")]
    public string movie;
    [Token(Token = "0x4006636")]
    [FieldOffset(Offset = "0x4C")]
    public string bg;
    [Token(Token = "0x4006637")]
    [FieldOffset(Offset = "0x50")]
    public string asset_bg;
    [Token(Token = "0x4006638")]
    [FieldOffset(Offset = "0x54")]
    public string asset_title;
    [Token(Token = "0x4006639")]
    [FieldOffset(Offset = "0x58")]
    public string detail_url;
    [Token(Token = "0x400663A")]
    [FieldOffset(Offset = "0x5C")]
    public string[] ext_type;
    [Token(Token = "0x400663B")]
    [FieldOffset(Offset = "0x60")]
    public List<UnitData> units2;
    [Token(Token = "0x400663C")]
    [FieldOffset(Offset = "0x64")]
    public List<UnitParam> units;
    [Token(Token = "0x400663D")]
    [FieldOffset(Offset = "0x68")]
    public bool step;
    [Token(Token = "0x400663E")]
    [FieldOffset(Offset = "0x6C")]
    public int step_num;
    [Token(Token = "0x400663F")]
    [FieldOffset(Offset = "0x70")]
    public int step_index;
    [Token(Token = "0x4006640")]
    [FieldOffset(Offset = "0x74")]
    public bool limit;
    [Token(Token = "0x4006641")]
    [FieldOffset(Offset = "0x78")]
    public int limit_num;
    [Token(Token = "0x4006642")]
    [FieldOffset(Offset = "0x7C")]
    public int limit_stock;
    [Token(Token = "0x4006643")]
    [FieldOffset(Offset = "0x80")]
    public bool limit_cnt;
    [Token(Token = "0x4006644")]
    [FieldOffset(Offset = "0x84")]
    public int limit_cnt_rest;
    [Token(Token = "0x4006645")]
    [FieldOffset(Offset = "0x88")]
    public int limit_cnt_num;
    [Token(Token = "0x4006646")]
    [FieldOffset(Offset = "0x8C")]
    public string group;
    [Token(Token = "0x4006647")]
    [FieldOffset(Offset = "0x90")]
    public string btext;
    [Token(Token = "0x4006648")]
    [FieldOffset(Offset = "0x94")]
    public string confirm;
    [Token(Token = "0x4006649")]
    [FieldOffset(Offset = "0x98")]
    public List<GachaBonusParam> bonus_items;
    [Token(Token = "0x400664A")]
    [FieldOffset(Offset = "0x9C")]
    public List<ArtifactParam> artifacts;
    [Token(Token = "0x400664B")]
    [FieldOffset(Offset = "0xA0")]
    public long reset_at;
    [Token(Token = "0x400664C")]
    [FieldOffset(Offset = "0xA8")]
    public bool disabled;
    [Token(Token = "0x400664D")]
    [FieldOffset(Offset = "0xAC")]
    public string bonus_msg;
    [Token(Token = "0x400664E")]
    [FieldOffset(Offset = "0xB0")]
    public int appeal_type;
    [Token(Token = "0x400664F")]
    [FieldOffset(Offset = "0xB4")]
    public string appeal_message;
    [Token(Token = "0x4006650")]
    [FieldOffset(Offset = "0xB8")]
    public bool is_hide;
    [Token(Token = "0x4006651")]
    [FieldOffset(Offset = "0xB9")]
    public bool is_loop;
    [Token(Token = "0x4006652")]
    [FieldOffset(Offset = "0xBA")]
    public bool is_free_pause;
    [Token(Token = "0x4006653")]
    [FieldOffset(Offset = "0xBB")]
    public bool redraw;
    [Token(Token = "0x4006654")]
    [FieldOffset(Offset = "0xBC")]
    public int redraw_rest;
    [Token(Token = "0x4006655")]
    [FieldOffset(Offset = "0xC0")]
    public int redraw_num;
    [Token(Token = "0x4006656")]
    [FieldOffset(Offset = "0xC4")]
    public bool is_discount;
    [Token(Token = "0x4006657")]
    [FieldOffset(Offset = "0xC8")]
    public int gold_discount;
    [Token(Token = "0x4006658")]
    [FieldOffset(Offset = "0xCC")]
    public int coin_discount;
    [Token(Token = "0x4006659")]
    [FieldOffset(Offset = "0xD0")]
    public int coin_p_discount;
    [Token(Token = "0x400665A")]
    [FieldOffset(Offset = "0xD4")]
    public string discount_item;
    [Token(Token = "0x400665B")]
    [FieldOffset(Offset = "0xD8")]
    public bool is_rate_view;
    [Token(Token = "0x400665C")]
    [FieldOffset(Offset = "0xD9")]
    public bool is_daily_free;
    [Token(Token = "0x400665D")]
    [FieldOffset(Offset = "0xDA")]
    public bool is_simple_anim;
    [Token(Token = "0x400665E")]
    [FieldOffset(Offset = "0xDC")]
    public int pickup_select_type;
    [Token(Token = "0x400665F")]
    [FieldOffset(Offset = "0xE0")]
    public int pickup_select_num;
    [Token(Token = "0x4006660")]
    [FieldOffset(Offset = "0xE4")]
    public bool is_pickup_view;
    [Token(Token = "0x4006661")]
    [FieldOffset(Offset = "0xE8")]
    public List<GachaSelectedPickup> pickup_selected;

    [Token(Token = "0x6006F2C")]
    [Address(RVA = "0x368E70", Offset = "0x367C70", VA = "0x10368E70")]
    public void Deserialize(Json_GachaParam json)
    {
    }

    [Token(Token = "0x6006F2D")]
    [Address(RVA = "0x369AD0", Offset = "0x3688D0", VA = "0x10369AD0")]
    public GachaParam()
    {
    }
  }
}
