// Decompiled with JetBrains decompiler
// Type: SRPG.BeginnerTop
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
  [Token(Token = "0x200208A")]
  [AddComponentMenu("UI/BeginnerTop")]
  [FlowNode.Pin(10001, "Go To Quest", FlowNode.PinTypes.Output, 10001)]
  [FlowNode.Pin(10000, "Tips Detail", FlowNode.PinTypes.Output, 10000)]
  [FlowNode.Pin(100, "Reset Status", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(12, "Select Banner", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "Select Practice", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(5, "Open Tab Banner", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Select Tips", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(3, "Open Tab Basic", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "Open Tab Practice", FlowNode.PinTypes.Input, 4)]
  public class BeginnerTop : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008C32")]
    private const int START = 1;
    [Token(Token = "0x4008C33")]
    private const int REFRESH = 2;
    [Token(Token = "0x4008C34")]
    private const int TAB_BASIC = 3;
    [Token(Token = "0x4008C35")]
    private const int TAB_PRACTICE = 4;
    [Token(Token = "0x4008C36")]
    private const int TAB_BANNER = 5;
    [Token(Token = "0x4008C37")]
    private const int ON_SELECT_TIPS = 10;
    [Token(Token = "0x4008C38")]
    private const int ON_SELECT_PRACTICE = 11;
    [Token(Token = "0x4008C39")]
    private const int ON_SELECT_BANNER = 12;
    [Token(Token = "0x4008C3A")]
    private const int RESET_STATUS = 100;
    [Token(Token = "0x4008C3B")]
    private const int OUTPUT_SHOW_TIPS_DETAIL = 10000;
    [Token(Token = "0x4008C3C")]
    private const int OUTPUT_GOTO_QUEST = 10001;
    [Token(Token = "0x4008C3D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle ToggleTips;
    [Token(Token = "0x4008C3E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle TogglePractice;
    [Token(Token = "0x4008C3F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle ToggleBanners;
    [Token(Token = "0x4008C40")]
    [FieldOffset(Offset = "0x18")]
    [Space(8f)]
    [SerializeField]
    private GameObject BadgeTips;
    [Token(Token = "0x4008C41")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject BadgePractice;
    [Token(Token = "0x4008C42")]
    [FieldOffset(Offset = "0x20")]
    [Space(8f)]
    [SerializeField]
    private GameObject BasicPanel;
    [Token(Token = "0x4008C43")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject PracticePanel;
    [Token(Token = "0x4008C44")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject BannerPanel;
    [Token(Token = "0x4008C45")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Space(8f)]
    private Transform BasicHolder;
    [Token(Token = "0x4008C46")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform PracticeHolder;
    [Token(Token = "0x4008C47")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject BasicTemplate;
    [Token(Token = "0x4008C48")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject PracticeTemplate;
    [Token(Token = "0x4008C49")]
    [FieldOffset(Offset = "0x3C")]
    private BeginnerTop.TabType mCurrentTabType;
    [Token(Token = "0x4008C4A")]
    [FieldOffset(Offset = "0x40")]
    private List<GameObject> mTipsItems;
    [Token(Token = "0x4008C4B")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> mQuestItems;

    [Token(Token = "0x600876E")]
    [Address(RVA = "0x48C9F0", Offset = "0x48B7F0", VA = "0x1048C9F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600876F")]
    [Address(RVA = "0x48CFA0", Offset = "0x48BDA0", VA = "0x1048CFA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008770")]
    [Address(RVA = "0x48DDE0", Offset = "0x48CBE0", VA = "0x1048DDE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008771")]
    [Address(RVA = "0x48E240", Offset = "0x48D040", VA = "0x1048E240")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008772")]
    [Address(RVA = "0x48DF20", Offset = "0x48CD20", VA = "0x1048DF20")]
    private void OnSelectBasic()
    {
    }

    [Token(Token = "0x6008773")]
    [Address(RVA = "0x48D210", Offset = "0x48C010", VA = "0x1048D210")]
    private void CreateAllTabs()
    {
    }

    [Token(Token = "0x6008774")]
    [Address(RVA = "0x48D0D0", Offset = "0x48BED0", VA = "0x1048D0D0")]
    private void ChangeTab(BeginnerTop.TabType tabType, bool forceRefresh = false)
    {
    }

    [Token(Token = "0x6008775")]
    [Address(RVA = "0x48DB30", Offset = "0x48C930", VA = "0x1048DB30")]
    private void DeleteAllObj()
    {
    }

    [Token(Token = "0x6008776")]
    [Address(RVA = "0x48D2F0", Offset = "0x48C0F0", VA = "0x1048D2F0")]
    private bool CreateBasicTabContent() => new bool();

    [Token(Token = "0x6008777")]
    [Address(RVA = "0x48D7B0", Offset = "0x48C5B0", VA = "0x1048D7B0")]
    private bool CreatePracticeTabContent() => new bool();

    [Token(Token = "0x6008778")]
    [Address(RVA = "0x48E1A0", Offset = "0x48CFA0", VA = "0x1048E1A0")]
    private void RefreshBasicTabPage()
    {
    }

    [Token(Token = "0x6008779")]
    [Address(RVA = "0x48E1F0", Offset = "0x48CFF0", VA = "0x1048E1F0")]
    private void RefreshPracticeTabPage()
    {
    }

    [Token(Token = "0x600877A")]
    [Address(RVA = "0x48E150", Offset = "0x48CF50", VA = "0x1048E150")]
    private void RefreshBannerTabPage()
    {
    }

    [Token(Token = "0x600877B")]
    [Address(RVA = "0x48E020", Offset = "0x48CE20", VA = "0x1048E020")]
    private void OnSelectPractice()
    {
    }

    [Token(Token = "0x600877C")]
    [Address(RVA = "0x48DE90", Offset = "0x48CC90", VA = "0x1048DE90")]
    private void OnSelectBanner()
    {
    }

    [Token(Token = "0x600877D")]
    [Address(RVA = "0x48E4F0", Offset = "0x48D2F0", VA = "0x1048E4F0")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600877E")]
    [Address(RVA = "0x48E810", Offset = "0x48D610", VA = "0x1048E810")]
    public BeginnerTop()
    {
    }

    [Token(Token = "0x200208B")]
    private enum TabType
    {
      [Token(Token = "0x4008C4D")] Basic,
      [Token(Token = "0x4008C4E")] Practice,
      [Token(Token = "0x4008C4F")] Banners,
    }
  }
}
