// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingWindow
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
  [Token(Token = "0x2002589")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidRankingWindow")]
  [FlowNode.Pin(204, "個人BOSS追加読み込み", FlowNode.PinTypes.Output, 204)]
  [FlowNode.Pin(203, "個人トータルランキング追加読み込み", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(200, "個人トータルランキング読み込み", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "個人BOSS読み込み", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(10, "ギルドランキング選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(202, "ギルドランキング追加読み込み", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(12, "個人BOSSランキング選択", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "個人トータルランキング選択", FlowNode.PinTypes.Input, 11)]
  public class GuildRaidRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400ADFB")]
    private const int PIN_INPUT_SELECT_GUILD = 10;
    [Token(Token = "0x400ADFC")]
    private const int PIN_INPUT_SELECT_MEMBER = 11;
    [Token(Token = "0x400ADFD")]
    private const int PIN_INPUT_SELECT_BOSS = 12;
    [Token(Token = "0x400ADFE")]
    private const int PIN_OUTPUT_REFRESHTOTAL = 200;
    [Token(Token = "0x400ADFF")]
    private const int PIN_OUTPUT_REFRESHBOSS = 201;
    [Token(Token = "0x400AE00")]
    private const int PIN_OUTPUT_REFRESHADDGUILD = 202;
    [Token(Token = "0x400AE01")]
    private const int PIN_OUTPUT_REFRESHADDTOTAL = 203;
    [Token(Token = "0x400AE02")]
    private const int PIN_OUTPUT_REFRESHADDBOSS = 204;
    [Token(Token = "0x400AE03")]
    [FieldOffset(Offset = "0xC")]
    private GuildRaidRankingWindow.SelectType mSelectType;
    [Token(Token = "0x400AE04")]
    [FieldOffset(Offset = "0x10")]
    private GuildRaidRankingWindow.BossType mBossType;
    [Token(Token = "0x400AE05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mGuildObject;
    [Token(Token = "0x400AE06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mGuildRankingTemplate;
    [Token(Token = "0x400AE07")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mMemberObject;
    [Token(Token = "0x400AE08")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mMemberTotalViewObject;
    [Token(Token = "0x400AE09")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mMemberBossViewObject;
    [Token(Token = "0x400AE0A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mMemberRankingTemplate;
    [Token(Token = "0x400AE0B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mMemberHistoryTemplate;
    [Token(Token = "0x400AE0C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mMemberRankingBossTemplate;
    [Token(Token = "0x400AE0D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mBossIcon;
    [Token(Token = "0x400AE0E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mBossName;
    [Token(Token = "0x400AE0F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mBossStage;
    [Token(Token = "0x400AE10")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mGuildButton;
    [Token(Token = "0x400AE11")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mMemberButton;
    [Token(Token = "0x400AE12")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button mPagePrev;
    [Token(Token = "0x400AE13")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button mPageNext;
    [Token(Token = "0x400AE14")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mTabObject;
    [Token(Token = "0x400AE15")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mTabTotal;
    [Token(Token = "0x400AE16")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mTabBoss01;
    [Token(Token = "0x400AE17")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mTabBoss02;
    [Token(Token = "0x400AE18")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mTabBoss03;
    [Token(Token = "0x400AE19")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mTabBoss04;
    [Token(Token = "0x400AE1A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mTabBoss05;
    [Token(Token = "0x400AE1B")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private float mSelScale;
    [Token(Token = "0x400AE1C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private float mNonSelScale;
    [Token(Token = "0x400AE1D")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400AE1E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private SRPG_ScrollRect ScrollGuild;
    [Token(Token = "0x400AE1F")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private RectTransform ScrollContentGuild;
    [Token(Token = "0x400AE20")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private SRPG_ScrollRect ScrollTotal;
    [Token(Token = "0x400AE21")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private RectTransform ScrollContentTotal;
    [Token(Token = "0x400AE22")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private SRPG_ScrollRect ScrollBoss;
    [Token(Token = "0x400AE23")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private RectTransform ScrollContentBoss;
    [Token(Token = "0x400AE24")]
    [FieldOffset(Offset = "0x90")]
    private List<GameObject> mRankingList;
    [Token(Token = "0x400AE25")]
    [FieldOffset(Offset = "0x94")]
    private GameObject mCurrentTab;
    [Token(Token = "0x400AE26")]
    [FieldOffset(Offset = "0x98")]
    private List<GuildRaidRankingGuildParam> mGuildRaidRankingGuildParamList;
    [Token(Token = "0x400AE27")]
    [FieldOffset(Offset = "0x9C")]
    private Vector2 mAnchorPosition;
    [Token(Token = "0x400AE28")]
    [FieldOffset(Offset = "0xA4")]
    private SRPG_ScrollRect Scroll;
    [Token(Token = "0x400AE29")]
    [FieldOffset(Offset = "0xA8")]
    private RectTransform ScrollContent;
    [Token(Token = "0x400AE2A")]
    [FieldOffset(Offset = "0xAC")]
    private bool IsLoading;
    [Token(Token = "0x400AE2B")]
    [FieldOffset(Offset = "0xB0")]
    private int currentPage;
    [Token(Token = "0x400AE2C")]
    [FieldOffset(Offset = "0xB4")]
    private int currentPageMax;

    [Token(Token = "0x600A6C6")]
    [Address(RVA = "0x688140", Offset = "0x686F40", VA = "0x10688140")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A6C7")]
    [Address(RVA = "0x68A430", Offset = "0x689230", VA = "0x1068A430")]
    private void Update()
    {
    }

    [Token(Token = "0x600A6C8")]
    [Address(RVA = "0x689DA0", Offset = "0x688BA0", VA = "0x10689DA0")]
    private void SetupReloadScroll()
    {
    }

    [Token(Token = "0x600A6C9")]
    [Address(RVA = "0x687FC0", Offset = "0x686DC0", VA = "0x10687FC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A6CA")]
    [Address(RVA = "0x6886F0", Offset = "0x6874F0", VA = "0x106886F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A6CB")]
    [Address(RVA = "0x689B10", Offset = "0x688910", VA = "0x10689B10")]
    private void SetChangeButton(GameObject select, GameObject noselect)
    {
    }

    [Token(Token = "0x600A6CC")]
    [Address(RVA = "0x6882C0", Offset = "0x6870C0", VA = "0x106882C0")]
    public void OnClickTab(GameObject go)
    {
    }

    [Token(Token = "0x600A6CD")]
    [Address(RVA = "0x688600", Offset = "0x687400", VA = "0x10688600")]
    public void OnPrev()
    {
    }

    [Token(Token = "0x600A6CE")]
    [Address(RVA = "0x688510", Offset = "0x687310", VA = "0x10688510")]
    public void OnNext()
    {
    }

    [Token(Token = "0x600A6CF")]
    [Address(RVA = "0x68A160", Offset = "0x688F60", VA = "0x1068A160")]
    public void ToggleControl()
    {
    }

    [Token(Token = "0x600A6D0")]
    [Address(RVA = "0x68A620", Offset = "0x689420", VA = "0x1068A620")]
    public GuildRaidRankingWindow()
    {
    }

    [Token(Token = "0x200258A")]
    public enum SelectType
    {
      [Token(Token = "0x400AE2E")] Guild,
      [Token(Token = "0x400AE2F")] Member,
      [Token(Token = "0x400AE30")] Boss,
    }

    [Token(Token = "0x200258B")]
    public enum BossType
    {
      [Token(Token = "0x400AE32")] None,
      [Token(Token = "0x400AE33")] Boss01,
      [Token(Token = "0x400AE34")] Boss02,
      [Token(Token = "0x400AE35")] Boss03,
      [Token(Token = "0x400AE36")] Boss04,
      [Token(Token = "0x400AE37")] Boss05,
    }
  }
}
