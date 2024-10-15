// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002714")]
  [FlowNode.Pin(11, "更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "初期化終了", FlowNode.PinTypes.Output, 101)]
  public class MasteryRewardGroup : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B828")]
    private const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400B829")]
    private const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400B82A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B82B")]
    [FieldOffset(Offset = "0x10")]
    private MasteryRewardGroupModel mMasteryRewardGroupModel;

    [Token(Token = "0x600AF2E")]
    [Address(RVA = "0x735FE0", Offset = "0x734DE0", VA = "0x10735FE0")]
    public void Initialize(MasteryRewardData masteryRewardData)
    {
    }

    [Token(Token = "0x600AF2F")]
    [Address(RVA = "0x736070", Offset = "0x734E70", VA = "0x10736070")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AF30")]
    [Address(RVA = "0x735F90", Offset = "0x734D90", VA = "0x10735F90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF31")]
    [Address(RVA = "0x736070", Offset = "0x734E70", VA = "0x10736070")]
    private void Setup()
    {
    }

    [Token(Token = "0x600AF32")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardGroup()
    {
    }
  }
}
