// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardReceiveWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028F0")]
  [FlowNode.Pin(1, "閉じる選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "投じる", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("UI/Raid/RaidRewardReceiveWindow")]
  [FlowNode.Pin(10, "自動分解結果表示", FlowNode.PinTypes.Output, 10)]
  public class RaidRewardReceiveWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C4D6")]
    private const int PIN_INPUT_CLOSE = 1;
    [Token(Token = "0x400C4D7")]
    private const int PIN_OUTPUT_OPEN_DISASSEMBLE = 10;
    [Token(Token = "0x400C4D8")]
    private const int PIN_OUTPUT_CLOSE = 11;
    [Token(Token = "0x400C4D9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool mRewardAllDraw;
    [Token(Token = "0x400C4DA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mTitleText;
    [Token(Token = "0x400C4DB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mMessageText;
    [Token(Token = "0x400C4DC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform mBaseRewardTransform;
    [Token(Token = "0x400C4DD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mBeatReward;
    [Token(Token = "0x400C4DE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mRatioReward;
    [Token(Token = "0x400C4DF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mAmountReward;
    [Token(Token = "0x400C4E0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RaidRewardIcon mRewardItem;
    [Token(Token = "0x400C4E1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SerializeValueBehaviour mSvb;
    [Token(Token = "0x400C4E2")]
    [FieldOffset(Offset = "0x30")]
    private bool IsEnableRuneDisassemble;

    [Token(Token = "0x600B94C")]
    [Address(RVA = "0x80C380", Offset = "0x80B180", VA = "0x1080C380", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B94D")]
    [Address(RVA = "0x80C3D0", Offset = "0x80B1D0", VA = "0x1080C3D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B94E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidRewardReceiveWindow()
    {
    }
  }
}
