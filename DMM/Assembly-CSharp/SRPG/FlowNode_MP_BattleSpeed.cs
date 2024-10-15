// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_BattleSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D1")]
  [FlowNode.NodeType("MultiPlay/BattleSpeed", 32741)]
  [FlowNode.Pin(100, "Update", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "Update Success", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "Update Failure", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(200, "Is Hispeed", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(201, "Yes", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "No", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(250, "Change Battll Speed", FlowNode.PinTypes.Input, 250)]
  [FlowNode.Pin(251, "Update Battll Speed", FlowNode.PinTypes.Input, 251)]
  [FlowNode.Pin(252, "Finish Change Battll Speed", FlowNode.PinTypes.Output, 252)]
  [AddComponentMenu("")]
  public class FlowNode_MP_BattleSpeed : FlowNode
  {
    [Token(Token = "0x40055A0")]
    private const int PIN_IN_UPDATE = 100;
    [Token(Token = "0x40055A1")]
    private const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x40055A2")]
    private const int PIN_OUT_FAILURE = 102;
    [Token(Token = "0x40055A3")]
    private const int PIN_IN_IS_HISPEED = 200;
    [Token(Token = "0x40055A4")]
    private const int PIN_OUT_IS_HISPEED_TRUE = 201;
    [Token(Token = "0x40055A5")]
    private const int PIN_OUT_IS_HISPEED_FALSE = 202;
    [Token(Token = "0x40055A6")]
    private const int PIN_IN_CHANGE_BATTLE_SPEED = 250;
    [Token(Token = "0x40055A7")]
    private const int PIN_IN_UPDATE_BATTLE_SPEED = 251;
    [Token(Token = "0x40055A8")]
    private const int PIN_OUT_CHANGE_BATTLE_SPEED = 252;
    [Token(Token = "0x40055A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool HiSpeed;
    [Token(Token = "0x40055AA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ImageArray BattleSpeedImageArray;
    [Token(Token = "0x40055AB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button BattleSpeedButton;
    [Token(Token = "0x40055AC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject PeriodObj;
    [Token(Token = "0x40055AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text PeriodText;
    [Token(Token = "0x40055AE")]
    [FieldOffset(Offset = "0x2C")]
    private float[] mSpeedList;
    [Token(Token = "0x40055AF")]
    [FieldOffset(Offset = "0x30")]
    private int mSelectBattleSpeedIndex;

    [Token(Token = "0x600606D")]
    [Address(RVA = "0x1349FE0", Offset = "0x1348DE0", VA = "0x11349FE0", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600606E")]
    [Address(RVA = "0x134A300", Offset = "0x1349100", VA = "0x1134A300", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600606F")]
    [Address(RVA = "0x134AB90", Offset = "0x1349990", VA = "0x1134AB90")]
    private void UpdateSpeed()
    {
    }

    [Token(Token = "0x6006070")]
    [Address(RVA = "0x134A1D0", Offset = "0x1348FD0", VA = "0x1134A1D0")]
    private void IsHiSpeed()
    {
    }

    [Token(Token = "0x6006071")]
    [Address(RVA = "0x134A040", Offset = "0x1348E40", VA = "0x1134A040")]
    private void ChangeBattleSpeed()
    {
    }

    [Token(Token = "0x6006072")]
    [Address(RVA = "0x134A850", Offset = "0x1349650", VA = "0x1134A850")]
    private void UpdateBattleSpeed()
    {
    }

    [Token(Token = "0x6006073")]
    [Address(RVA = "0x134A180", Offset = "0x1348F80", VA = "0x1134A180")]
    private int GetSpeedListIndex(float speed) => new int();

    [Token(Token = "0x6006074")]
    [Address(RVA = "0x134A640", Offset = "0x1349440", VA = "0x1134A640")]
    private void SetExpansinPeriod()
    {
    }

    [Token(Token = "0x6006075")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_BattleSpeed()
    {
    }
  }
}
