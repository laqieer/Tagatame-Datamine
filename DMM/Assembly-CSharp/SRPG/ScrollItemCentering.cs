// Decompiled with JetBrains decompiler
// Type: SRPG.ScrollItemCentering
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
  [Token(Token = "0x2002A74")]
  public class ScrollItemCentering : SRPG_ScrollRect
  {
    [Token(Token = "0x400CEA5")]
    [FieldOffset(Offset = "0x124")]
    public ContentNode BaseNode;
    [Token(Token = "0x400CEA6")]
    [FieldOffset(Offset = "0x128")]
    public GameObject PageIconParent;
    [Token(Token = "0x400CEA7")]
    [FieldOffset(Offset = "0x12C")]
    public GameObject BasePageIcon;
    [Token(Token = "0x400CEA8")]
    [FieldOffset(Offset = "0x130")]
    public GridLayoutGroup NodeLayoutGroup;
    [Token(Token = "0x400CEA9")]
    [FieldOffset(Offset = "0x134")]
    public int StartCount;
    [Token(Token = "0x400CEAA")]
    [FieldOffset(Offset = "0x138")]
    private ContentSource mContentSource;
    [Token(Token = "0x400CEAB")]
    [FieldOffset(Offset = "0x13C")]
    private int mMaxListCount;
    [Token(Token = "0x400CEAC")]
    [FieldOffset(Offset = "0x140")]
    private int mCurrentPage;
    [Token(Token = "0x400CEAD")]
    [FieldOffset(Offset = "0x144")]
    private float mCellWidth;
    [Token(Token = "0x400CEAE")]
    [FieldOffset(Offset = "0x148")]
    private List<Toggle> mDotList;
    [Token(Token = "0x400CEAF")]
    [FieldOffset(Offset = "0x14C")]
    private bool mDragging;
    [Token(Token = "0x400CEB0")]
    [FieldOffset(Offset = "0x150")]
    private IEnumerator mMove;
    [Token(Token = "0x400CEB1")]
    [FieldOffset(Offset = "0x154")]
    private float centering_offset;
    [Token(Token = "0x400CEB2")]
    [FieldOffset(Offset = "0x158")]
    private int CellMarginLeftNum;
    [Token(Token = "0x400CEB3")]
    [FieldOffset(Offset = "0x15C")]
    private int CellMarginRightNum;
    [Token(Token = "0x400CEB4")]
    [FieldOffset(Offset = "0x160")]
    private List<UnityAction> mPageActionList;

    [Token(Token = "0x600C1D1")]
    [Address(RVA = "0x8A0530", Offset = "0x89F330", VA = "0x108A0530", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C1D2")]
    [Address(RVA = "0x8A0050", Offset = "0x89EE50", VA = "0x108A0050", Slot = "44")]
    public override void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C1D3")]
    [Address(RVA = "0x8A0070", Offset = "0x89EE70", VA = "0x108A0070", Slot = "45")]
    public override void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C1D4")]
    [Address(RVA = "0x89FCD0", Offset = "0x89EAD0", VA = "0x1089FCD0", Slot = "48")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600C1D5")]
    [Address(RVA = "0x89F870", Offset = "0x89E670", VA = "0x1089F870")]
    public void Initialize(ContentSource _contentsource, List<UnityAction> _action_list)
    {
    }

    [Token(Token = "0x600C1D6")]
    [Address(RVA = "0x89F7D0", Offset = "0x89E5D0", VA = "0x1089F7D0")]
    private int GetListCount(int _now_count) => new int();

    [Token(Token = "0x600C1D7")]
    [Address(RVA = "0x8A0360", Offset = "0x89F160", VA = "0x108A0360")]
    private void StartNodeList()
    {
    }

    [Token(Token = "0x600C1D8")]
    [Address(RVA = "0x89F640", Offset = "0x89E440", VA = "0x1089F640")]
    private void CommonNodeCreate(int _display_num, int _list_num)
    {
    }

    [Token(Token = "0x600C1D9")]
    [Address(RVA = "0x8A02C0", Offset = "0x89F0C0", VA = "0x108A02C0")]
    public void SetCurrentPage(int _page, UnityAction action = null)
    {
    }

    [Token(Token = "0x600C1DA")]
    [Address(RVA = "0x89F520", Offset = "0x89E320", VA = "0x1089F520")]
    public bool ChangeCenterPage(int _page) => new bool();

    [Token(Token = "0x600C1DB")]
    [Address(RVA = "0x89F580", Offset = "0x89E380", VA = "0x1089F580")]
    private void ChangeDot(int _num = -1)
    {
    }

    [Token(Token = "0x600C1DC")]
    [Address(RVA = "0x8A0300", Offset = "0x89F100", VA = "0x108A0300")]
    private void SetCurrentSource(ContentSource _source)
    {
    }

    [Token(Token = "0x600C1DD")]
    [Address(RVA = "0x89F840", Offset = "0x89E640", VA = "0x1089F840")]
    public ContentSource.Param GetParam(int _index) => (ContentSource.Param) null;

    [Token(Token = "0x600C1DE")]
    [Address(RVA = "0x8A0130", Offset = "0x89EF30", VA = "0x108A0130")]
    private void OnValueChanged(Vector2 value)
    {
    }

    [Token(Token = "0x600C1DF")]
    [Address(RVA = "0x8A0830", Offset = "0x89F630", VA = "0x108A0830")]
    private IEnumerator movePage(int _next_page, bool _is_action = false) => (IEnumerator) null;

    [Token(Token = "0x600C1E0")]
    [Address(RVA = "0x8A06A0", Offset = "0x89F4A0", VA = "0x108A06A0")]
    private float getPageOffset(int _num) => new float();

    [Token(Token = "0x600C1E1")]
    [Address(RVA = "0x5B2580", Offset = "0x5B1380", VA = "0x105B2580")]
    private float decelerate(float value) => new float();

    [Token(Token = "0x600C1E2")]
    [Address(RVA = "0x8A0090", Offset = "0x89EE90", VA = "0x108A0090")]
    public void OnLeftButtonClick()
    {
    }

    [Token(Token = "0x600C1E3")]
    [Address(RVA = "0x8A00E0", Offset = "0x89EEE0", VA = "0x108A00E0")]
    public void OnRightButtonClick()
    {
    }

    [Token(Token = "0x600C1E4")]
    [Address(RVA = "0x8A05D0", Offset = "0x89F3D0", VA = "0x108A05D0")]
    public ScrollItemCentering()
    {
    }
  }
}
