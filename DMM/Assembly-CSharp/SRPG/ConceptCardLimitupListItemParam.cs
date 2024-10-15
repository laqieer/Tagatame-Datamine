// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLimitupListItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C4")]
  public class ConceptCardLimitupListItemParam : ContentSource.Param
  {
    [Token(Token = "0x400940F")]
    [FieldOffset(Offset = "0x10")]
    private ConceptCardLevelupListItemNode mNode;
    [Token(Token = "0x4009410")]
    [FieldOffset(Offset = "0x14")]
    private int _currentAwake;
    [Token(Token = "0x4009411")]
    [FieldOffset(Offset = "0x18")]
    private int _awakeCap;
    [Token(Token = "0x4009412")]
    [FieldOffset(Offset = "0x1C")]
    private int _needNum;
    [Token(Token = "0x4009413")]
    [FieldOffset(Offset = "0x20")]
    private ConceptCardLimitUpListItem.CheckSliderValue _onCheck;
    [Token(Token = "0x4009414")]
    [FieldOffset(Offset = "0x24")]
    private Action _onRefresh;
    [Token(Token = "0x4009415")]
    [FieldOffset(Offset = "0x28")]
    private ItemData _itemData;
    [Token(Token = "0x4009416")]
    [FieldOffset(Offset = "0x2C")]
    private bool _isCached;
    [Token(Token = "0x4009417")]
    [FieldOffset(Offset = "0x30")]
    private int _cacheSliderValue;

    [Token(Token = "0x1700141B")]
    public int CurrentAwake
    {
      [Token(Token = "0x6008E5F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700141C")]
    public int AwakeCap
    {
      [Token(Token = "0x6008E60"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700141D")]
    public int NeedNum
    {
      [Token(Token = "0x6008E61"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700141E")]
    public ConceptCardLimitUpListItem.CheckSliderValue OnCheck
    {
      [Token(Token = "0x6008E62"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ConceptCardLimitUpListItem.CheckSliderValue) null;
      }
    }

    [Token(Token = "0x1700141F")]
    public Action OnRefresh
    {
      [Token(Token = "0x6008E63"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (Action) null;
      }
    }

    [Token(Token = "0x17001420")]
    public ItemData Item
    {
      [Token(Token = "0x6008E64"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17001421")]
    public bool IsCached
    {
      [Token(Token = "0x6008E65"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001422")]
    public int CacheSliderValue
    {
      [Token(Token = "0x6008E66"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008E67")]
    [Address(RVA = "0x51AEA0", Offset = "0x519CA0", VA = "0x1051AEA0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6008E68")]
    [Address(RVA = "0x51AD20", Offset = "0x519B20", VA = "0x1051AD20", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6008E69")]
    [Address(RVA = "0x51B230", Offset = "0x51A030", VA = "0x1051B230")]
    private void SaveSelected()
    {
    }

    [Token(Token = "0x6008E6A")]
    [Address(RVA = "0x51B1A0", Offset = "0x519FA0", VA = "0x1051B1A0")]
    public void ResetSelected()
    {
    }

    [Token(Token = "0x6008E6B")]
    [Address(RVA = "0x51B070", Offset = "0x519E70", VA = "0x1051B070")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008E6C")]
    [Address(RVA = "0x51B1C0", Offset = "0x519FC0", VA = "0x1051B1C0")]
    public void Reset()
    {
    }

    [Token(Token = "0x6008E6D")]
    [Address(RVA = "0x51B3F0", Offset = "0x51A1F0", VA = "0x1051B3F0")]
    public void SetValue(int current_awake, int awake_cap, int need_num)
    {
    }

    [Token(Token = "0x6008E6E")]
    [Address(RVA = "0x51B350", Offset = "0x51A150", VA = "0x1051B350")]
    public void SetDelegate(ConceptCardLimitUpListItem.CheckSliderValue check, Action refresh)
    {
    }

    [Token(Token = "0x6008E6F")]
    [Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")]
    public void SetData(ItemData data)
    {
    }

    [Token(Token = "0x6008E70")]
    [Address(RVA = "0x51B380", Offset = "0x51A180", VA = "0x1051B380")]
    public void SetInputLock(bool is_lock)
    {
    }

    [Token(Token = "0x6008E71")]
    [Address(RVA = "0x51ABA0", Offset = "0x5199A0", VA = "0x1051ABA0")]
    public int GetUpCount() => new int();

    [Token(Token = "0x6008E72")]
    [Address(RVA = "0x51AC60", Offset = "0x519A60", VA = "0x1051AC60")]
    public int GetUseNum() => new int();

    [Token(Token = "0x6008E73")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public ConceptCardLimitupListItemParam()
    {
    }
  }
}
