// Decompiled with JetBrains decompiler
// Type: SRPG.ConfigWindow
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
  [Token(Token = "0x2002253")]
  [FlowNode.Pin(101, "PostOnPlay", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "Revert Comment", FlowNode.PinTypes.Input, 200)]
  [AddComponentMenu("UI/ConfigWindow")]
  [FlowNode.Pin(201, "Revert Comment Finished", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(10, "UpdatePlayerInfo", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(300, "UpdateLeagueMatchPushSetting", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(100, "OnPlay", FlowNode.PinTypes.Input, 100)]
  public class ConfigWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400984D")]
    private const int PIN_INPUT_UPDATE_PLAYER_INFO = 10;
    [Token(Token = "0x400984E")]
    private const int PIN_INPUT_ON_PLAY = 100;
    [Token(Token = "0x400984F")]
    private const int PIN_OUTPUT_POST_ON_PLAY = 101;
    [Token(Token = "0x4009850")]
    private const int PIN_INPUT_REVERT_MULTI_INVITATION_COMMENT = 200;
    [Token(Token = "0x4009851")]
    private const int PIN_OUTPUT_REVERT_MULTI_INVITATION_COMMENT = 201;
    [Token(Token = "0x4009852")]
    private const int PIN_INPUT_UPDATE_LEAGUEMATCH_PUSH_SETTING = 300;
    [Token(Token = "0x4009853")]
    [FieldOffset(Offset = "0xC")]
    public Slider SoundVolume;
    [Token(Token = "0x4009854")]
    [FieldOffset(Offset = "0x10")]
    public Slider MusicVolume;
    [Token(Token = "0x4009855")]
    [FieldOffset(Offset = "0x14")]
    public Slider VoiceVolume;
    [Token(Token = "0x4009856")]
    [FieldOffset(Offset = "0x18")]
    public Toggle UseAssetBundle;
    [Token(Token = "0x4009857")]
    [FieldOffset(Offset = "0x1C")]
    public Toggle UseDevServer;
    [Token(Token = "0x4009858")]
    [FieldOffset(Offset = "0x20")]
    public Toggle UseAwsServer;
    [Token(Token = "0x4009859")]
    [FieldOffset(Offset = "0x24")]
    public Toggle NewGame;
    [Token(Token = "0x400985A")]
    [FieldOffset(Offset = "0x28")]
    public Toggle[] InputMethods;
    [Token(Token = "0x400985B")]
    [FieldOffset(Offset = "0x2C")]
    public Toggle UseAutoPlay;
    [Token(Token = "0x400985C")]
    [FieldOffset(Offset = "0x30")]
    public Toggle UsePushStamina;
    [Token(Token = "0x400985D")]
    [FieldOffset(Offset = "0x34")]
    public Toggle UsePushNews;
    [Token(Token = "0x400985E")]
    [FieldOffset(Offset = "0x38")]
    public Toggle UsePushLeagueMatch;
    [Token(Token = "0x400985F")]
    [FieldOffset(Offset = "0x3C")]
    public Toggle MultiInvitationFlag;
    [Token(Token = "0x4009860")]
    [FieldOffset(Offset = "0x40")]
    public InputField MultiInvitationComment;
    [Token(Token = "0x4009861")]
    [FieldOffset(Offset = "0x44")]
    public GameObject LoginBonus;
    [Token(Token = "0x4009862")]
    [FieldOffset(Offset = "0x48")]
    public GameObject LoginBonus28days;
    [Token(Token = "0x4009863")]
    [FieldOffset(Offset = "0x4C")]
    public InputField AssetVersion;
    [Token(Token = "0x4009864")]
    [FieldOffset(Offset = "0x50")]
    public Toggle ToggleChatState;
    [Token(Token = "0x4009865")]
    [FieldOffset(Offset = "0x54")]
    public Toggle ToggleMultiState;
    [Token(Token = "0x4009866")]
    [FieldOffset(Offset = "0x58")]
    public Toggle MultiUserSetting;
    [Token(Token = "0x4009867")]
    [FieldOffset(Offset = "0x5C")]
    public InputField MultiUserName;
    [Token(Token = "0x4009868")]
    [FieldOffset(Offset = "0x60")]
    public Toggle UseLocalMasterData;
    [Token(Token = "0x4009869")]
    [FieldOffset(Offset = "0x64")]
    public Toggle UseServerMasterData;
    [Token(Token = "0x400986A")]
    [FieldOffset(Offset = "0x68")]
    public Toggle UseSerializedParams;
    [Token(Token = "0x400986B")]
    [FieldOffset(Offset = "0x6C")]
    public Toggle UseEncryption;
    [Token(Token = "0x400986C")]
    [FieldOffset(Offset = "0x70")]
    public Button MasterCheckButton;
    [Token(Token = "0x400986D")]
    [FieldOffset(Offset = "0x74")]
    public Button VoiceCopyButton;
    [Token(Token = "0x400986E")]
    [FieldOffset(Offset = "0x78")]
    public InputField ClientExPath;
    [Token(Token = "0x400986F")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject AwardState;
    [Token(Token = "0x4009870")]
    [FieldOffset(Offset = "0x80")]
    public GameObject SupportIcon;
    [Token(Token = "0x4009871")]
    [FieldOffset(Offset = "0x84")]
    public GameObject Prefab_NewItemBadge;
    [Token(Token = "0x4009872")]
    [FieldOffset(Offset = "0x88")]
    public GameObject TreasureList;
    [Token(Token = "0x4009873")]
    [FieldOffset(Offset = "0x8C")]
    public GameObject TreasureListNode;
    [Token(Token = "0x4009874")]
    [FieldOffset(Offset = "0x90")]
    public Toggle ShowSizeBeforeDownloading;
    [Token(Token = "0x4009875")]
    [FieldOffset(Offset = "0x94")]
    public GameObject Emblem;
    [Token(Token = "0x4009876")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject mastery_release;
    [Token(Token = "0x4009877")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private GameObject mastery_none;
    [Token(Token = "0x4009878")]
    [FieldOffset(Offset = "0xA0")]
    private List<GameObject> mTreasureListNodes;
    [Token(Token = "0x4009879")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private List<ConfigPremiumLoginBonusButton> PremiumBonus;

    [Token(Token = "0x600924C")]
    [Address(RVA = "0x5597B0", Offset = "0x5585B0", VA = "0x105597B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600924D")]
    [Address(RVA = "0x55A790", Offset = "0x559590", VA = "0x1055A790")]
    private void Start()
    {
    }

    [Token(Token = "0x600924E")]
    [Address(RVA = "0x559C40", Offset = "0x558A40", VA = "0x10559C40")]
    private void OnInputMethodChange(bool y)
    {
    }

    [Token(Token = "0x600924F")]
    [Address(RVA = "0x55CE30", Offset = "0x55BC30", VA = "0x1055CE30")]
    private void UpdatePlayerInfo()
    {
    }

    [Token(Token = "0x6009250")]
    [Address(RVA = "0x559D30", Offset = "0x558B30", VA = "0x10559D30")]
    private void OnPlay()
    {
    }

    [Token(Token = "0x6009251")]
    [Address(RVA = "0x559D80", Offset = "0x558B80", VA = "0x10559D80")]
    private void RevertMultiInvitationComment()
    {
    }

    [Token(Token = "0x6009252")]
    [Address(RVA = "0x559F00", Offset = "0x558D00", VA = "0x10559F00")]
    public static void SetupTreasureList(
      GameObject list,
      GameObject node,
      GameObject newIcon,
      GameObject owner,
      List<GameObject> itemNodes)
    {
    }

    [Token(Token = "0x6009253")]
    [Address(RVA = "0x559A30", Offset = "0x558830", VA = "0x10559A30")]
    public static GameObject CreateItemObject(
      GameObject node,
      GameObject newIcon,
      QuestResult.DropItemData item)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6009254")]
    [Address(RVA = "0x55CFC0", Offset = "0x55BDC0", VA = "0x1055CFC0")]
    public ConfigWindow()
    {
    }
  }
}
