// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestBonusListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027FD")]
  [FlowNode.Pin(101, "ページタブが押された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "ボーナス表示更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class PointQuestBonusListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BE58")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400BE59")]
    private const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x400BE5A")]
    private const int PIN_OUTPUT_PAGE_TAB_BUTTON = 101;
    [Token(Token = "0x400BE5B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private PointQuestBonusContent mBonusUnitTemplate;
    [Token(Token = "0x400BE5C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ToggleGroup mPageToggleGroup;
    [Token(Token = "0x400BE5D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mBonusPageUnitTab;
    [Token(Token = "0x400BE5E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle mBonusPageConceptCardTab;
    [Token(Token = "0x400BE5F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private PointQuestBonusListWindow.BonusPage mStartPage;
    [Token(Token = "0x400BE60")]
    [FieldOffset(Offset = "0x20")]
    private PointQuestBonusListWindow.BonusPage CurrentBonusPage;
    [Token(Token = "0x400BE61")]
    [FieldOffset(Offset = "0x24")]
    private List<PointQuestBonusContent> BonusContentUnitList;
    [Token(Token = "0x400BE62")]
    [FieldOffset(Offset = "0x28")]
    private List<PointQuestBonusContent> BonusContentCardList;

    [Token(Token = "0x600B485")]
    [Address(RVA = "0x7B0C20", Offset = "0x7AFA20", VA = "0x107B0C20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B486")]
    [Address(RVA = "0x7B15C0", Offset = "0x7B03C0", VA = "0x107B15C0")]
    private void OnPressTab(bool check)
    {
    }

    [Token(Token = "0x600B487")]
    [Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x107B1940")]
    private void SetPage(PointQuestBonusListWindow.BonusPage nextBonusPage)
    {
    }

    [Token(Token = "0x600B488")]
    [Address(RVA = "0x7B1120", Offset = "0x7AFF20", VA = "0x107B1120")]
    private void GetPage()
    {
    }

    [Token(Token = "0x600B489")]
    [Address(RVA = "0x7B1250", Offset = "0x7B0050", VA = "0x107B1250")]
    private void Init()
    {
    }

    [Token(Token = "0x600B48A")]
    [Address(RVA = "0x7B1700", Offset = "0x7B0500", VA = "0x107B1700")]
    private void RefreshPage()
    {
    }

    [Token(Token = "0x600B48B")]
    [Address(RVA = "0x7B0C50", Offset = "0x7AFA50", VA = "0x107B0C50")]
    private void CreateBonusPage()
    {
    }

    [Token(Token = "0x600B48C")]
    [Address(RVA = "0x7B14C0", Offset = "0x7B02C0", VA = "0x107B14C0")]
    private bool IsBonusPageTab(PointQuestBonusPartyType bonusPageType) => new bool();

    [Token(Token = "0x600B48D")]
    [Address(RVA = "0x7B1AF0", Offset = "0x7B08F0", VA = "0x107B1AF0")]
    public PointQuestBonusListWindow()
    {
    }

    [Token(Token = "0x20027FE")]
    private enum BonusPage
    {
      [Token(Token = "0x400BE64")] UNIT,
      [Token(Token = "0x400BE65")] CONCEPTCARD,
      [Token(Token = "0x400BE66")] NONE,
    }
  }
}
