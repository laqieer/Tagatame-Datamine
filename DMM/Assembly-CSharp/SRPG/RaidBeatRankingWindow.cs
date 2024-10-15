// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBeatRankingWindow
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
  [Token(Token = "0x20028D4")]
  [FlowNode.Pin(101, "ギルドランキング選択", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(201, "Reqランキング", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(111, "タブ：救援ランキング選択", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(110, "タブ：討伐数ランキング選択", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(1, "ランキング初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(202, "Req救援ランキング", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(301, "入力制限", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "入力制限解放", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(401, "閉じる", FlowNode.PinTypes.Input, 401)]
  [AddComponentMenu("UI/Raid/RaidBeatRankingWindow")]
  [FlowNode.Pin(10, "初期化完了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(100, "個人ランキング選択", FlowNode.PinTypes.Input, 100)]
  public class RaidBeatRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C3E1")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C3E2")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x400C3E3")]
    private const int PIN_OUTPUT_LOADCOMPLTE = 10;
    [Token(Token = "0x400C3E4")]
    private const int PIN_INPUT_SELECT_PLAYER = 100;
    [Token(Token = "0x400C3E5")]
    private const int PIN_INPUT_SELECT_GUILD = 101;
    [Token(Token = "0x400C3E6")]
    private const int PIN_INPUT_SELECT_BEAT = 110;
    [Token(Token = "0x400C3E7")]
    private const int PIN_INPUT_SELECT_RESCUE = 111;
    [Token(Token = "0x400C3E8")]
    private const int PIN_OUTPUT_REQ_BEAT_RANKING = 201;
    [Token(Token = "0x400C3E9")]
    private const int PIN_OUTPUT_REQ_RESCUE_RANKING = 202;
    [Token(Token = "0x400C3EA")]
    private const int PIN_OUTPUT_LIMITATION = 301;
    [Token(Token = "0x400C3EB")]
    private const int PIN_OUTPUT_RELEASE = 302;
    [Token(Token = "0x400C3EC")]
    private const int PIN_INPUT_CLOSE_POPUP = 401;
    [Token(Token = "0x400C3ED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mPlayerGuildName;
    [Token(Token = "0x400C3EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mPlayerGuildLevel;
    [Token(Token = "0x400C3EF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mPlayerGuildEmblem;
    [Token(Token = "0x400C3F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mPlayerGuildMasterName;
    [Token(Token = "0x400C3F1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mPlayerGuildMember;
    [Token(Token = "0x400C3F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mPlayerGuildMaxMember;
    [Token(Token = "0x400C3F3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mPlayerGuildBeat;
    [Token(Token = "0x400C3F4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mPlayerGuildMaxRescue;
    [Token(Token = "0x400C3F5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mBeatSelf;
    [Token(Token = "0x400C3F6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mRescueSelf;
    [Token(Token = "0x400C3F7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mBeatRanking;
    [Token(Token = "0x400C3F8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mBeatGuildItem;
    [Token(Token = "0x400C3F9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Transform mBeatGuildParent;
    [Token(Token = "0x400C3FA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mBeatGuildSelf;
    [Token(Token = "0x400C3FB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mBeatGuildRanking;
    [Token(Token = "0x400C3FC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mBeatGuildNone;
    [Token(Token = "0x400C3FD")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button mSelectPlayerButton;
    [Token(Token = "0x400C3FE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button mSelectGuildButton;
    [Token(Token = "0x400C3FF")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private float mSelScale;
    [Token(Token = "0x400C400")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private float mNonSelScale;
    [Token(Token = "0x400C401")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private ContentController mBeatContentController;
    [Token(Token = "0x400C402")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ContentController mRescueContentController;
    [Token(Token = "0x400C403")]
    [FieldOffset(Offset = "0x0")]
    private static RaidBeatRankingWindow mInstance;
    [Token(Token = "0x400C404")]
    [FieldOffset(Offset = "0x64")]
    private RaidRankingList mRankingBeat;
    [Token(Token = "0x400C405")]
    [FieldOffset(Offset = "0x68")]
    private RaidRankingList mRankingRescue;
    [Token(Token = "0x400C406")]
    [FieldOffset(Offset = "0x6C")]
    private RaidRankingGuildList mGuildRankingBeat;
    [Token(Token = "0x400C407")]
    [FieldOffset(Offset = "0x70")]
    private RaidRankingGuildList mGuildRankingRescue;
    [Token(Token = "0x400C408")]
    [FieldOffset(Offset = "0x74")]
    private List<GameObject> mBeatGuildList;
    [Token(Token = "0x400C409")]
    [FieldOffset(Offset = "0x78")]
    private GuildEmblemParam[] mEmblems;
    [Token(Token = "0x400C40A")]
    [FieldOffset(Offset = "0x7C")]
    private List<RaidRankingContentParam> mRaidRankingContentParam;
    [Token(Token = "0x400C40B")]
    [FieldOffset(Offset = "0x80")]
    private Vector2 mAnchorPosition;
    [Token(Token = "0x400C40C")]
    [FieldOffset(Offset = "0x88")]
    private RaidBeatRankingWindow.ETabType mETabType;
    [Token(Token = "0x400C40D")]
    [FieldOffset(Offset = "0x8C")]
    private RaidBeatRankingWindow.ETabType mETabNextType;
    [Token(Token = "0x400C40E")]
    [FieldOffset(Offset = "0x90")]
    private bool mIsUpdateWait;
    [Token(Token = "0x400C40F")]
    [FieldOffset(Offset = "0x91")]
    private bool mIsScrollPosRest;
    [Token(Token = "0x400C410")]
    [FieldOffset(Offset = "0x94")]
    private Dictionary<RaidBeatRankingWindow.ETabType, int> mTotlaPage;
    [Token(Token = "0x400C411")]
    [FieldOffset(Offset = "0x98")]
    private Dictionary<RaidBeatRankingWindow.ETabType, int> mNowPage;
    [Token(Token = "0x400C412")]
    [FieldOffset(Offset = "0x9C")]
    private Dictionary<RaidBeatRankingWindow.ETabType, List<RaidRankingData>> mRankingDatas;

    [Token(Token = "0x17001936")]
    public static RaidBeatRankingWindow Instance
    {
      [Token(Token = "0x600B88B"), Address(RVA = "0x7F9200", Offset = "0x7F8000", VA = "0x107F9200")] get
      {
        return (RaidBeatRankingWindow) null;
      }
    }

    [Token(Token = "0x17001937")]
    public int RankingBeatPageNum
    {
      [Token(Token = "0x600B88C"), Address(RVA = "0x7F9230", Offset = "0x7F8030", VA = "0x107F9230")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001938")]
    public int RankingRescuePageNum
    {
      [Token(Token = "0x600B88D"), Address(RVA = "0x7F9280", Offset = "0x7F8080", VA = "0x107F9280")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B88E")]
    [Address(RVA = "0x7F7300", Offset = "0x7F6100", VA = "0x107F7300")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B88F")]
    [Address(RVA = "0x7F8720", Offset = "0x7F7520", VA = "0x107F8720")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B890")]
    [Address(RVA = "0x7F8E30", Offset = "0x7F7C30", VA = "0x107F8E30")]
    private void Update()
    {
    }

    [Token(Token = "0x600B891")]
    [Address(RVA = "0x7F7210", Offset = "0x7F6010", VA = "0x107F7210", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B892")]
    [Address(RVA = "0x7F8A20", Offset = "0x7F7820", VA = "0x107F8A20")]
    public void SetupBeat(ReqRaidRankingBeat.Response json)
    {
    }

    [Token(Token = "0x600B893")]
    [Address(RVA = "0x7F8BC0", Offset = "0x7F79C0", VA = "0x107F8BC0")]
    public void SetupRescue(ReqRaidRankingBeat.Response json)
    {
    }

    [Token(Token = "0x600B894")]
    [Address(RVA = "0x7F8D60", Offset = "0x7F7B60", VA = "0x107F8D60")]
    public void Setup(ReqRaidRankingGuild.Response json)
    {
    }

    [Token(Token = "0x600B895")]
    [Address(RVA = "0x7F8800", Offset = "0x7F7600", VA = "0x107F8800")]
    private void SelectTab(RaidBeatRankingWindow.ETabType type)
    {
    }

    [Token(Token = "0x600B896")]
    [Address(RVA = "0x7F86E0", Offset = "0x7F74E0", VA = "0x107F86E0")]
    private void Init()
    {
    }

    [Token(Token = "0x600B897")]
    [Address(RVA = "0x7F8760", Offset = "0x7F7560", VA = "0x107F8760")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B898")]
    [Address(RVA = "0x7F8090", Offset = "0x7F6E90", VA = "0x107F8090")]
    private void Init_List(
      ContentController controller,
      RaidRankingList rankingList,
      GameObject self)
    {
    }

    [Token(Token = "0x600B899")]
    [Address(RVA = "0x7F7540", Offset = "0x7F6340", VA = "0x107F7540")]
    private void InitGuild()
    {
    }

    [Token(Token = "0x600B89A")]
    [Address(RVA = "0x7F7BC0", Offset = "0x7F69C0", VA = "0x107F7BC0")]
    private void Init_GuildList(
      RaidRankingGuildList rankingList,
      List<GameObject> currentList,
      GameObject item,
      Transform parent,
      GameObject self)
    {
    }

    [Token(Token = "0x600B89B")]
    [Address(RVA = "0x7F7570", Offset = "0x7F6370", VA = "0x107F7570")]
    private void InitPlayerInfo()
    {
    }

    [Token(Token = "0x600B89C")]
    [Address(RVA = "0x7F73A0", Offset = "0x7F61A0", VA = "0x107F73A0")]
    private void GetEmblem(GameObject obj, string name)
    {
    }

    [Token(Token = "0x600B89D")]
    [Address(RVA = "0x7F88D0", Offset = "0x7F76D0", VA = "0x107F88D0")]
    private void SetScaleButton(bool player)
    {
    }

    [Token(Token = "0x600B89E")]
    [Address(RVA = "0x7F8FB0", Offset = "0x7F7DB0", VA = "0x107F8FB0")]
    public RaidBeatRankingWindow()
    {
    }

    [Token(Token = "0x20028D5")]
    private enum ETabType
    {
      [Token(Token = "0x400C414")] BEAT,
      [Token(Token = "0x400C415")] RESCUE,
    }
  }
}
