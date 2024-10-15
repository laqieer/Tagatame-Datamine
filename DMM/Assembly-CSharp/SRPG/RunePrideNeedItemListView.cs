// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideNeedItemListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A0C")]
  public class RunePrideNeedItemListView : BaseNeedItemListView
  {
    [Token(Token = "0x400CC67")]
    [FieldOffset(Offset = "0x24")]
    private List<RunePrideNeedItemListView.NeedItemData> mNeedItemDataList;

    [Token(Token = "0x600BFAE")]
    [Address(RVA = "0x882700", Offset = "0x881500", VA = "0x10882700")]
    private void Start()
    {
    }

    [Token(Token = "0x600BFAF")]
    [Address(RVA = "0x881D10", Offset = "0x880B10", VA = "0x10881D10")]
    public void Init(List<JSON_RunePrideSubMats> _data_list)
    {
    }

    [Token(Token = "0x600BFB0")]
    [Address(RVA = "0x881750", Offset = "0x880550", VA = "0x10881750")]
    public void Init(List<RunePrideItemData> _data_list)
    {
    }

    [Token(Token = "0x600BFB1")]
    [Address(RVA = "0x8810F0", Offset = "0x87FEF0", VA = "0x108810F0")]
    public void AddList(List<RunePrideItemData> _add_list)
    {
    }

    [Token(Token = "0x600BFB2")]
    [Address(RVA = "0x882240", Offset = "0x881040", VA = "0x10882240")]
    public void RemoveList(List<RunePrideItemData> _remove_list)
    {
    }

    [Token(Token = "0x600BFB3")]
    [Address(RVA = "0x882750", Offset = "0x881550", VA = "0x10882750")]
    public RunePrideNeedItemListView()
    {
    }

    [Token(Token = "0x2002A0D")]
    private class NeedItemData
    {
      [Token(Token = "0x400CC68")]
      [FieldOffset(Offset = "0x8")]
      private string mItemIname;
      [Token(Token = "0x400CC69")]
      [FieldOffset(Offset = "0xC")]
      private int mNeedNum;
      [Token(Token = "0x400CC6A")]
      [FieldOffset(Offset = "0x10")]
      private List<string> mSubInames;

      [Token(Token = "0x170019C6")]
      public string ItemIname
      {
        [Token(Token = "0x600BFB4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170019C7")]
      public int NeedNum
      {
        [Token(Token = "0x600BFB5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170019C8")]
      public List<string> SubInames
      {
        [Token(Token = "0x600BFB6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (List<string>) null;
        }
      }

      [Token(Token = "0x600BFB7")]
      [Address(RVA = "0x37BC60", Offset = "0x37AA60", VA = "0x1037BC60")]
      public void Init(string _item_iname, int _need_num)
      {
      }

      [Token(Token = "0x600BFB8")]
      [Address(RVA = "0x87CE10", Offset = "0x87BC10", VA = "0x1087CE10")]
      public void AddNum(int _add_num)
      {
      }

      [Token(Token = "0x600BFB9")]
      [Address(RVA = "0x87CE20", Offset = "0x87BC20", VA = "0x1087CE20")]
      public void SubNum(int _sub_num)
      {
      }

      [Token(Token = "0x600BFBA")]
      [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
      public void SetSubInames(List<string> _inames)
      {
      }

      [Token(Token = "0x600BFBB")]
      [Address(RVA = "0x87CE30", Offset = "0x87BC30", VA = "0x1087CE30")]
      public NeedItemData()
      {
      }
    }
  }
}
