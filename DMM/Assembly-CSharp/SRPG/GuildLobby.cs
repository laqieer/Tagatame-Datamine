// Decompiled with JetBrains decompiler
// Type: SRPG.GuildLobby
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002561")]
  [FlowNode.Pin(140, "ギルド施設強化を開く", FlowNode.PinTypes.Output, 140)]
  [AddComponentMenu("UI/GuildLobby")]
  [FlowNode.Pin(330, "自動更新", FlowNode.PinTypes.Output, 330)]
  [FlowNode.Pin(301, "GVG不参加", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(300, "GVG参加", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(200, "ギルドレイド開始", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(150, "ギルドに加入していない", FlowNode.PinTypes.Output, 150)]
  [FlowNode.Pin(141, "ギルド施設強化の権限がない", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(120, "サブマスです", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(110, "ギルマスです", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(130, "メンバーです", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "ギルド施設強化を開く", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(11, "自動更新OFF？", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "自動更新ON？", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ポート鍛錬場開く", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(4, "GVG参加可能か？", FlowNode.PinTypes.Input, 4)]
  public class GuildLobby : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AC78")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AC79")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x400AC7A")]
    private const int PIN_INPUT_GUILD_FACILITY_ENHANCE = 3;
    [Token(Token = "0x400AC7B")]
    private const int PIN_INPUT_GVG_STATUS = 4;
    [Token(Token = "0x400AC7C")]
    private const int PIN_INPUT_AUTO_UPDATE_ENBALE = 10;
    [Token(Token = "0x400AC7D")]
    private const int PIN_INPUT_AUTO_UPDATE_DISABLE = 11;
    [Token(Token = "0x400AC7E")]
    private const int PIN_OUTPUT_INIT_FINISHED = 100;
    [Token(Token = "0x400AC7F")]
    private const int PIN_OUTPUT_GUILD_TRAINING_OPEN = 101;
    [Token(Token = "0x400AC80")]
    private const int PIN_OUTPUT_GUILD_MASTER = 110;
    [Token(Token = "0x400AC81")]
    private const int PIN_OUTPUT_SUB_GUILD_MASTER = 120;
    [Token(Token = "0x400AC82")]
    private const int PIN_OUTPUT_GUILD_MEMBER = 130;
    [Token(Token = "0x400AC83")]
    private const int PIN_OUTPUT_GUILD_FACILITY_ENHANCE = 140;
    [Token(Token = "0x400AC84")]
    private const int PIN_OUTPUT_NOT_OPEN_ENHANCE = 141;
    [Token(Token = "0x400AC85")]
    private const int PIN_OUTPUT_GUILD_ERROR_NOT_ENTRY = 150;
    [Token(Token = "0x400AC86")]
    private const int PIN_OUTPUT_GUILDRAID_START = 200;
    [Token(Token = "0x400AC87")]
    private const int PIN_OUTPUT_GVG_JOIN = 300;
    [Token(Token = "0x400AC88")]
    private const int PIN_OUTPUT_GVG_NOT_JOIN = 301;
    [Token(Token = "0x400AC89")]
    private const int PIN_OUTPUT_GUILD_UPDATE = 330;
    [Token(Token = "0x400AC8A")]
    [FieldOffset(Offset = "0x0")]
    private static GuildLobby mInstance;
    [Token(Token = "0x400AC8B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mWindow;
    [Token(Token = "0x400AC8C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mGuildInfo;
    [Token(Token = "0x400AC8D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mGuildInfoBadge;
    [Token(Token = "0x400AC8E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mGuildRaidOpen;
    [Token(Token = "0x400AC8F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mGuildRaidClose;
    [Token(Token = "0x400AC90")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mGvGOpen;
    [Token(Token = "0x400AC91")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mGvGClose;
    [Token(Token = "0x400AC92")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mGuildTrainingBadge;
    [Token(Token = "0x400AC93")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mRedirectBtn;
    [Token(Token = "0x400AC94")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mPointQuestRankingBtn;
    [Token(Token = "0x400AC95")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int UpdateTime;
    [Token(Token = "0x400AC96")]
    [FieldOffset(Offset = "0x38")]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400AC97")]
    [FieldOffset(Offset = "0x40")]
    private DateTime UpdateDateTime;
    [Token(Token = "0x400AC98")]
    [FieldOffset(Offset = "0x48")]
    private bool IsAutoUpdateDisable;

    [Token(Token = "0x1700170D")]
    public static GuildLobby Instance
    {
      [Token(Token = "0x600A565"), Address(RVA = "0x678B50", Offset = "0x677950", VA = "0x10678B50")] get
      {
        return (GuildLobby) null;
      }
    }

    [Token(Token = "0x600A566")]
    [Address(RVA = "0x6773B0", Offset = "0x6761B0", VA = "0x106773B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A567")]
    [Address(RVA = "0x677C30", Offset = "0x676A30", VA = "0x10677C30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A568")]
    [Address(RVA = "0x678040", Offset = "0x676E40", VA = "0x10678040")]
    private void Init()
    {
    }

    [Token(Token = "0x600A569")]
    [Address(RVA = "0x678A20", Offset = "0x677820", VA = "0x10678A20")]
    public void Update()
    {
    }

    [Token(Token = "0x600A56A")]
    [Address(RVA = "0x6784B0", Offset = "0x6772B0", VA = "0x106784B0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600A56B")]
    [Address(RVA = "0x6782E0", Offset = "0x6770E0", VA = "0x106782E0")]
    private void OpenGuildFacilityEnhanceUI()
    {
    }

    [Token(Token = "0x600A56C")]
    [Address(RVA = "0x6781B0", Offset = "0x676FB0", VA = "0x106781B0")]
    public void OnGuildRaid()
    {
    }

    [Token(Token = "0x600A56D")]
    [Address(RVA = "0x677D30", Offset = "0x676B30", VA = "0x10677D30")]
    public void ForceAutoUpdate()
    {
    }

    [Token(Token = "0x600A56E")]
    [Address(RVA = "0x6789B0", Offset = "0x6777B0", VA = "0x106789B0")]
    public void StopAutoUpdate()
    {
    }

    [Token(Token = "0x600A56F")]
    [Address(RVA = "0x677FB0", Offset = "0x676DB0", VA = "0x10677FB0")]
    private void InitRedirectBtnActiveStatus()
    {
    }

    [Token(Token = "0x600A570")]
    [Address(RVA = "0x677D80", Offset = "0x676B80", VA = "0x10677D80")]
    private void InitRankingBtnActiveStatus()
    {
    }

    [Token(Token = "0x600A571")]
    [Address(RVA = "0x678B30", Offset = "0x677930", VA = "0x10678B30")]
    public GuildLobby()
    {
    }
  }
}
