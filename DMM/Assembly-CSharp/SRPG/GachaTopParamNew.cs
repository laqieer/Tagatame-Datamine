// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTopParamNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AF4")]
  public class GachaTopParamNew
  {
    [Token(Token = "0x4006666")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006667")]
    [FieldOffset(Offset = "0xC")]
    public string category;
    [Token(Token = "0x4006668")]
    [FieldOffset(Offset = "0x10")]
    public long startat;
    [Token(Token = "0x4006669")]
    [FieldOffset(Offset = "0x18")]
    public long endat;
    [Token(Token = "0x400666A")]
    [FieldOffset(Offset = "0x20")]
    public int coin;
    [Token(Token = "0x400666B")]
    [FieldOffset(Offset = "0x24")]
    public int coin_p;
    [Token(Token = "0x400666C")]
    [FieldOffset(Offset = "0x28")]
    public int gold;
    [Token(Token = "0x400666D")]
    [FieldOffset(Offset = "0x2C")]
    public List<UnitParam> units;
    [Token(Token = "0x400666E")]
    [FieldOffset(Offset = "0x30")]
    public int num;
    [Token(Token = "0x400666F")]
    [FieldOffset(Offset = "0x34")]
    public string ticket_iname;
    [Token(Token = "0x4006670")]
    [FieldOffset(Offset = "0x38")]
    public int ticket_num;
    [Token(Token = "0x4006671")]
    [FieldOffset(Offset = "0x3C")]
    public bool step;
    [Token(Token = "0x4006672")]
    [FieldOffset(Offset = "0x40")]
    public int step_num;
    [Token(Token = "0x4006673")]
    [FieldOffset(Offset = "0x44")]
    public int step_index;
    [Token(Token = "0x4006674")]
    [FieldOffset(Offset = "0x48")]
    public bool limit;
    [Token(Token = "0x4006675")]
    [FieldOffset(Offset = "0x4C")]
    public int limit_num;
    [Token(Token = "0x4006676")]
    [FieldOffset(Offset = "0x50")]
    public int limit_stock;
    [Token(Token = "0x4006677")]
    [FieldOffset(Offset = "0x54")]
    public bool limit_cnt;
    [Token(Token = "0x4006678")]
    [FieldOffset(Offset = "0x58")]
    public int limit_cnt_rest;
    [Token(Token = "0x4006679")]
    [FieldOffset(Offset = "0x5C")]
    public int limit_cnt_num;
    [Token(Token = "0x400667A")]
    [FieldOffset(Offset = "0x60")]
    public string type;
    [Token(Token = "0x400667B")]
    [FieldOffset(Offset = "0x64")]
    public string asset_title;
    [Token(Token = "0x400667C")]
    [FieldOffset(Offset = "0x68")]
    public string asset_bg;
    [Token(Token = "0x400667D")]
    [FieldOffset(Offset = "0x6C")]
    public string group;
    [Token(Token = "0x400667E")]
    [FieldOffset(Offset = "0x70")]
    public string btext;
    [Token(Token = "0x400667F")]
    [FieldOffset(Offset = "0x74")]
    public string confirm;
    [Token(Token = "0x4006680")]
    [FieldOffset(Offset = "0x78")]
    public List<GachaBonusParam> bonus_items;
    [Token(Token = "0x4006681")]
    [FieldOffset(Offset = "0x7C")]
    public List<ArtifactParam> artifacts;
    [Token(Token = "0x4006682")]
    [FieldOffset(Offset = "0x80")]
    public string detail_url;
    [Token(Token = "0x4006683")]
    [FieldOffset(Offset = "0x88")]
    public long reset_at;
    [Token(Token = "0x4006684")]
    [FieldOffset(Offset = "0x90")]
    public bool disabled;
    [Token(Token = "0x4006685")]
    [FieldOffset(Offset = "0x94")]
    public string bonus_msg;
    [Token(Token = "0x4006686")]
    [FieldOffset(Offset = "0x98")]
    public int appeal_type;
    [Token(Token = "0x4006687")]
    [FieldOffset(Offset = "0x9C")]
    public string appeal_message;
    [Token(Token = "0x4006688")]
    [FieldOffset(Offset = "0xA0")]
    public bool is_hide;
    [Token(Token = "0x4006689")]
    [FieldOffset(Offset = "0xA1")]
    public bool is_stepup_loop;
    [Token(Token = "0x400668A")]
    [FieldOffset(Offset = "0xA2")]
    public bool is_free_pause;
    [Token(Token = "0x400668B")]
    [FieldOffset(Offset = "0xA3")]
    public bool redraw;
    [Token(Token = "0x400668C")]
    [FieldOffset(Offset = "0xA4")]
    public int redraw_rest;
    [Token(Token = "0x400668D")]
    [FieldOffset(Offset = "0xA8")]
    public int redraw_num;
    [Token(Token = "0x400668E")]
    [FieldOffset(Offset = "0xAC")]
    public bool is_discount;
    [Token(Token = "0x400668F")]
    [FieldOffset(Offset = "0xB0")]
    public int coin_discount;
    [Token(Token = "0x4006690")]
    [FieldOffset(Offset = "0xB4")]
    public int coin_p_discount;
    [Token(Token = "0x4006691")]
    [FieldOffset(Offset = "0xB8")]
    public int gold_discount;
    [Token(Token = "0x4006692")]
    [FieldOffset(Offset = "0xBC")]
    public string discount_item;
    [Token(Token = "0x4006693")]
    [FieldOffset(Offset = "0xC0")]
    public bool is_rate_view;
    [Token(Token = "0x4006694")]
    [FieldOffset(Offset = "0xC1")]
    public bool is_daily_free;
    [Token(Token = "0x4006695")]
    [FieldOffset(Offset = "0xC2")]
    public bool is_simple_anim;
    [Token(Token = "0x4006696")]
    [FieldOffset(Offset = "0xC3")]
    private bool is_pickup_view;
    [Token(Token = "0x4006697")]
    [FieldOffset(Offset = "0xC4")]
    private GachaPickupSelectType pickup_select_type;
    [Token(Token = "0x4006698")]
    [FieldOffset(Offset = "0xC8")]
    private int pickup_select_num;
    [Token(Token = "0x4006699")]
    [FieldOffset(Offset = "0xCC")]
    private List<GachaDropData> pickup_selected;
    [Token(Token = "0x400669A")]
    [FieldOffset(Offset = "0xD0")]
    public string item_iname;
    [Token(Token = "0x400669B")]
    [FieldOffset(Offset = "0xD4")]
    public int item_num;
    [Token(Token = "0x400669C")]
    [FieldOffset(Offset = "0xD8")]
    public int coin_item_cost_type;
    [Token(Token = "0x400669D")]
    [FieldOffset(Offset = "0xDC")]
    public int item_execute_num;
    [Token(Token = "0x400669E")]
    [FieldOffset(Offset = "0xE0")]
    public string target_item_iname;
    [Token(Token = "0x400669F")]
    [FieldOffset(Offset = "0xE4")]
    public int target_item_num;
    [Token(Token = "0x40066A0")]
    [FieldOffset(Offset = "0xE8")]
    public int ticket_execute_num;

    [Token(Token = "0x6006F2E")]
    [Address(RVA = "0x369ED0", Offset = "0x368CD0", VA = "0x10369ED0")]
    public void Deserialize(GachaParam param)
    {
    }

    [Token(Token = "0x6006F2F")]
    [Address(RVA = "0x36A320", Offset = "0x369120", VA = "0x1036A320")]
    public long GetTimerAt() => new long();

    [Token(Token = "0x17000CBE")]
    public GachaCostType CostType
    {
      [Token(Token = "0x6006F30"), Address(RVA = "0x36A630", Offset = "0x369430", VA = "0x1036A630")] get
      {
        return new GachaCostType();
      }
    }

    [Token(Token = "0x17000CBF")]
    public GachaCategory Category
    {
      [Token(Token = "0x6006F31"), Address(RVA = "0x36A5B0", Offset = "0x3693B0", VA = "0x1036A5B0")] get
      {
        return new GachaCategory();
      }
    }

    [Token(Token = "0x17000CC0")]
    public bool IsOptionUIHide
    {
      [Token(Token = "0x6006F32"), Address(RVA = "0x36A8E0", Offset = "0x3696E0", VA = "0x1036A8E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC1")]
    public bool IsStepUpLoop
    {
      [Token(Token = "0x6006F33"), Address(RVA = "0x36A950", Offset = "0x369750", VA = "0x1036A950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC2")]
    public bool IsFreePause
    {
      [Token(Token = "0x6006F34"), Address(RVA = "0x36A8B0", Offset = "0x3696B0", VA = "0x1036A8B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC3")]
    public bool IsUseDiscount
    {
      [Token(Token = "0x6006F35"), Address(RVA = "0x36A960", Offset = "0x369760", VA = "0x1036A960")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC4")]
    public bool IsDiscount
    {
      [Token(Token = "0x6006F36"), Address(RVA = "0x36A840", Offset = "0x369640", VA = "0x1036A840")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC5")]
    public int Cost
    {
      [Token(Token = "0x6006F37"), Address(RVA = "0x36A6E0", Offset = "0x3694E0", VA = "0x1036A6E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC6")]
    public int DiscountCost
    {
      [Token(Token = "0x6006F38"), Address(RVA = "0x36A750", Offset = "0x369550", VA = "0x1036A750")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CC7")]
    public string UseDiscountItem
    {
      [Token(Token = "0x6006F39"), Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CC8")]
    public bool IsDefaultRareFree
    {
      [Token(Token = "0x6006F3A"), Address(RVA = "0x36A7E0", Offset = "0x3695E0", VA = "0x1036A7E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CC9")]
    public bool IsDefaultNormalFree
    {
      [Token(Token = "0x6006F3B"), Address(RVA = "0x36A7B0", Offset = "0x3695B0", VA = "0x1036A7B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CCA")]
    public bool IsUseOneMore
    {
      [Token(Token = "0x6006F3C"), Address(RVA = "0x36A970", Offset = "0x369770", VA = "0x1036A970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CCB")]
    public int ShowCurrentStepNum
    {
      [Token(Token = "0x6006F3D"), Address(RVA = "0x36AA00", Offset = "0x369800", VA = "0x1036AA00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CCC")]
    public bool IsPickupView
    {
      [Token(Token = "0x6006F3E"), Address(RVA = "0x36A8F0", Offset = "0x3696F0", VA = "0x1036A8F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CCD")]
    public GachaPickupSelectType PickupSelectType
    {
      [Token(Token = "0x6006F3F"), Address(RVA = "0x36A9F0", Offset = "0x3697F0", VA = "0x1036A9F0")] get
      {
        return new GachaPickupSelectType();
      }
    }

    [Token(Token = "0x17000CCE")]
    public int PickupSelectNum
    {
      [Token(Token = "0x6006F40"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006F41"), Address(RVA = "0x36AA20", Offset = "0x369820", VA = "0x1036AA20")] set
      {
      }
    }

    [Token(Token = "0x17000CCF")]
    public bool IsUsePickupSelect
    {
      [Token(Token = "0x6006F42"), Address(RVA = "0x36A9C0", Offset = "0x3697C0", VA = "0x1036A9C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CD0")]
    public bool IsSelectedPickup
    {
      [Token(Token = "0x6006F43"), Address(RVA = "0x36A900", Offset = "0x369700", VA = "0x1036A900")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CD1")]
    public List<GachaDropData> SelectedPickupList
    {
      [Token(Token = "0x6006F44"), Address(RVA = "0x319830", Offset = "0x318630", VA = "0x10319830")] get
      {
        return (List<GachaDropData>) null;
      }
    }

    [Token(Token = "0x6006F45")]
    [Address(RVA = "0x36A350", Offset = "0x369150", VA = "0x1036A350")]
    public GachaTopParamNew()
    {
    }
  }
}
