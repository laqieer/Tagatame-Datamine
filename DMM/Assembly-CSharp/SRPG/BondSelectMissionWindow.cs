// Decompiled with JetBrains decompiler
// Type: SRPG.BondSelectMissionWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020C9")]
  [FlowNode.Pin(102, "報酬受け取りへ", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/Bond/BondSelectMissionWindow")]
  [FlowNode.Pin(2, "報酬受け取り", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "表示生成", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "表示完了", FlowNode.PinTypes.Output, 101)]
  public class BondSelectMissionWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008D93")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008D94")]
    private const int PIN_INPUT_REWARD_RECEIVE = 2;
    [Token(Token = "0x4008D95")]
    private const int PIN_INPUT_REFRESH_FIN = 101;
    [Token(Token = "0x4008D96")]
    private const int PIN_INPUT_REQ_REWARD_RECEIVE = 102;
    [Token(Token = "0x4008D97")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRewardListTTemplete;
    [Token(Token = "0x4008D98")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4008D99")]
    [FieldOffset(Offset = "0x14")]
    private List<BondMissionContentParam> mBondMissionContentParams;

    [Token(Token = "0x60088A5")]
    [Address(RVA = "0x49DBD0", Offset = "0x49C9D0", VA = "0x1049DBD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60088A6")]
    [Address(RVA = "0x49DA80", Offset = "0x49C880", VA = "0x1049DA80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60088A7")]
    [Address(RVA = "0x49DC20", Offset = "0x49CA20", VA = "0x1049DC20")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60088A8")]
    [Address(RVA = "0x49E190", Offset = "0x49CF90", VA = "0x1049E190")]
    public BondSelectMissionWindow()
    {
    }
  }
}
