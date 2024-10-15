// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_VersusBattleSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017A6")]
  [FlowNode.Pin(102, "倍速バトルON", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "倍速バトルOFF", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "バトルスピード変更", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "倍速バトルOFF設定", FlowNode.PinTypes.Input, 3)]
  [FlowNode.NodeType("MultiPlay/VersusBattleSpeed", 32741)]
  [FlowNode.Pin(4, "倍速バトルON設定", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(2, "バトルスピード確認", FlowNode.PinTypes.Input, 2)]
  public class FlowNode_MP_VersusBattleSpeed : FlowNode
  {
    [Token(Token = "0x400552F")]
    private const int PIN_INPUT_CHANGE_BATTLE_SPEED = 1;
    [Token(Token = "0x4005530")]
    private const int PIN_INPUT_CHECK_BATTLE_SPEED = 2;
    [Token(Token = "0x4005531")]
    private const int PIN_INPUT_SET_BATTLE_SPEED_OFF = 3;
    [Token(Token = "0x4005532")]
    private const int PIN_INPUT_SET_BATTLE_SPEED_ON = 4;
    [Token(Token = "0x4005533")]
    private const int PIN_OUTPUT_MIN_SPEED = 101;
    [Token(Token = "0x4005534")]
    private const int PIN_OUTPUT_MAX_SPEED = 102;
    [Token(Token = "0x4005535")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_MP_VersusBattleSpeed.SetVersusBattleSpeedType type;

    [Token(Token = "0x6005FEE")]
    [Address(RVA = "0x1353330", Offset = "0x1352130", VA = "0x11353330", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005FEF")]
    [Address(RVA = "0x1353050", Offset = "0x1351E50", VA = "0x11353050")]
    private void ChangeBattleSpeed()
    {
    }

    [Token(Token = "0x6005FF0")]
    [Address(RVA = "0x1353210", Offset = "0x1352010", VA = "0x11353210")]
    private void CheckBattleSpeed()
    {
    }

    [Token(Token = "0x6005FF1")]
    [Address(RVA = "0x1353590", Offset = "0x1352390", VA = "0x11353590")]
    private void SetBattleSpeed(int _speed)
    {
    }

    [Token(Token = "0x6005FF2")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_VersusBattleSpeed()
    {
    }

    [Token(Token = "0x20017A7")]
    public enum SetVersusBattleSpeedType
    {
      [Token(Token = "0x4005537")] None,
      [Token(Token = "0x4005538")] RankMatch,
      [Token(Token = "0x4005539")] Versus,
      [Token(Token = "0x400553A")] Friend,
    }
  }
}
