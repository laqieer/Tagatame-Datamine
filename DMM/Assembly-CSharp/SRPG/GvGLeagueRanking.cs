// Decompiled with JetBrains decompiler
// Type: SRPG.GvGLeagueRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025DC")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "表示更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "リーグの情報を取得", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GvG/GvGLeagueRanking")]
  public class GvGLeagueRanking : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AFC0")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400AFC1")]
    private const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x400AFC2")]
    private const int PIN_OUTPUT_REQUEST_LEAGUE = 100;
    [Token(Token = "0x400AFC3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle m_AllLeagueTab;
    [Token(Token = "0x400AFC4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle m_MyLeagueTab;
    [Token(Token = "0x400AFC5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle m_SelectLeagueTab;
    [Token(Token = "0x400AFC6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GvGLeagueRanking.RankingUIRef m_AllLeagueObjects;
    [Token(Token = "0x400AFC7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GvGLeagueRanking.RankingUIRef m_MyLeagueObjects;
    [Token(Token = "0x400AFC8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GvGLeagueRanking.RankingUIRef m_SelectLeagueObjects;
    [Token(Token = "0x400AFC9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private FlowNode_ReqGvGLeague m_RequestNode;
    [Token(Token = "0x400AFCA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollablePulldown m_LeagueSelector;
    [Token(Token = "0x400AFCB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SerializeValueBehaviour m_SerializeValue;
    [Token(Token = "0x400AFCC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int REQUEST_GUILD_LIMIT;
    [Token(Token = "0x400AFCD")]
    [FieldOffset(Offset = "0x34")]
    private GvGLeagueRanking.GvGRankingTab m_ActiveTabType;
    [Token(Token = "0x400AFCE")]
    [FieldOffset(Offset = "0x38")]
    private string m_SelectedLeagueID;
    [Token(Token = "0x400AFCF")]
    [FieldOffset(Offset = "0x3C")]
    private int m_StartRank;
    [Token(Token = "0x400AFD0")]
    [FieldOffset(Offset = "0x40")]
    private bool m_IsWaitingServerResponse;
    [Token(Token = "0x400AFD1")]
    [FieldOffset(Offset = "0x41")]
    private bool m_IsNeedHigherRank;
    [Token(Token = "0x400AFD2")]
    [FieldOffset(Offset = "0x42")]
    private bool m_IsNeedLowerRank;
    [Token(Token = "0x400AFD3")]
    [FieldOffset(Offset = "0x44")]
    private int m_RecievedTopRank;
    [Token(Token = "0x400AFD4")]
    [FieldOffset(Offset = "0x48")]
    private int m_RecievedWorstRank;
    [Token(Token = "0x400AFD5")]
    [FieldOffset(Offset = "0x4C")]
    private int m_RecievedGuildDataCount;
    [Token(Token = "0x400AFD6")]
    [FieldOffset(Offset = "0x50")]
    private int m_CurrentLeagueGuildNum;
    [Token(Token = "0x400AFD7")]
    [FieldOffset(Offset = "0x54")]
    private int m_TopGuildID;
    [Token(Token = "0x400AFD8")]
    [FieldOffset(Offset = "0x58")]
    private bool m_IsRequestTop;
    [Token(Token = "0x400AFD9")]
    [FieldOffset(Offset = "0x59")]
    private bool m_IsFirstViewMyLeague;
    [Token(Token = "0x400AFDA")]
    [FieldOffset(Offset = "0x5C")]
    private Vector2 m_UpdateLowerRankPos;
    [Token(Token = "0x400AFDB")]
    [FieldOffset(Offset = "0x64")]
    private Vector2 m_UpdateHigherRankPos;
    [Token(Token = "0x400AFDC")]
    [FieldOffset(Offset = "0x6C")]
    private List<GvGLeagueRankingContent.ContentParm> mGvGLeagueRankingContentParam;

    [Token(Token = "0x170017AC")]
    private GvGLeagueRanking.RankingUIRef ActiveRankingObject
    {
      [Token(Token = "0x600A850"), Address(RVA = "0x6B8DA0", Offset = "0x6B7BA0", VA = "0x106B8DA0")] get
      {
        return (GvGLeagueRanking.RankingUIRef) null;
      }
    }

    [Token(Token = "0x170017AD")]
    private ContentController ActiveContentController
    {
      [Token(Token = "0x600A851"), Address(RVA = "0x6B8D40", Offset = "0x6B7B40", VA = "0x106B8D40")] get
      {
        return (ContentController) null;
      }
    }

    [Token(Token = "0x170017AE")]
    private ScrollRect ActiveScrollRect
    {
      [Token(Token = "0x600A852"), Address(RVA = "0x6B8DD0", Offset = "0x6B7BD0", VA = "0x106B8DD0")] get
      {
        return (ScrollRect) null;
      }
    }

    [Token(Token = "0x600A853")]
    [Address(RVA = "0x6B86E0", Offset = "0x6B74E0", VA = "0x106B86E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A854")]
    [Address(RVA = "0x6B7410", Offset = "0x6B6210", VA = "0x106B7410", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A855")]
    [Address(RVA = "0x6B7F20", Offset = "0x6B6D20", VA = "0x106B7F20")]
    private void Init()
    {
    }

    [Token(Token = "0x600A856")]
    [Address(RVA = "0x6B7F40", Offset = "0x6B6D40", VA = "0x106B7F40")]
    private void InitializeDefaultSelectLeagueID()
    {
    }

    [Token(Token = "0x600A857")]
    [Address(RVA = "0x6B8290", Offset = "0x6B7090", VA = "0x106B8290")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A858")]
    [Address(RVA = "0x6B8B30", Offset = "0x6B7930", VA = "0x106B8B30")]
    private void Update()
    {
    }

    [Token(Token = "0x600A859")]
    [Address(RVA = "0x6B7470", Offset = "0x6B6270", VA = "0x106B7470")]
    private void CreateRanking()
    {
    }

    [Token(Token = "0x600A85A")]
    [Address(RVA = "0x6B84C0", Offset = "0x6B72C0", VA = "0x106B84C0")]
    private void SetupLeagueSelector()
    {
    }

    [Token(Token = "0x600A85B")]
    [Address(RVA = "0x6B8370", Offset = "0x6B7170", VA = "0x106B8370")]
    private void SelectLeague(string leagueID)
    {
    }

    [Token(Token = "0x600A85C")]
    [Address(RVA = "0x6B8410", Offset = "0x6B7210", VA = "0x106B8410")]
    private void SelectTab(GvGLeagueRanking.GvGRankingTab tab)
    {
    }

    [Token(Token = "0x600A85D")]
    [Address(RVA = "0x6B82D0", Offset = "0x6B70D0", VA = "0x106B82D0")]
    private void RequestLeagueData(int startRank)
    {
    }

    [Token(Token = "0x600A85E")]
    [Address(RVA = "0x6B80E0", Offset = "0x6B6EE0", VA = "0x106B80E0")]
    private void OnListItemClick(GvGLeagueViewGuild leagueData)
    {
    }

    [Token(Token = "0x600A85F")]
    [Address(RVA = "0x6B8190", Offset = "0x6B6F90", VA = "0x106B8190")]
    private void OnSelectLeague(GvGLeagueParam param)
    {
    }

    [Token(Token = "0x600A860")]
    [Address(RVA = "0x6B8240", Offset = "0x6B7040", VA = "0x106B8240")]
    private void OnSelectTab(GvGLeagueRanking.GvGRankingTab tabType)
    {
    }

    [Token(Token = "0x600A861")]
    [Address(RVA = "0x6B8CB0", Offset = "0x6B7AB0", VA = "0x106B8CB0")]
    public GvGLeagueRanking()
    {
    }

    [Token(Token = "0x20025DD")]
    private enum GvGRankingTab
    {
      [Token(Token = "0x400AFDE")] AllLeague,
      [Token(Token = "0x400AFDF")] MyLeague,
      [Token(Token = "0x400AFE0")] SelectLeague,
    }

    [Token(Token = "0x20025DE")]
    [Serializable]
    private class RankingUIRef
    {
      [Token(Token = "0x400AFE1")]
      [FieldOffset(Offset = "0x8")]
      public GameObject m_RankingRoot;
      [Token(Token = "0x400AFE2")]
      [FieldOffset(Offset = "0xC")]
      public ScrollRect m_ScrollRect;
      [Token(Token = "0x400AFE3")]
      [FieldOffset(Offset = "0x10")]
      public ContentController m_ContentController;
      [Token(Token = "0x400AFE4")]
      [FieldOffset(Offset = "0x14")]
      private RectTransform m_ContentTransformCache;

      [Token(Token = "0x170017AF")]
      public RectTransform ContentTransform
      {
        [Token(Token = "0x600A866"), Address(RVA = "0x6C3DA0", Offset = "0x6C2BA0", VA = "0x106C3DA0")] get
        {
          return (RectTransform) null;
        }
      }

      [Token(Token = "0x600A867")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RankingUIRef()
      {
      }
    }
  }
}
