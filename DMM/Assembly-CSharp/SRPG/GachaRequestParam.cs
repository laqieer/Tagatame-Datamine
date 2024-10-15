// Decompiled with JetBrains decompiler
// Type: SRPG.GachaRequestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002492")]
  public class GachaRequestParam
  {
    [Token(Token = "0x400A6CC")]
    [FieldOffset(Offset = "0x8")]
    private string m_iname;
    [Token(Token = "0x400A6CD")]
    [FieldOffset(Offset = "0xC")]
    private int m_cost;
    [Token(Token = "0x400A6CE")]
    [FieldOffset(Offset = "0x10")]
    private int m_free;
    [Token(Token = "0x400A6CF")]
    [FieldOffset(Offset = "0x14")]
    private string m_ticket;
    [Token(Token = "0x400A6D0")]
    [FieldOffset(Offset = "0x18")]
    private int m_num;
    [Token(Token = "0x400A6D1")]
    [FieldOffset(Offset = "0x1C")]
    private string m_confirm_text;
    [Token(Token = "0x400A6D2")]
    [FieldOffset(Offset = "0x20")]
    private bool m_use_onemore;
    [Token(Token = "0x400A6D3")]
    [FieldOffset(Offset = "0x21")]
    private bool m_no_use_free;
    [Token(Token = "0x400A6D4")]
    [FieldOffset(Offset = "0x24")]
    private int m_redraw_rest;
    [Token(Token = "0x400A6D5")]
    [FieldOffset(Offset = "0x28")]
    private int m_redraw_num;
    [Token(Token = "0x400A6D6")]
    [FieldOffset(Offset = "0x2C")]
    private GachaCategory m_category;
    [Token(Token = "0x400A6D7")]
    [FieldOffset(Offset = "0x30")]
    private GachaCostType m_costtype;
    [Token(Token = "0x400A6D8")]
    [FieldOffset(Offset = "0x34")]
    private int m_discount_cost;
    [Token(Token = "0x400A6D9")]
    [FieldOffset(Offset = "0x38")]
    private int m_daily_free;
    [Token(Token = "0x400A6DA")]
    [FieldOffset(Offset = "0x3C")]
    private bool m_simple_anim;
    [Token(Token = "0x400A6DB")]
    [FieldOffset(Offset = "0x40")]
    private string m_item;
    [Token(Token = "0x400A6DC")]
    [FieldOffset(Offset = "0x44")]
    private int m_coin_item_cost_type;
    [Token(Token = "0x400A6DD")]
    [FieldOffset(Offset = "0x48")]
    private int m_item_execute_num;
    [Token(Token = "0x400A6DE")]
    [FieldOffset(Offset = "0x4C")]
    private bool m_is_step;
    [Token(Token = "0x400A6DF")]
    [FieldOffset(Offset = "0x50")]
    private int m_ticket_execute_num;
    [Token(Token = "0x400A6E0")]
    [FieldOffset(Offset = "0x54")]
    private bool m_isItemCostMultiGacha;
    [Token(Token = "0x400A6E1")]
    [FieldOffset(Offset = "0x58")]
    private GachaWindow.PeriodType m_period_type;
    [Token(Token = "0x400A6E2")]
    [FieldOffset(Offset = "0x60")]
    private long m_gacha_start;
    [Token(Token = "0x400A6E3")]
    [FieldOffset(Offset = "0x68")]
    private long m_gacha_end;
    [Token(Token = "0x400A6E4")]
    [FieldOffset(Offset = "0x70")]
    private bool m_is_show_period;

    [Token(Token = "0x17001661")]
    public bool IsGold
    {
      [Token(Token = "0x600A028"), Address(RVA = "0x61CA10", Offset = "0x61B810", VA = "0x1061CA10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001662")]
    public bool IsSingle
    {
      [Token(Token = "0x600A029"), Address(RVA = "0x26D070", Offset = "0x26BE70", VA = "0x1026D070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001663")]
    public string Iname
    {
      [Token(Token = "0x600A02A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001664")]
    public int Cost
    {
      [Token(Token = "0x600A02B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001665")]
    public int Free
    {
      [Token(Token = "0x600A02C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001666")]
    public bool IsFree
    {
      [Token(Token = "0x600A02D"), Address(RVA = "0x61CA00", Offset = "0x61B800", VA = "0x1061CA00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001667")]
    public string Ticket
    {
      [Token(Token = "0x600A02E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001668")]
    public int Num
    {
      [Token(Token = "0x600A02F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001669")]
    public bool IsPaid
    {
      [Token(Token = "0x600A030"), Address(RVA = "0x61CA50", Offset = "0x61B850", VA = "0x1061CA50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700166A")]
    public string ConfirmText
    {
      [Token(Token = "0x600A031"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700166B")]
    public bool IsTicketGacha
    {
      [Token(Token = "0x600A032"), Address(RVA = "0x3B2FA0", Offset = "0x3B1DA0", VA = "0x103B2FA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700166C")]
    public bool IsUseOneMore
    {
      [Token(Token = "0x600A033"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700166D")]
    public GachaCategory Category
    {
      [Token(Token = "0x600A034"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new GachaCategory();
      }
    }

    [Token(Token = "0x1700166E")]
    public GachaCostType CostType
    {
      [Token(Token = "0x600A035"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new GachaCostType();
      }
    }

    [Token(Token = "0x1700166F")]
    public bool IsUseFree
    {
      [Token(Token = "0x600A036"), Address(RVA = "0x61CA90", Offset = "0x61B890", VA = "0x1061CA90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001670")]
    public bool IsRedrawGacha
    {
      [Token(Token = "0x600A037"), Address(RVA = "0x61CA80", Offset = "0x61B880", VA = "0x1061CA80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001671")]
    public int RedrawRest
    {
      [Token(Token = "0x600A038"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001672")]
    public int RedrawNum
    {
      [Token(Token = "0x600A039"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001673")]
    public int ViewRedrawRest
    {
      [Token(Token = "0x600A03A"), Address(RVA = "0x61CAA0", Offset = "0x61B8A0", VA = "0x1061CAA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001674")]
    public bool IsRedrawConfirm
    {
      [Token(Token = "0x600A03B"), Address(RVA = "0x61CA60", Offset = "0x61B860", VA = "0x1061CA60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001675")]
    public int DiscountCost
    {
      [Token(Token = "0x600A03C"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001676")]
    public int FixCost
    {
      [Token(Token = "0x600A03D"), Address(RVA = "0x61C990", Offset = "0x61B790", VA = "0x1061C990")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001677")]
    public bool IsDiscount
    {
      [Token(Token = "0x600A03E"), Address(RVA = "0x5F9230", Offset = "0x5F8030", VA = "0x105F9230")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001678")]
    public int DailyFree
    {
      [Token(Token = "0x600A03F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001679")]
    public bool IsDailyFree
    {
      [Token(Token = "0x600A040"), Address(RVA = "0x61C9C0", Offset = "0x61B7C0", VA = "0x1061C9C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700167A")]
    public bool IsFixFree
    {
      [Token(Token = "0x600A041"), Address(RVA = "0x61C9E0", Offset = "0x61B7E0", VA = "0x1061C9E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700167B")]
    public bool IsSimpleAnim
    {
      [Token(Token = "0x600A042"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700167C")]
    public string Item
    {
      [Token(Token = "0x600A043"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700167D")]
    public bool IsItemGacha
    {
      [Token(Token = "0x600A044"), Address(RVA = "0x61CA30", Offset = "0x61B830", VA = "0x1061CA30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700167E")]
    public int ItemExecuteNum
    {
      [Token(Token = "0x600A045"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700167F")]
    public int CoinItemCostType
    {
      [Token(Token = "0x600A046"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001680")]
    public bool IsStep
    {
      [Token(Token = "0x600A047"), Address(RVA = "0x288150", Offset = "0x286F50", VA = "0x10288150")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001681")]
    public bool IsExecuteMulti
    {
      [Token(Token = "0x600A048"), Address(RVA = "0x61C9D0", Offset = "0x61B7D0", VA = "0x1061C9D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001682")]
    public int TicketExecuteNum
    {
      [Token(Token = "0x600A049"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001683")]
    public GachaWindow.PeriodType PeriodType
    {
      [Token(Token = "0x600A04A"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new GachaWindow.PeriodType();
      }
    }

    [Token(Token = "0x17001684")]
    public long GachaStart
    {
      [Token(Token = "0x600A04B"), Address(RVA = "0x61C9B0", Offset = "0x61B7B0", VA = "0x1061C9B0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001685")]
    public long GachaEnd
    {
      [Token(Token = "0x600A04C"), Address(RVA = "0x5A40F0", Offset = "0x5A2EF0", VA = "0x105A40F0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001686")]
    public bool IsShowPeriod
    {
      [Token(Token = "0x600A04D"), Address(RVA = "0x5FE310", Offset = "0x5FD110", VA = "0x105FE310")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001687")]
    public bool IsItemCostMultiGacha
    {
      [Token(Token = "0x600A04E"), Address(RVA = "0x2AABC0", Offset = "0x2A99C0", VA = "0x102AABC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A04F")]
    [Address(RVA = "0x61C7A0", Offset = "0x61B5A0", VA = "0x1061C7A0")]
    public GachaRequestParam()
    {
    }

    [Token(Token = "0x600A050")]
    [Address(RVA = "0x61C890", Offset = "0x61B690", VA = "0x1061C890")]
    public GachaRequestParam(
      string _iname,
      int _cost,
      string _confirm_text,
      GachaCostType _cost_type,
      GachaCategory _category,
      bool _use_onemore,
      bool _no_use_free = false)
    {
    }

    [Token(Token = "0x600A051")]
    [Address(RVA = "0x61C900", Offset = "0x61B700", VA = "0x1061C900")]
    public GachaRequestParam(string _iname)
    {
    }

    [Token(Token = "0x600A052")]
    [Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")]
    public void SetFree(int _free)
    {
    }

    [Token(Token = "0x600A053")]
    [Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")]
    public void SetNum(int _num)
    {
    }

    [Token(Token = "0x600A054")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SetTicketInfo(string _ticket_name)
    {
    }

    [Token(Token = "0x600A055")]
    [Address(RVA = "0x34FD00", Offset = "0x34EB00", VA = "0x1034FD00")]
    public void SetTicketExecuteNum(int _num)
    {
    }

    [Token(Token = "0x600A056")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void SetConfirmText(string _confirm_text)
    {
    }

    [Token(Token = "0x600A057")]
    [Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")]
    public void SetUseOneMore(bool _use_onemore)
    {
    }

    [Token(Token = "0x600A058")]
    [Address(RVA = "0x305F40", Offset = "0x304D40", VA = "0x10305F40")]
    public void SetNoUseFree(bool _no_use_free)
    {
    }

    [Token(Token = "0x600A059")]
    [Address(RVA = "0x61C760", Offset = "0x61B560", VA = "0x1061C760")]
    public void SetRedraw(int _rest, int _num)
    {
    }

    [Token(Token = "0x600A05A")]
    [Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")]
    public void SetDiscountCost(int _discount)
    {
    }

    [Token(Token = "0x600A05B")]
    [Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")]
    public void SetDailyFree(int _daily_free)
    {
    }

    [Token(Token = "0x600A05C")]
    [Address(RVA = "0x428390", Offset = "0x427190", VA = "0x10428390")]
    public void SetSimpleAnim(bool _simple_anim)
    {
    }

    [Token(Token = "0x600A05D")]
    [Address(RVA = "0x61C730", Offset = "0x61B530", VA = "0x1061C730")]
    public void SetItemInfo(string _item_iname, int _cost_type, bool _is_step)
    {
    }

    [Token(Token = "0x600A05E")]
    [Address(RVA = "0x370680", Offset = "0x36F480", VA = "0x10370680")]
    public void SetItemExecuteNum(int _execut_num)
    {
    }

    [Token(Token = "0x600A05F")]
    [Address(RVA = "0x61C720", Offset = "0x61B520", VA = "0x1061C720")]
    public void SetItemCostMultiGacha(bool _item_cost_multi_gacha)
    {
    }

    [Token(Token = "0x600A060")]
    [Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")]
    public void SetPeriodType(GachaWindow.PeriodType _period_type)
    {
    }

    [Token(Token = "0x600A061")]
    [Address(RVA = "0x61C780", Offset = "0x61B580", VA = "0x1061C780")]
    public void SetStartTime(long start_at)
    {
    }

    [Token(Token = "0x600A062")]
    [Address(RVA = "0x61C700", Offset = "0x61B500", VA = "0x1061C700")]
    public void SetEndTime(long end_at)
    {
    }

    [Token(Token = "0x600A063")]
    [Address(RVA = "0x5FE330", Offset = "0x5FD130", VA = "0x105FE330")]
    public void SetIsShowPeriod(bool _is_show_period)
    {
    }

    [Token(Token = "0x600A064")]
    [Address(RVA = "0x61C6E0", Offset = "0x61B4E0", VA = "0x1061C6E0")]
    public void ResetExtraParam()
    {
    }

    [Token(Token = "0x600A065")]
    [Address(RVA = "0x61C6C0", Offset = "0x61B4C0", VA = "0x1061C6C0")]
    public void ResetDiscount()
    {
    }

    [Token(Token = "0x600A066")]
    [Address(RVA = "0x61C6B0", Offset = "0x61B4B0", VA = "0x1061C6B0")]
    public void ResetDailyFree()
    {
    }
  }
}
