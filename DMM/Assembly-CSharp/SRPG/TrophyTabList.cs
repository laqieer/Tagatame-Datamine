// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyTabList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B80")]
  [AddComponentMenu("UI/TrophyTabList")]
  public class TrophyTabList : MonoBehaviour
  {
    [Token(Token = "0x400D53A")]
    private const float SCROLL_RATE = 0.0f;
    [Token(Token = "0x400D53B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int CREATE_TAB_COUNT_MAX;
    [Token(Token = "0x400D53C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private TrophyCategorys TrophyCategory;
    [Token(Token = "0x400D53D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private TrophyWindow TrophyWindow;
    [Token(Token = "0x400D53E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TrophyList TrophyList;
    [Token(Token = "0x400D53F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform TabHolder;
    [Token(Token = "0x400D540")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TrophyRecordTab OriginalTab;
    [Token(Token = "0x400D541")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ScrollRect ScrollRect;
    [Token(Token = "0x400D542")]
    [FieldOffset(Offset = "0x28")]
    private List<TrophyRecordTab> mTabs;
    [Token(Token = "0x400D543")]
    [FieldOffset(Offset = "0x2C")]
    private int mCurrentTabIndex;
    [Token(Token = "0x400D544")]
    [FieldOffset(Offset = "0x30")]
    private CanvasGroup mCanvasGroup;

    [Token(Token = "0x600C795")]
    [Address(RVA = "0x905960", Offset = "0x904760", VA = "0x10905960")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600C796")]
    [Address(RVA = "0x9057D0", Offset = "0x9045D0", VA = "0x109057D0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600C797")]
    [Address(RVA = "0x904F30", Offset = "0x903D30", VA = "0x10904F30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C798")]
    [Address(RVA = "0x906180", Offset = "0x904F80", VA = "0x10906180")]
    private void Update()
    {
    }

    [Token(Token = "0x600C799")]
    [Address(RVA = "0x905B10", Offset = "0x904910", VA = "0x10905B10")]
    private void OnTrophyReset()
    {
    }

    [Token(Token = "0x600C79A")]
    [Address(RVA = "0x905030", Offset = "0x903E30", VA = "0x10905030")]
    private void ClearAllItems()
    {
    }

    [Token(Token = "0x600C79B")]
    [Address(RVA = "0x9056B0", Offset = "0x9044B0", VA = "0x109056B0")]
    public TrophyRecordTab GetCurrentSelectionTab() => (TrophyRecordTab) null;

    [Token(Token = "0x600C79C")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public TrophyCategorys GetCurrentTab() => new TrophyCategorys();

    [Token(Token = "0x600C79D")]
    [Address(RVA = "0x9051D0", Offset = "0x903FD0", VA = "0x109051D0")]
    public void CreateTrophyRecord(bool resetSelection = true)
    {
    }

    [Token(Token = "0x600C79E")]
    [Address(RVA = "0x905C00", Offset = "0x904A00", VA = "0x10905C00")]
    public void RefreshTrophyRecord()
    {
    }

    [Token(Token = "0x600C79F")]
    [Address(RVA = "0x905700", Offset = "0x904500", VA = "0x10905700")]
    private TrophyRecordTab MakeTrophyCategoryTab(string title, Sprite banner = null)
    {
      return (TrophyRecordTab) null;
    }

    [Token(Token = "0x600C7A0")]
    [Address(RVA = "0x905A80", Offset = "0x904880", VA = "0x10905A80")]
    private void OnItemSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600C7A1")]
    [Address(RVA = "0x904E30", Offset = "0x903C30", VA = "0x10904E30")]
    private void ActivateAllTabCursor(int activeIndex)
    {
    }

    [Token(Token = "0x600C7A2")]
    [Address(RVA = "0x905B30", Offset = "0x904930", VA = "0x10905B30")]
    public void RefreshTrophyCollectiveReceiptButton()
    {
    }

    [Token(Token = "0x600C7A3")]
    [Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x10905FC0")]
    public void SelectTrophyCategoryData(TrophyCategoryData data)
    {
    }

    [Token(Token = "0x600C7A4")]
    [Address(RVA = "0x906110", Offset = "0x904F10", VA = "0x10906110")]
    public IEnumerator SetContentRectPosition(TrophyCategoryData data) => (IEnumerator) null;

    [Token(Token = "0x600C7A5")]
    [Address(RVA = "0x906260", Offset = "0x905060", VA = "0x10906260")]
    public TrophyTabList()
    {
    }
  }
}
