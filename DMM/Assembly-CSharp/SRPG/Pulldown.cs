// Decompiled with JetBrains decompiler
// Type: SRPG.Pulldown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200285C")]
  public class Pulldown : 
    Selectable,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IEndDragHandler
  {
    [Token(Token = "0x400C0B5")]
    [FieldOffset(Offset = "0xB0")]
    public Pulldown.SetupPulldownItemEvent OnSetupPulldownItem;
    [Token(Token = "0x400C0B6")]
    [FieldOffset(Offset = "0xB4")]
    public Pulldown.UpdateSelectionEvent OnUpdateSelection;
    [Token(Token = "0x400C0B7")]
    [FieldOffset(Offset = "0xB8")]
    public RectTransform PulldownMenu;
    [Token(Token = "0x400C0B8")]
    [FieldOffset(Offset = "0xBC")]
    public Text SelectionText;
    [Token(Token = "0x400C0B9")]
    [FieldOffset(Offset = "0xC0")]
    public GameObject PulldownItemTemplate;
    [Token(Token = "0x400C0BA")]
    [FieldOffset(Offset = "0xC4")]
    public Text PulldownText;
    [Token(Token = "0x400C0BB")]
    [FieldOffset(Offset = "0xC8")]
    public Graphic PulldownGraphic;
    [Token(Token = "0x400C0BC")]
    [FieldOffset(Offset = "0xCC")]
    public string OpenSE;
    [Token(Token = "0x400C0BD")]
    [FieldOffset(Offset = "0xD0")]
    public string CloseSE;
    [Token(Token = "0x400C0BE")]
    [FieldOffset(Offset = "0xD4")]
    public string SelectSE;
    [Token(Token = "0x400C0BF")]
    [FieldOffset(Offset = "0xD8")]
    public Pulldown.SelectItemEvent OnSelectionChangeDelegate;
    [Token(Token = "0x400C0C0")]
    [FieldOffset(Offset = "0xDC")]
    public UnityAction<int> OnSelectionChange;
    [Token(Token = "0x400C0C1")]
    [FieldOffset(Offset = "0xE0")]
    private int mPrevSelectionIndex;
    [Token(Token = "0x400C0C2")]
    [FieldOffset(Offset = "0xE4")]
    private int mSelectionIndex;
    [Token(Token = "0x400C0C3")]
    [FieldOffset(Offset = "0xE8")]
    private bool mOpened;
    [Token(Token = "0x400C0C4")]
    [FieldOffset(Offset = "0xE9")]
    private bool mAutoClose;
    [Token(Token = "0x400C0C5")]
    [FieldOffset(Offset = "0xEA")]
    private bool mTrackTouchPosititon;
    [Token(Token = "0x400C0C6")]
    [FieldOffset(Offset = "0xEC")]
    private List<PulldownItem> mItems;
    [Token(Token = "0x400C0C7")]
    [FieldOffset(Offset = "0xF0")]
    private bool mPulldownItemInitialized;
    [Token(Token = "0x400C0C8")]
    [FieldOffset(Offset = "0xF1")]
    private bool mPollMouseUp;

    [Token(Token = "0x170018FD")]
    public int Selection
    {
      [Token(Token = "0x600B649"), Address(RVA = "0x664D40", Offset = "0x663B40", VA = "0x10664D40")] get
      {
        return new int();
      }
      [Token(Token = "0x600B64A"), Address(RVA = "0x7CDB20", Offset = "0x7CC920", VA = "0x107CDB20")] set
      {
      }
    }

    [Token(Token = "0x600B64B")]
    [Address(RVA = "0x7CCD10", Offset = "0x7CBB10", VA = "0x107CCD10", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600B64C")]
    [Address(RVA = "0x7CD670", Offset = "0x7CC470", VA = "0x107CD670", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B64D")]
    [Address(RVA = "0x7CD100", Offset = "0x7CBF00", VA = "0x107CD100", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600B64E")]
    [Address(RVA = "0x7CD280", Offset = "0x7CC080", VA = "0x107CD280")]
    private void OnPulldownMenuTouch(BaseEventData eventData)
    {
    }

    [Token(Token = "0x600B64F")]
    [Address(RVA = "0x7CD630", Offset = "0x7CC430", VA = "0x107CD630", Slot = "42")]
    protected virtual PulldownItem SetupPulldownItem(GameObject itemObject) => (PulldownItem) null;

    [Token(Token = "0x600B650")]
    [Address(RVA = "0x7CCB50", Offset = "0x7CB950", VA = "0x107CCB50", Slot = "43")]
    public virtual PulldownItem AddItem(string label, int value) => (PulldownItem) null;

    [Token(Token = "0x600B651")]
    [Address(RVA = "0x7CD8E0", Offset = "0x7CC6E0", VA = "0x107CD8E0")]
    private void TriggerItemChange()
    {
    }

    [Token(Token = "0x600B652")]
    [Address(RVA = "0x7CCDD0", Offset = "0x7CBBD0", VA = "0x107CCDD0")]
    public void ClearItems()
    {
    }

    [Token(Token = "0x600B653")]
    [Address(RVA = "0x7CD3F0", Offset = "0x7CC1F0", VA = "0x107CD3F0")]
    private void SelectNearestItem(PointerEventData e)
    {
    }

    [Token(Token = "0x600B654")]
    [Address(RVA = "0x7CD1F0", Offset = "0x7CBFF0", VA = "0x107CD1F0", Slot = "32")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B655")]
    [Address(RVA = "0x7CD310", Offset = "0x7CC110", VA = "0x107CD310", Slot = "44")]
    protected virtual void OpenPulldown()
    {
    }

    [Token(Token = "0x600B656")]
    [Address(RVA = "0x7CCF60", Offset = "0x7CBD60", VA = "0x107CCF60", Slot = "45")]
    protected virtual void ClosePulldown(bool se = true)
    {
    }

    [Token(Token = "0x600B657")]
    [Address(RVA = "0x7CD120", Offset = "0x7CBF20", VA = "0x107CD120", Slot = "40")]
    public void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B658")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "39")]
    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B659")]
    [Address(RVA = "0x7CD150", Offset = "0x7CBF50", VA = "0x107CD150", Slot = "41")]
    public void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B65A")]
    [Address(RVA = "0x7CD260", Offset = "0x7CC060", VA = "0x107CD260", Slot = "33")]
    public override void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B65B")]
    [Address(RVA = "0x7CD9D0", Offset = "0x7CC7D0", VA = "0x107CD9D0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B65C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "46")]
    protected virtual void UpdateSelection()
    {
    }

    [Token(Token = "0x600B65D")]
    [Address(RVA = "0x7CD0A0", Offset = "0x7CBEA0", VA = "0x107CD0A0")]
    public PulldownItem GetItemAt(int index) => (PulldownItem) null;

    [Token(Token = "0x170018FE")]
    public int ItemCount
    {
      [Token(Token = "0x600B65E"), Address(RVA = "0x7CDAE0", Offset = "0x7CC8E0", VA = "0x107CDAE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B65F")]
    [Address(RVA = "0x7CD030", Offset = "0x7CBE30", VA = "0x107CD030")]
    public PulldownItem GetCurrentSelection() => (PulldownItem) null;

    [Token(Token = "0x600B660")]
    [Address(RVA = "0x7CD010", Offset = "0x7CBE10", VA = "0x107CD010")]
    public void CloseSelf()
    {
    }

    [Token(Token = "0x600B661")]
    [Address(RVA = "0x7CDA30", Offset = "0x7CC830", VA = "0x107CDA30")]
    public Pulldown()
    {
    }

    [Token(Token = "0x200285D")]
    public delegate PulldownItem SetupPulldownItemEvent(GameObject go);

    [Token(Token = "0x200285E")]
    public delegate void UpdateSelectionEvent();

    [Token(Token = "0x200285F")]
    public delegate void SelectItemEvent(int value);
  }
}
