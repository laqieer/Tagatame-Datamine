// Decompiled with JetBrains decompiler
// Type: SRPG.BondHomeInformChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020B3")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "更新有り", FlowNode.PinTypes.Output, 101)]
  public class BondHomeInformChecker : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008CFE")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008CFF")]
    private const int PIN_OUTPUT_UPDATE = 101;
    [Token(Token = "0x4008D00")]
    [FieldOffset(Offset = "0xC")]
    private PlayerData mPlayer;

    [Token(Token = "0x600881C")]
    [Address(RVA = "0x4956B0", Offset = "0x4944B0", VA = "0x104956B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600881D")]
    [Address(RVA = "0x495B20", Offset = "0x494920", VA = "0x10495B20")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600881E")]
    [Address(RVA = "0x4956E0", Offset = "0x4944E0", VA = "0x104956E0")]
    private void BondOpenCheck()
    {
    }

    [Token(Token = "0x600881F")]
    [Address(RVA = "0x495B40", Offset = "0x494940", VA = "0x10495B40")]
    private bool isCheck(string group_id) => new bool();

    [Token(Token = "0x6008820")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BondHomeInformChecker()
    {
    }
  }
}
