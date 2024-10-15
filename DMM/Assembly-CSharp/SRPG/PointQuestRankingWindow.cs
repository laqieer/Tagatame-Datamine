// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRankingWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002833")]
  [FlowNode.Pin(11, "初期化完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(601, "ギルド情報を開く", FlowNode.PinTypes.Output, 601)]
  [FlowNode.Pin(501, "個人情報を開く", FlowNode.PinTypes.Output, 501)]
  [FlowNode.Pin(499, "ランキングの取得の失敗", FlowNode.PinTypes.Input, 499)]
  [FlowNode.Pin(421, "ギルド内個人ランキングの取得", FlowNode.PinTypes.Input, 421)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(411, "ギルドランキングの取得", FlowNode.PinTypes.Input, 411)]
  [FlowNode.Pin(321, "ギルド内個人ランキングAPI", FlowNode.PinTypes.Output, 321)]
  [FlowNode.Pin(311, "ギルドランキングAPI", FlowNode.PinTypes.Output, 311)]
  [FlowNode.Pin(301, "個人ランキングAPI", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(101, "タブ切替", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "更新完了", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(401, "個人ランキングの取得", FlowNode.PinTypes.Input, 401)]
  [FlowNode.Pin(201, "タブ切替更新", FlowNode.PinTypes.Input, 201)]
  public class PointQuestRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BF93")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400BF94")]
    private const int PIN_OUTPUT_INIT = 11;
    [Token(Token = "0x400BF95")]
    private const int PIN_OUTPUT_UPDATE = 12;
    [Token(Token = "0x400BF96")]
    private const int PIN_OUTPUT_CHANGE_TAB = 101;
    [Token(Token = "0x400BF97")]
    private const int PIN_INPUT_CHANGE_TAB = 201;
    [Token(Token = "0x400BF98")]
    private const int PIN_OUTPUT_PERSON_RANKING_API = 301;
    [Token(Token = "0x400BF99")]
    private const int PIN_OUTPUT_PORT_RANKING_API = 311;
    [Token(Token = "0x400BF9A")]
    private const int PIN_OUTPUT_PORTPERSON_RANKING_API = 321;
    [Token(Token = "0x400BF9B")]
    private const int PIN_INPUT_GET_PERSON_RANKING = 401;
    [Token(Token = "0x400BF9C")]
    private const int PIN_INPUT_GET_PORT_RANKING = 411;
    [Token(Token = "0x400BF9D")]
    private const int PIN_INPUT_GET_PORTPERSON_RANKING = 421;
    [Token(Token = "0x400BF9E")]
    private const int PIN_INPUT_API_ERROR = 499;
    [Token(Token = "0x400BF9F")]
    private const int PIN_OUTPUT_OPEN_PERSON_INFORM = 501;
    [Token(Token = "0x400BFA0")]
    private const int PIN_OUTPUT_OPEN_PORT_INFORM = 601;
    [Token(Token = "0x400BFA1")]
    public const string KEY_OPEN_MODE = "KEY_OPEN_MODE";
    [Token(Token = "0x400BFA2")]
    public const string KEY_API_QUEST_CHAPTER = "KEY_API_QUEST_CHAPTER";
    [Token(Token = "0x400BFA3")]
    public const string KEY_API_RANKING_PAGE = "KEY_API_RANKING_PAGE";
    [Token(Token = "0x400BFA4")]
    public const string KEY_API_PERSON_RANKING_RESPONSE = "KEY_API_PERSON_RANKING_RESPONSE";
    [Token(Token = "0x400BFA5")]
    public const string KEY_API_PORT_RANKING_RESPONSE = "KEY_API_PORT_RANKING_RESPONSE";
    [Token(Token = "0x400BFA6")]
    public const string KEY_API_PORTPERSON_RANKING_RESPONSE = "KEY_API_PORTPERSON_RANKING_RESPONSE";
    [Token(Token = "0x400BFA7")]
    [FieldOffset(Offset = "0xC")]
    private Vector2 InitAnchoredPosition;
    [Token(Token = "0x400BFA8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400BFA9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400BFAA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mTabParent;
    [Token(Token = "0x400BFAB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PointQuestRankingTab mTabContentNode;
    [Token(Token = "0x400BFAC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ContentController mPersonRankingContentController;
    [Token(Token = "0x400BFAD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ContentController mPortRankingContentController;
    [Token(Token = "0x400BFAE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private PointQuestRankingPulldownTab mPulldown;
    [Token(Token = "0x400BFAF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string mReplaceToken;
    [Token(Token = "0x400BFB0")]
    [FieldOffset(Offset = "0x34")]
    private PointQuestRankingWindowModel mModel;
    [Token(Token = "0x400BFB1")]
    [FieldOffset(Offset = "0x38")]
    private List<PointQuestRankingTab> mTabList;
    [Token(Token = "0x400BFB2")]
    [FieldOffset(Offset = "0x3C")]
    private ContentController mCurrentContentController;
    [Token(Token = "0x400BFB3")]
    [FieldOffset(Offset = "0x40")]
    private bool mOpenFlag;
    [Token(Token = "0x400BFB4")]
    [FieldOffset(Offset = "0x41")]
    private bool mIsConnectAPI;

    [Token(Token = "0x170018E0")]
    public PointQuestRankingWindowModel Model
    {
      [Token(Token = "0x600B568"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (PointQuestRankingWindowModel) null;
      }
    }

    [Token(Token = "0x600B569")]
    [Address(RVA = "0x7BCCB0", Offset = "0x7BBAB0", VA = "0x107BCCB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B56A")]
    [Address(RVA = "0x7BE400", Offset = "0x7BD200", VA = "0x107BE400")]
    private void Setup()
    {
    }

    [Token(Token = "0x600B56B")]
    [Address(RVA = "0x7BD180", Offset = "0x7BBF80", VA = "0x107BD180")]
    public void Initialize(PointQuestRankingWindow.OpenPageType type)
    {
    }

    [Token(Token = "0x600B56C")]
    [Address(RVA = "0x7BD140", Offset = "0x7BBF40", VA = "0x107BD140")]
    public void InitializeTab()
    {
    }

    [Token(Token = "0x600B56D")]
    [Address(RVA = "0x7BE5B0", Offset = "0x7BD3B0", VA = "0x107BE5B0")]
    public void Update()
    {
    }

    [Token(Token = "0x600B56E")]
    [Address(RVA = "0x7BDDF0", Offset = "0x7BCBF0", VA = "0x107BDDF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B56F")]
    [Address(RVA = "0x7BD9E0", Offset = "0x7BC7E0", VA = "0x107BD9E0")]
    public void RefreshTab()
    {
    }

    [Token(Token = "0x600B570")]
    [Address(RVA = "0x7BD820", Offset = "0x7BC620", VA = "0x107BD820")]
    public void RefreshPullDownTab()
    {
    }

    [Token(Token = "0x600B571")]
    [Address(RVA = "0x7BD070", Offset = "0x7BBE70", VA = "0x107BD070")]
    private bool CheckScroll() => new bool();

    [Token(Token = "0x600B572")]
    [Address(RVA = "0x7BD6C0", Offset = "0x7BC4C0", VA = "0x107BD6C0")]
    public void OutputAPI()
    {
    }

    [Token(Token = "0x600B573")]
    [Address(RVA = "0x7BE0E0", Offset = "0x7BCEE0", VA = "0x107BE0E0")]
    public void SetPersonRankingData()
    {
    }

    [Token(Token = "0x600B574")]
    [Address(RVA = "0x7BE2C0", Offset = "0x7BD0C0", VA = "0x107BE2C0")]
    public void SetPortRankingData()
    {
    }

    [Token(Token = "0x600B575")]
    [Address(RVA = "0x7BE210", Offset = "0x7BD010", VA = "0x107BE210")]
    public void SetPortPersonRankingData()
    {
    }

    [Token(Token = "0x600B576")]
    [Address(RVA = "0x7BD3C0", Offset = "0x7BC1C0", VA = "0x107BD3C0")]
    public void OnClickTab(Toggle toggle)
    {
    }

    [Token(Token = "0x600B577")]
    [Address(RVA = "0x7BD250", Offset = "0x7BC050", VA = "0x107BD250")]
    public void OnClickPulldown(int select)
    {
    }

    [Token(Token = "0x600B578")]
    [Address(RVA = "0x7BDED0", Offset = "0x7BCCD0", VA = "0x107BDED0")]
    public void SetInitTab(PointQuestRankingWindow.RankingAPIType api_type)
    {
    }

    [Token(Token = "0x600B579")]
    [Address(RVA = "0x7BD560", Offset = "0x7BC360", VA = "0x107BD560")]
    public void OnPersonContentNode(PointQuestPersonRankingContentNode contentNode)
    {
    }

    [Token(Token = "0x600B57A")]
    [Address(RVA = "0x7BD5C0", Offset = "0x7BC3C0", VA = "0x107BD5C0")]
    public void OnPortContentNode(PointQuestPortRankingContentNode contentNode)
    {
    }

    [Token(Token = "0x600B57B")]
    [Address(RVA = "0x7BE690", Offset = "0x7BD490", VA = "0x107BE690")]
    public PointQuestRankingWindow()
    {
    }

    [Token(Token = "0x2002834")]
    public enum RankingAPIType
    {
      [Token(Token = "0x400BFB6")] Person,
      [Token(Token = "0x400BFB7")] Port,
      [Token(Token = "0x400BFB8")] PortPerson,
    }

    [Token(Token = "0x2002835")]
    public enum OpenPageType
    {
      [Token(Token = "0x400BFBA")] PointQuest,
      [Token(Token = "0x400BFBB")] Port,
    }
  }
}
