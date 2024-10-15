// Decompiled with JetBrains decompiler
// Type: SRPG.BoardBonusController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F9")]
  [FlowNode.Pin(200, "更新", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class BoardBonusController : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CBEF")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CBF0")]
    private const int PIN_INPUT_REFRESH = 200;
    [Token(Token = "0x400CBF1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RunePrideParameterListView paramterListView;

    [Token(Token = "0x600BF4E")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BF4F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Initialize(string unit_iname)
    {
    }

    [Token(Token = "0x600BF50")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BF51")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void CreatePotentialBonusWindow(string potentialId)
    {
    }

    [Token(Token = "0x600BF52")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BoardBonusController()
    {
    }
  }
}
