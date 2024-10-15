// Decompiled with JetBrains decompiler
// Type: SRPG.GachaCostSelectorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002408")]
  public class GachaCostSelectorData
  {
    [Token(Token = "0x400A2E5")]
    [FieldOffset(Offset = "0x8")]
    private int mFixMax;
    [Token(Token = "0x400A2E6")]
    [FieldOffset(Offset = "0xC")]
    private ItemData mItem;
    [Token(Token = "0x400A2E7")]
    [FieldOffset(Offset = "0x10")]
    private int mInitSelectValue;
    [Token(Token = "0x400A2E8")]
    [FieldOffset(Offset = "0x14")]
    private int mLastSelectValue;
    [Token(Token = "0x400A2E9")]
    [FieldOffset(Offset = "0x18")]
    private string mLastSelectGachaIname;
    [Token(Token = "0x400A2EA")]
    [FieldOffset(Offset = "0x1C")]
    private int mConsumeNum;

    [Token(Token = "0x170015CE")]
    public int fix_max
    {
      [Token(Token = "0x6009CD1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015CF")]
    public ItemData item
    {
      [Token(Token = "0x6009CD2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x170015D0")]
    public int init_select_value
    {
      [Token(Token = "0x6009CD3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015D1")]
    public int last_select_value
    {
      [Token(Token = "0x6009CD4"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170015D2")]
    public string last_select_gname
    {
      [Token(Token = "0x6009CD5"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D3")]
    public string title_name
    {
      [Token(Token = "0x6009CD6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009CD7"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x170015D4")]
    public string cost_index_text
    {
      [Token(Token = "0x6009CD8"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009CD9"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
      {
      }
    }

    [Token(Token = "0x170015D5")]
    public string confirm_text
    {
      [Token(Token = "0x6009CDA"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009CDB"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x170015D6")]
    public string caution_text
    {
      [Token(Token = "0x6009CDC"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009CDD"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x170015D7")]
    public int consume_num
    {
      [Token(Token = "0x6009CDE"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6009CDF")]
    [Address(RVA = "0x5FE340", Offset = "0x5FD140", VA = "0x105FE340")]
    public GachaCostSelectorData(BoxGachaManager.BoxGachaStatus bgstatus)
    {
    }
  }
}
