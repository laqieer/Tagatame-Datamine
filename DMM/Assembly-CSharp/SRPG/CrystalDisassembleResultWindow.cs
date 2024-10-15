// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalDisassembleResultWindow
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
  [Token(Token = "0x20022B6")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Initialize Done", FlowNode.PinTypes.Output, 100)]
  public class CrystalDisassembleResultWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009A73")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009A74")]
    private const int PIN_OUTPUT_INIT_END = 100;
    [Token(Token = "0x4009A75")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList DisassembleResultWindowExhibitList;
    [Token(Token = "0x4009A76")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalIcon SelectIcon;
    [Token(Token = "0x4009A77")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ResultAmount;
    [Token(Token = "0x4009A78")]
    [FieldOffset(Offset = "0x18")]
    private CrystalData mData;
    [Token(Token = "0x4009A79")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalDisassembleWindowModel mDisassembleResultWindowModel;

    [Token(Token = "0x60094F4")]
    [Address(RVA = "0x57D3D0", Offset = "0x57C1D0", VA = "0x1057D3D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60094F5")]
    [Address(RVA = "0x57D530", Offset = "0x57C330", VA = "0x1057D530")]
    public bool SetUp(CrystalData _data) => new bool();

    [Token(Token = "0x60094F6")]
    [Address(RVA = "0x57D4B0", Offset = "0x57C2B0", VA = "0x1057D4B0")]
    private void Draw()
    {
    }

    [Token(Token = "0x60094F7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalDisassembleResultWindow()
    {
    }
  }
}
