// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_FixedList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001136")]
  [AddComponentMenu("Common/SRPG_FixedList")]
  public class SRPG_FixedList : UIBehaviour
  {
    [Token(Token = "0x4003EAD")]
    [FieldOffset(Offset = "0xC")]
    protected int mPage;
    [Token(Token = "0x4003EAE")]
    [FieldOffset(Offset = "0x10")]
    protected int mMaxPages;
    [Token(Token = "0x4003EAF")]
    [FieldOffset(Offset = "0x14")]
    protected int mPageSize;
    [Token(Token = "0x4003EB0")]
    [FieldOffset(Offset = "0x18")]
    private GridLayoutGroup mGrid;
    [Token(Token = "0x4003EB1")]
    [FieldOffset(Offset = "0x1C")]
    private int mCellCountX;
    [Token(Token = "0x4003EB2")]
    [FieldOffset(Offset = "0x20")]
    private int mCellCountY;
    [Token(Token = "0x4003EB3")]
    [FieldOffset(Offset = "0x24")]
    private bool mStarted;
    [Token(Token = "0x4003EB4")]
    [FieldOffset(Offset = "0x25")]
    private bool mShouldRefresh;
    [Token(Token = "0x4003EB5")]
    [FieldOffset(Offset = "0x26")]
    private bool mCalculatedCellCounts;
    [Token(Token = "0x4003EB6")]
    [FieldOffset(Offset = "0x27")]
    protected bool mInvokeSelChange;
    [Token(Token = "0x4003EB7")]
    [FieldOffset(Offset = "0x28")]
    protected List<GameObject> mItems;
    [Token(Token = "0x4003EB8")]
    [FieldOffset(Offset = "0x2C")]
    protected bool mFocusSelection;
    [Token(Token = "0x4003EB9")]
    [FieldOffset(Offset = "0x30")]
    protected object[] mData;
    [Token(Token = "0x4003EBA")]
    [FieldOffset(Offset = "0x34")]
    protected System.Type mDataType;
    [Token(Token = "0x4003EBB")]
    [FieldOffset(Offset = "0x38")]
    public SRPG_FixedList.SelectionChangeEvent OnSelectionChange;
    [Token(Token = "0x4003EBC")]
    [FieldOffset(Offset = "0x3C")]
    public Scrollbar PageScrollBar;
    [Token(Token = "0x4003EBD")]
    [FieldOffset(Offset = "0x40")]
    public Text PageIndex;
    [Token(Token = "0x4003EBE")]
    [FieldOffset(Offset = "0x44")]
    public int MaxSelection;
    [Token(Token = "0x4003EBF")]
    [FieldOffset(Offset = "0x48")]
    public Text PageIndexMax;
    [Token(Token = "0x4003EC0")]
    [FieldOffset(Offset = "0x4C")]
    public Text NumSelection;
    [Token(Token = "0x4003EC1")]
    [FieldOffset(Offset = "0x50")]
    public Button ForwardButton;
    [Token(Token = "0x4003EC2")]
    [FieldOffset(Offset = "0x54")]
    public Button BackButton;
    [Token(Token = "0x4003EC3")]
    [FieldOffset(Offset = "0x58")]
    public GameObject[] ExtraItems;
    [Token(Token = "0x4003EC4")]
    [FieldOffset(Offset = "0x5C")]
    protected List<object> mSelection;
    [Token(Token = "0x4003EC5")]
    [FieldOffset(Offset = "0x60")]
    public int MaxCellCount;

    [Token(Token = "0x600499A")]
    [Address(RVA = "0x12047B0", Offset = "0x12035B0", VA = "0x112047B0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x17000805")]
    public bool IsRefreshing
    {
      [Token(Token = "0x600499B"), Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000806")]
    public virtual RectTransform ListParent
    {
      [Token(Token = "0x600499C"), Address(RVA = "0x1204F40", Offset = "0x1203D40", VA = "0x11204F40", Slot = "17")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600499D")]
    [Address(RVA = "0x1204620", Offset = "0x1203420", VA = "0x11204620", Slot = "18")]
    public virtual void SetData(object[] src, System.Type type)
    {
    }

    [Token(Token = "0x600499E")]
    [Address(RVA = "0x1203E10", Offset = "0x1202C10", VA = "0x11203E10")]
    private void RecalculateCellCounts()
    {
    }

    [Token(Token = "0x17000807")]
    public int CellCount
    {
      [Token(Token = "0x600499F"), Address(RVA = "0x1204F00", Offset = "0x1203D00", VA = "0x11204F00")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000808")]
    public int Page
    {
      [Token(Token = "0x60049A0"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60049A1"), Address(RVA = "0x1204FC0", Offset = "0x1203DC0", VA = "0x11204FC0")] set
      {
      }
    }

    [Token(Token = "0x17000809")]
    public int MaxPage
    {
      [Token(Token = "0x60049A2"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700080A")]
    public object[] Selection
    {
      [Token(Token = "0x60049A3"), Address(RVA = "0x1204F80", Offset = "0x1203D80", VA = "0x11204F80")] get
      {
        return (object[]) null;
      }
    }

    [Token(Token = "0x1700080B")]
    protected object[] Data
    {
      [Token(Token = "0x60049A4"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (object[]) null;
      }
    }

    [Token(Token = "0x1700080C")]
    protected virtual int DataCount
    {
      [Token(Token = "0x60049A5"), Address(RVA = "0x1204F20", Offset = "0x1203D20", VA = "0x11204F20", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60049A6")]
    [Address(RVA = "0x1203DF0", Offset = "0x1202BF0", VA = "0x11203DF0", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x60049A7")]
    [Address(RVA = "0x1203DC0", Offset = "0x1202BC0", VA = "0x11203DC0", Slot = "20")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x60049A8")]
    [Address(RVA = "0x1203DC0", Offset = "0x1202BC0", VA = "0x11203DC0", Slot = "21")]
    protected virtual void LateUpdate()
    {
    }

    [Token(Token = "0x60049A9")]
    [Address(RVA = "0x456060", Offset = "0x454E60", VA = "0x10456060")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60049AA")]
    [Address(RVA = "0x1203B20", Offset = "0x1202920", VA = "0x11203B20")]
    public void CancelRefresh()
    {
    }

    [Token(Token = "0x60049AB")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "22")]
    protected virtual GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x60049AC")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "23")]
    protected virtual GameObject CreateItem(int index) => (GameObject) null;

    [Token(Token = "0x1700080D")]
    protected bool HasStarted
    {
      [Token(Token = "0x60049AD"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60049AE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "24")]
    protected virtual void OnUpdateItem(GameObject go, int index)
    {
    }

    [Token(Token = "0x60049AF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "25")]
    protected virtual void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x60049B0")]
    [Address(RVA = "0x1204B00", Offset = "0x1203900", VA = "0x11204B00")]
    protected void _OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x60049B1")]
    [Address(RVA = "0x12040E0", Offset = "0x1202EE0", VA = "0x112040E0", Slot = "26")]
    protected virtual void RefreshItems()
    {
    }

    [Token(Token = "0x60049B2")]
    [Address(RVA = "0x1203D50", Offset = "0x1202B50", VA = "0x11203D50")]
    private IEnumerator InitPage() => (IEnumerator) null;

    [Token(Token = "0x60049B3")]
    [Address(RVA = "0x1203980", Offset = "0x1202780", VA = "0x11203980", Slot = "27")]
    public virtual void BindData()
    {
    }

    [Token(Token = "0x60049B4")]
    [Address(RVA = "0x1203B30", Offset = "0x1202930", VA = "0x11203B30")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x60049B5")]
    [Address(RVA = "0x1203C90", Offset = "0x1202A90", VA = "0x11203C90")]
    public void ClearSelection()
    {
    }

    [Token(Token = "0x60049B6")]
    [Address(RVA = "0x12047D0", Offset = "0x12035D0", VA = "0x112047D0", Slot = "28")]
    protected virtual void TriggerSelectionChange()
    {
    }

    [Token(Token = "0x60049B7")]
    [Address(RVA = "0x1204800", Offset = "0x1203600", VA = "0x11204800", Slot = "29")]
    public virtual void UpdatePage()
    {
    }

    [Token(Token = "0x60049B8")]
    [Address(RVA = "0x1203D30", Offset = "0x1202B30", VA = "0x11203D30", Slot = "30")]
    public virtual void GotoPreviousPage()
    {
    }

    [Token(Token = "0x60049B9")]
    [Address(RVA = "0x1203D10", Offset = "0x1202B10", VA = "0x11203D10", Slot = "31")]
    public virtual void GotoNextPage()
    {
    }

    [Token(Token = "0x60049BA")]
    [Address(RVA = "0x1204650", Offset = "0x1203450", VA = "0x11204650")]
    public void SetPageIndex(int pIndex = -1, bool isRefresh = false)
    {
    }

    [Token(Token = "0x60049BB")]
    [Address(RVA = "0x12044C0", Offset = "0x12032C0", VA = "0x112044C0")]
    public void RegisterNextButtonCallBack(UnityAction callBack)
    {
    }

    [Token(Token = "0x60049BC")]
    [Address(RVA = "0x1204570", Offset = "0x1203370", VA = "0x11204570")]
    public void RegisterPrevButtonCallBack(UnityAction callBack)
    {
    }

    [Token(Token = "0x60049BD")]
    [Address(RVA = "0x1204A60", Offset = "0x1203860", VA = "0x11204A60")]
    public void UpdateSelection()
    {
    }

    [Token(Token = "0x60049BE")]
    [Address(RVA = "0x1204680", Offset = "0x1203480", VA = "0x11204680")]
    public void SetSelection(object[] sel, bool invoke, bool focus)
    {
    }

    [Token(Token = "0x60049BF")]
    [Address(RVA = "0x1204C60", Offset = "0x1203A60", VA = "0x11204C60")]
    public SRPG_FixedList()
    {
    }

    [Token(Token = "0x2001137")]
    public delegate void SelectionChangeEvent(SRPG_FixedList list);
  }
}
