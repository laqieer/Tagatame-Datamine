// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestChapterScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002806")]
  public class PointQuestChapterScrollRect : SRPG_ScrollRect
  {
    [Token(Token = "0x400BE76")]
    [FieldOffset(Offset = "0x124")]
    public RectTransform ItemObj;
    [Token(Token = "0x400BE77")]
    [FieldOffset(Offset = "0x128")]
    public RectTransform WindowObj;
    [Token(Token = "0x400BE78")]
    [FieldOffset(Offset = "0x12C")]
    public HorizontalLayoutGroup LayoutGroup;
    [Token(Token = "0x400BE79")]
    [FieldOffset(Offset = "0x130")]
    public float CirculationWidth;
    [Token(Token = "0x400BE7A")]
    [FieldOffset(Offset = "0x134")]
    public int CirculationNum;
    [Token(Token = "0x400BE7B")]
    [FieldOffset(Offset = "0x138")]
    public float StartCenteringVelocity;
    [Token(Token = "0x400BE7C")]
    [FieldOffset(Offset = "0x13C")]
    public float CenteringDecelerateValue;
    [Token(Token = "0x400BE7D")]
    [FieldOffset(Offset = "0x140")]
    private int mListMaxCount;
    [Token(Token = "0x400BE7E")]
    [FieldOffset(Offset = "0x144")]
    private int mCenterIndex;
    [Token(Token = "0x400BE7F")]
    [FieldOffset(Offset = "0x148")]
    private float mCellWidth;
    [Token(Token = "0x400BE80")]
    [FieldOffset(Offset = "0x14C")]
    private float mLayoutSpace;
    [Token(Token = "0x400BE81")]
    [FieldOffset(Offset = "0x150")]
    private PointQuestChapterSelectorView mSelectorView;
    [Token(Token = "0x400BE82")]
    [FieldOffset(Offset = "0x154")]
    private List<PointQuestChapterSelectorItem> mItemList;
    [Token(Token = "0x400BE83")]
    [FieldOffset(Offset = "0x158")]
    private bool mVelocityCheck;
    [Token(Token = "0x400BE84")]
    [FieldOffset(Offset = "0x15C")]
    private float mCenteringTime;
    [Token(Token = "0x400BE85")]
    [FieldOffset(Offset = "0x160")]
    private IEnumerator mMove;
    [Token(Token = "0x400BE86")]
    [FieldOffset(Offset = "0x164")]
    private float mMarginWidth;
    [Token(Token = "0x400BE87")]
    [FieldOffset(Offset = "0x168")]
    private bool mIsDrag;
    [Token(Token = "0x400BE88")]
    [FieldOffset(Offset = "0x16C")]
    private float mOffset;
    [Token(Token = "0x400BE89")]
    [FieldOffset(Offset = "0x170")]
    private Vector2 mContentPosition;
    [Token(Token = "0x400BE8A")]
    [FieldOffset(Offset = "0x178")]
    private float mViewportHalfWidth;

    [Token(Token = "0x600B4B1")]
    [Address(RVA = "0x7B2D60", Offset = "0x7B1B60", VA = "0x107B2D60", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B4B2")]
    [Address(RVA = "0x7B29E0", Offset = "0x7B17E0", VA = "0x107B29E0", Slot = "44")]
    public override void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B4B3")]
    [Address(RVA = "0x7B2A50", Offset = "0x7B1850", VA = "0x107B2A50", Slot = "45")]
    public override void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B4B4")]
    [Address(RVA = "0x7B2A10", Offset = "0x7B1810", VA = "0x107B2A10", Slot = "46")]
    public override void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600B4B5")]
    [Address(RVA = "0x7B2410", Offset = "0x7B1210", VA = "0x107B2410", Slot = "48")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600B4B6")]
    [Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x107B1F90")]
    public void Init(
      PointQuestChapterSelectorView _view,
      List<PointQuestChapterSelectorItem> _item_list,
      int _start_index,
      GameObject _left_margin_obj,
      GameObject _right_margin_obj)
    {
    }

    [Token(Token = "0x600B4B7")]
    [Address(RVA = "0x7B2C50", Offset = "0x7B1A50", VA = "0x107B2C50")]
    public void SetCurrentPage(int _index)
    {
    }

    [Token(Token = "0x600B4B8")]
    [Address(RVA = "0x7B1D30", Offset = "0x7B0B30", VA = "0x107B1D30")]
    public bool ChangeCenterPage(int _index) => new bool();

    [Token(Token = "0x600B4B9")]
    [Address(RVA = "0x7B2AF0", Offset = "0x7B18F0", VA = "0x107B2AF0")]
    private void OnValueChanged(Vector2 value)
    {
    }

    [Token(Token = "0x600B4BA")]
    [Address(RVA = "0x7B2890", Offset = "0x7B1690", VA = "0x107B2890")]
    private IEnumerator MoveIndex(int _next_page, float _offset_from = 0.0f) => (IEnumerator) null;

    [Token(Token = "0x600B4BB")]
    [Address(RVA = "0x7B1F20", Offset = "0x7B0D20", VA = "0x107B1F20")]
    private IEnumerator InitMove(int _center_index) => (IEnumerator) null;

    [Token(Token = "0x600B4BC")]
    [Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x107B1F00")]
    private float GetPageOffset(int _num) => new float();

    [Token(Token = "0x600B4BD")]
    [Address(RVA = "0x7B2E80", Offset = "0x7B1C80", VA = "0x107B2E80")]
    private float decelerate(float value) => new float();

    [Token(Token = "0x600B4BE")]
    [Address(RVA = "0x7B2A80", Offset = "0x7B1880", VA = "0x107B2A80")]
    public void OnLeftButtonClick(int _move_num)
    {
    }

    [Token(Token = "0x600B4BF")]
    [Address(RVA = "0x7B2AD0", Offset = "0x7B18D0", VA = "0x107B2AD0")]
    public void OnRightButtonClick(int _move_num)
    {
    }

    [Token(Token = "0x600B4C0")]
    [Address(RVA = "0x7B2AB0", Offset = "0x7B18B0", VA = "0x107B2AB0")]
    public void OnPointerUpScrollbar()
    {
    }

    [Token(Token = "0x600B4C1")]
    [Address(RVA = "0x7B1E30", Offset = "0x7B0C30", VA = "0x107B1E30")]
    public int GetNowCenterIndex() => new int();

    [Token(Token = "0x600B4C2")]
    [Address(RVA = "0x7B2910", Offset = "0x7B1710", VA = "0x107B2910")]
    private void OnApplicationFocus(bool _status)
    {
    }

    [Token(Token = "0x600B4C3")]
    [Address(RVA = "0x7B2E00", Offset = "0x7B1C00", VA = "0x107B2E00")]
    public PointQuestChapterScrollRect()
    {
    }
  }
}
