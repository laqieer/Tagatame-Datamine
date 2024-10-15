// Decompiled with JetBrains decompiler
// Type: TownQuestList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002E1")]
[FlowNode.Pin(220, "生成時", FlowNode.PinTypes.Input, 220)]
[FlowNode.Pin(230, "創世編へ", FlowNode.PinTypes.Input, 230)]
[FlowNode.Pin(240, "新イベントへ", FlowNode.PinTypes.Input, 240)]
[FlowNode.Pin(250, "戦闘力クエストへ", FlowNode.PinTypes.Input, 250)]
[FlowNode.Pin(260, "ポイントクエストへ", FlowNode.PinTypes.Input, 260)]
[FlowNode.Pin(1000, "パネル指定後", FlowNode.PinTypes.Output, 1000)]
[FlowNode.NodeType("System/Quest/TownQuestList", 32741)]
[FlowNode.Pin(1010, "生成時にロビー以外を開いた", FlowNode.PinTypes.Output, 1010)]
[FlowNode.Pin(1020, "戦闘力クエストが開催中", FlowNode.PinTypes.Output, 1020)]
[FlowNode.Pin(1021, "戦闘力クエストが非開催", FlowNode.PinTypes.Output, 1021)]
[AddComponentMenu("")]
[FlowNode.Pin(100, "ストーリークエストへ", FlowNode.PinTypes.Input, 100)]
[FlowNode.Pin(200, "生成時にイベントを開く", FlowNode.PinTypes.Input, 200)]
[FlowNode.Pin(190, "生成時にストーリーを開く", FlowNode.PinTypes.Input, 190)]
[FlowNode.Pin(210, "生成時にチャレンジを開く", FlowNode.PinTypes.Input, 210)]
[FlowNode.Pin(170, "メニューを開いた：チャレンジ", FlowNode.PinTypes.Input, 170)]
[FlowNode.Pin(160, "曜日、育成クエストへ", FlowNode.PinTypes.Input, 160)]
[FlowNode.Pin(180, "章解放エフェクト設定", FlowNode.PinTypes.Input, 180)]
[FlowNode.Pin(150, "塔へ", FlowNode.PinTypes.Input, 150)]
[FlowNode.Pin(140, "キークエストへ", FlowNode.PinTypes.Input, 140)]
[FlowNode.Pin(130, "バベル戦記へ", FlowNode.PinTypes.Input, 130)]
[FlowNode.Pin(120, "聖石の追憶へ", FlowNode.PinTypes.Input, 120)]
[FlowNode.Pin(115, "イベントクエスト書庫へ", FlowNode.PinTypes.Input, 115)]
[FlowNode.Pin(110, "イベントクエストへ", FlowNode.PinTypes.Input, 110)]
public class TownQuestList : FlowNode
{
  [Token(Token = "0x4000BF0")]
  private const int INPUT_CHANGE_STORY = 100;
  [Token(Token = "0x4000BF1")]
  private const int INPUT_CHANGE_EVENT = 110;
  [Token(Token = "0x4000BF2")]
  private const int INPUT_CHANGE_ARCHIVE = 115;
  [Token(Token = "0x4000BF3")]
  private const int INPUT_CHANGE_SEISEKI = 120;
  [Token(Token = "0x4000BF4")]
  private const int INPUT_CHANGE_BABEL = 130;
  [Token(Token = "0x4000BF5")]
  private const int INPUT_CHANGE_KEY = 140;
  [Token(Token = "0x4000BF6")]
  private const int INPUT_CHANGE_TOWER = 150;
  [Token(Token = "0x4000BF7")]
  private const int INPUT_CHANGE_WEEKDAY = 160;
  [Token(Token = "0x4000BF8")]
  private const int INPUT_CHECK_RELEASE_ORDEAL = 170;
  [Token(Token = "0x4000BF9")]
  private const int INPUT_SETUP_CHAPTER_EFFECT = 180;
  [Token(Token = "0x4000BFA")]
  private const int INPUT_OPEN_MENU_STORY = 190;
  [Token(Token = "0x4000BFB")]
  private const int INPUT_OPEN_MENU_EVENT = 200;
  [Token(Token = "0x4000BFC")]
  private const int INPUT_OPEN_MENU_CHALLENGE = 210;
  [Token(Token = "0x4000BFD")]
  private const int INPUT_INITIALIZE = 220;
  [Token(Token = "0x4000BFE")]
  private const int INPUT_CHANGE_GENESIS = 230;
  [Token(Token = "0x4000BFF")]
  private const int INPUT_CHANGE_ADVANCE = 240;
  [Token(Token = "0x4000C00")]
  private const int INPUT_CHANGE_COMBATPOWRE = 250;
  [Token(Token = "0x4000C01")]
  private const int INPUT_CHANGE_POINTQUEST = 260;
  [Token(Token = "0x4000C02")]
  private const int OUTPUT_OPEN_MENU = 1000;
  [Token(Token = "0x4000C03")]
  private const int OUTPUT_OPEN_SHORTCUT = 1010;
  [Token(Token = "0x4000C04")]
  private const int OUTPUT_COMBATPOWERQUEST_OPEN = 1020;
  [Token(Token = "0x4000C05")]
  private const int OUTPUT_COMBATPOWERQUEST_CLOSE = 1021;
  [Token(Token = "0x4000C06")]
  private const string CHANGE_SCENE_STORY = "TO_STORY";
  [Token(Token = "0x4000C07")]
  private const string CHANGE_SCENE_EVENT = "TO_EVENT";
  [Token(Token = "0x4000C08")]
  private const string CHANGE_SCENE_GENESIS = "TO_GENESIS";
  [Token(Token = "0x4000C09")]
  private const string CHANGE_SCENE_ADVANCE = "TO_ADVANCE";
  [Token(Token = "0x4000C0A")]
  private const string ENABLE_RANKING_QUEST = "ENABLE_RANKING_QUEST";
  [Token(Token = "0x4000C0B")]
  private const string CHANGE_SCENE_POINTQUEST = "TO_POINTQUEST";
  [Token(Token = "0x4000C0C")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject mOrdealObj;
  [Token(Token = "0x4000C0D")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private GameObject mStoryReleaseEffectObj;
  [Token(Token = "0x4000C0E")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private List<GameObject> mPanelRootList;
  [Token(Token = "0x4000C0F")]
  [FieldOffset(Offset = "0x0")]
  private static TownQuestList.PanelType mReqStartTimeShowPanel;

  [Token(Token = "0x6000EF6")]
  [Address(RVA = "0x12A59B0", Offset = "0x12A47B0", VA = "0x112A59B0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000EF7")]
  [Address(RVA = "0x12A57E0", Offset = "0x12A45E0", VA = "0x112A57E0")]
  private void Initialize()
  {
  }

  [Token(Token = "0x6000EF8")]
  [Address(RVA = "0x12A6280", Offset = "0x12A5080", VA = "0x112A6280")]
  private void ShowTargetPanel(TownQuestList.PanelType targetPanel)
  {
  }

  [Token(Token = "0x6000EF9")]
  [Address(RVA = "0x12A5F60", Offset = "0x12A4D60", VA = "0x112A5F60")]
  private void OnAfterStartup(bool success)
  {
  }

  [Token(Token = "0x6000EFA")]
  [Address(RVA = "0x12A6190", Offset = "0x12A4F90", VA = "0x112A6190")]
  private IEnumerator OrdealReleaseAnimationCoroutine(GameObject obj, UnlockParam lockState)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000EFB")]
  [Address(RVA = "0x12A6200", Offset = "0x12A5000", VA = "0x112A6200")]
  private void SetReleaseStoryPartAction()
  {
  }

  [Token(Token = "0x6000EFC")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public TownQuestList()
  {
  }

  [Token(Token = "0x20002E2")]
  public enum PanelType
  {
    [Token(Token = "0x4000C11")] root,
    [Token(Token = "0x4000C12")] storyQuest,
    [Token(Token = "0x4000C13")] eventQuest,
    [Token(Token = "0x4000C14")] Challenge,
    [Token(Token = "0x4000C15")] max,
  }
}
