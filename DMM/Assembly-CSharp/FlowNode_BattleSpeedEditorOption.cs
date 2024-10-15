// Decompiled with JetBrains decompiler
// Type: FlowNode_BattleSpeedEditorOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002A6")]
[AddComponentMenu("")]
[FlowNode.Pin(3, "表示更新", FlowNode.PinTypes.Input, 3)]
[FlowNode.Pin(5, "倍速機能OFF", FlowNode.PinTypes.Input, 5)]
[FlowNode.Pin(2, "オートプレイOFF", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(1, "オートプレイON", FlowNode.PinTypes.Input, 1)]
[FlowNode.NodeType("System/Battle/Speed/BattleSpeedEditorOption", 32741)]
[FlowNode.Pin(4, "倍速機能ON", FlowNode.PinTypes.Input, 4)]
public class FlowNode_BattleSpeedEditorOption : FlowNode
{
  [Token(Token = "0x4000AFB")]
  private const int INPUT_AUTO_PLAY_ON = 1;
  [Token(Token = "0x4000AFC")]
  private const int INPUT_AUTO_PLAY_OFF = 2;
  [Token(Token = "0x4000AFD")]
  private const int INPUT_REFLESH = 3;
  [Token(Token = "0x4000AFE")]
  private const int INPUT_BATTLE_SPEED_ON = 4;
  [Token(Token = "0x4000AFF")]
  private const int INPUT_BATTLE_SPEED_OFF = 5;
  [Token(Token = "0x4000B00")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Toggle AutoPlayToggle;
  [Token(Token = "0x4000B01")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private Toggle battleSpeedToggle;
  [Token(Token = "0x4000B02")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private GameObject battleSpeedLockObj;
  [Token(Token = "0x4000B03")]
  [FieldOffset(Offset = "0x24")]
  [SerializeField]
  private ScrollablePulldown BattleSpeedPulldown;

  [Token(Token = "0x6000E1B")]
  [Address(RVA = "0x11CFBA0", Offset = "0x11CE9A0", VA = "0x111CFBA0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000E1C")]
  [Address(RVA = "0x11CFD90", Offset = "0x11CEB90", VA = "0x111CFD90")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000E1D")]
  [Address(RVA = "0x11D0590", Offset = "0x11CF390", VA = "0x111D0590")]
  private void SetBattleSpeed(int index)
  {
  }

  [Token(Token = "0x6000E1E")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_BattleSpeedEditorOption()
  {
  }
}
