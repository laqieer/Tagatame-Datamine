// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardWindow
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
  [Token(Token = "0x200271E")]
  [FlowNode.Pin(1, "更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "初期化", FlowNode.PinTypes.Input, 11)]
  public class MasteryRewardWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B849")]
    private const int PIN_IN_INIT = 11;
    [Token(Token = "0x400B84A")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400B84B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B84C")]
    [FieldOffset(Offset = "0x10")]
    private MasteryRewardModel mMasteryRewardModel;

    [Token(Token = "0x600AF65")]
    [Address(RVA = "0x7386E0", Offset = "0x7374E0", VA = "0x107386E0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600AF66")]
    [Address(RVA = "0x738760", Offset = "0x737560", VA = "0x10738760")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600AF67")]
    [Address(RVA = "0x738590", Offset = "0x737390", VA = "0x10738590", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF68")]
    [Address(RVA = "0x7387F0", Offset = "0x7375F0", VA = "0x107387F0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600AF69")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MasteryRewardWindow()
    {
    }
  }
}
