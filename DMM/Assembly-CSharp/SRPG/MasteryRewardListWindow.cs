// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002715")]
  [FlowNode.Pin(102, "エンブレム変更演出なし", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "エンブレム変更演出あり", FlowNode.PinTypes.Output, 101)]
  public class MasteryRewardListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B82C")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400B82D")]
    private const int PIN_OUTPUT_GET_EFFECT = 101;
    [Token(Token = "0x400B82E")]
    private const int PIN_OUTPUT_EFFECT = 102;
    [Token(Token = "0x400B82F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B830")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int mSwitchItemDisplayNum;
    [Token(Token = "0x400B831")]
    [FieldOffset(Offset = "0x14")]
    [Header("報酬アイテム表示個数より小さい場合に使用")]
    [SerializeField]
    private GameObject mSwitchItemDisplayLow;
    [Token(Token = "0x400B832")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RewardListItem mSwitchItemDisplayLowReward;
    [Token(Token = "0x400B833")]
    [FieldOffset(Offset = "0x1C")]
    [Header("報酬アイテム表示個数より大きい場合に使用")]
    [SerializeField]
    private GameObject mSwitchItemDisplayHigh;
    [Token(Token = "0x400B834")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RewardListItem mSwitchItemDisplayHighReward;
    [Token(Token = "0x400B835")]
    private const int SWITCH_ITEM_DESPLAY_DEFAULT = 7;
    [Token(Token = "0x400B836")]
    [FieldOffset(Offset = "0x24")]
    private MasteryRewardListModel mMasteryRewardListModel;
    [Token(Token = "0x400B837")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsInitialized;
    [Token(Token = "0x400B838")]
    [FieldOffset(Offset = "0x2C")]
    private List<RewardListItem> mRewardList;
    [Token(Token = "0x400B839")]
    [FieldOffset(Offset = "0x30")]
    private int mRewardItemIconNum;
    [Token(Token = "0x400B83A")]
    [FieldOffset(Offset = "0x34")]
    public MasteryRewardListWindow.CallbackEvent OnResetExecuteCallback;

    [Token(Token = "0x600AF33")]
    [Address(RVA = "0x7364D0", Offset = "0x7352D0", VA = "0x107364D0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600AF34")]
    [Address(RVA = "0x7360C0", Offset = "0x734EC0", VA = "0x107360C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF35")]
    [Address(RVA = "0x736570", Offset = "0x735370", VA = "0x10736570")]
    private void Setup()
    {
    }

    [Token(Token = "0x600AF36")]
    [Address(RVA = "0x736280", Offset = "0x735080", VA = "0x10736280")]
    private void CalcRewardItemIconNum()
    {
    }

    [Token(Token = "0x600AF37")]
    [Address(RVA = "0x736550", Offset = "0x735350", VA = "0x10736550")]
    private bool IsRewardIconScroll() => new bool();

    [Token(Token = "0x600AF38")]
    [Address(RVA = "0x7362F0", Offset = "0x7350F0", VA = "0x107362F0")]
    private void CreateMasteryRewardItemIconList()
    {
    }

    [Token(Token = "0x600AF39")]
    [Address(RVA = "0x736450", Offset = "0x735250", VA = "0x10736450")]
    private void DrawItemIcons()
    {
    }

    [Token(Token = "0x600AF3A")]
    [Address(RVA = "0x736150", Offset = "0x734F50", VA = "0x10736150")]
    private void BranchGetAnimation()
    {
    }

    [Token(Token = "0x600AF3B")]
    [Address(RVA = "0x736900", Offset = "0x735700", VA = "0x10736900")]
    public MasteryRewardListWindow()
    {
    }

    [Token(Token = "0x2002716")]
    public delegate void CallbackEvent();
  }
}
