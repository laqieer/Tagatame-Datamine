// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Timer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001647")]
  [FlowNode.Pin(10, "タイマー起動", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "完了", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(30, "タイマー停止", FlowNode.PinTypes.Input, 30)]
  [FlowNode.NodeType("Timer/Timer", 32741)]
  [FlowNode.Pin(20, "タイマーリセット", FlowNode.PinTypes.Input, 20)]
  public class FlowNode_Timer : FlowNode
  {
    [Token(Token = "0x40050EA")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x40050EB")]
    private const int PIN_INPUT_RESET = 20;
    [Token(Token = "0x40050EC")]
    private const int PIN_INPUT_STOP = 30;
    [Token(Token = "0x40050ED")]
    private const int PIN_OUTPUT_FINISH = 1001;
    [Token(Token = "0x40050EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float mTime;
    [Token(Token = "0x40050EF")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsCheck;
    [Token(Token = "0x40050F0")]
    [FieldOffset(Offset = "0x20")]
    private float mRestTime;

    [Token(Token = "0x6005B94")]
    [Address(RVA = "0x130F740", Offset = "0x130E540", VA = "0x1130F740", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6005B95")]
    [Address(RVA = "0x130F760", Offset = "0x130E560", VA = "0x1130F760", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B96")]
    [Address(RVA = "0x130F7B0", Offset = "0x130E5B0", VA = "0x1130F7B0")]
    private void StartCheck()
    {
    }

    [Token(Token = "0x6005B97")]
    [Address(RVA = "0x130F7D0", Offset = "0x130E5D0", VA = "0x1130F7D0")]
    private void StopCheck()
    {
    }

    [Token(Token = "0x6005B98")]
    [Address(RVA = "0x1232840", Offset = "0x1231640", VA = "0x11232840")]
    private void ResetTimer()
    {
    }

    [Token(Token = "0x6005B99")]
    [Address(RVA = "0x130F7F0", Offset = "0x130E5F0", VA = "0x1130F7F0")]
    private void Update()
    {
    }

    [Token(Token = "0x6005B9A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Timer()
    {
    }
  }
}
