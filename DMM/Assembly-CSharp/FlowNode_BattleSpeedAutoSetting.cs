// Decompiled with JetBrains decompiler
// Type: FlowNode_BattleSpeedAutoSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002A5")]
[AddComponentMenu("")]
[FlowNode.Pin(11, "倍速ボタンリセット", FlowNode.PinTypes.Input, 11)]
[FlowNode.Pin(10, "倍速切り替え", FlowNode.PinTypes.Input, 10)]
[FlowNode.Pin(8, "倍速機能 操作可", FlowNode.PinTypes.Input, 8)]
[FlowNode.Pin(7, "オートプレイ操作不可", FlowNode.PinTypes.Input, 7)]
[FlowNode.Pin(9, "倍速機能 操作不可", FlowNode.PinTypes.Input, 9)]
[FlowNode.Pin(5, "倍速機能OFF", FlowNode.PinTypes.Input, 5)]
[FlowNode.Pin(6, "オートプレイ操作可", FlowNode.PinTypes.Input, 6)]
[FlowNode.NodeType("System/Battle/Speed/BattleSpeedAutoSetting", 32741)]
[FlowNode.Pin(1, "オプション画面での倍速切り替え", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(4, "倍速機能ON", FlowNode.PinTypes.Input, 4)]
[FlowNode.Pin(3, "オートプレイOFF", FlowNode.PinTypes.Input, 3)]
[FlowNode.Pin(2, "オートプレイON", FlowNode.PinTypes.Input, 2)]
public class FlowNode_BattleSpeedAutoSetting : FlowNode
{
  [Token(Token = "0x4000AE7")]
  private const int INPUT_CHANGE_BATTLE_SPEED = 1;
  [Token(Token = "0x4000AE8")]
  private const int INPUT_AUTO_PLAY_ON = 2;
  [Token(Token = "0x4000AE9")]
  private const int INPUT_AUTO_PLAY_OFF = 3;
  [Token(Token = "0x4000AEA")]
  private const int INPUT_BATTLE_SPEED_ON = 4;
  [Token(Token = "0x4000AEB")]
  private const int INPUT_BATTLE_SPEED_OFF = 5;
  [Token(Token = "0x4000AEC")]
  private const int INPUT_AUTO_PLAY_INTERACTABLE_ON = 6;
  [Token(Token = "0x4000AED")]
  private const int INPUT_AUTO_PLAY_INTERACTABLE_OFF = 7;
  [Token(Token = "0x4000AEE")]
  private const int INPUT_BATTLE_SPEED_INTERACTABLE_ON = 8;
  [Token(Token = "0x4000AEF")]
  private const int INPUT_BATTLE_SPEED_INTERACTABLE_OFF = 9;
  [Token(Token = "0x4000AF0")]
  private const int INPUT_BATTLE_SPEED_CHANGE = 10;
  [Token(Token = "0x4000AF1")]
  private const int INPUT_RESET_BATTLE_SPEED_BUTTON = 11;
  [Token(Token = "0x4000AF2")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Toggle battleSpeedToggle;
  [Token(Token = "0x4000AF3")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private GameObject battleSpeedLockObj;
  [Token(Token = "0x4000AF4")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Toggle autoPlayToggle;
  [Token(Token = "0x4000AF5")]
  [FieldOffset(Offset = "0x24")]
  [SerializeField]
  private bool isShowButtonNotVip;
  [Token(Token = "0x4000AF6")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private ImageArray battleSpeedArray;
  [Token(Token = "0x4000AF7")]
  [FieldOffset(Offset = "0x2C")]
  [SerializeField]
  private Button battleSpeedChangeButton;
  [Token(Token = "0x4000AF8")]
  [FieldOffset(Offset = "0x30")]
  private int battleSpeedIndex;
  [Token(Token = "0x4000AF9")]
  [FieldOffset(Offset = "0x34")]
  private float[] speedList;
  [Token(Token = "0x4000AFA")]
  public const string AUTO_TOGGLE_CHANGE_KEY = "AUTO_TOGGLE_CHANGE_KEY";

  [Token(Token = "0x6000E13")]
  [Address(RVA = "0x11CEC10", Offset = "0x11CDA10", VA = "0x111CEC10", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000E14")]
  [Address(RVA = "0x11CF2C0", Offset = "0x11CE0C0", VA = "0x111CF2C0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000E15")]
  [Address(RVA = "0x11CF970", Offset = "0x11CE770", VA = "0x111CF970", Slot = "8")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000E16")]
  [Address(RVA = "0x11CF250", Offset = "0x11CE050", VA = "0x111CF250")]
  private void ChangeToggleInteractable(Toggle target, bool is_interactable)
  {
  }

  [Token(Token = "0x6000E17")]
  [Address(RVA = "0x11CF890", Offset = "0x11CE690", VA = "0x111CF890")]
  private void OnChangeBattleSpeed()
  {
  }

  [Token(Token = "0x6000E18")]
  [Address(RVA = "0x11CFA00", Offset = "0x11CE800", VA = "0x111CFA00")]
  private void ResetBattleSpeedIndex()
  {
  }

  [Token(Token = "0x6000E19")]
  [Address(RVA = "0x11CFAE0", Offset = "0x11CE8E0", VA = "0x111CFAE0")]
  private int ToBattleSpeedindex(float speed) => new int();

  [Token(Token = "0x6000E1A")]
  [Address(RVA = "0x11CFB80", Offset = "0x11CE980", VA = "0x111CFB80")]
  public FlowNode_BattleSpeedAutoSetting()
  {
  }
}
