// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideSubPieceConfirmWindow
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
  [Token(Token = "0x2002A54")]
  [FlowNode.Pin(101, "各種通信開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "確認OK", FlowNode.PinTypes.Input, 1)]
  public class RunePrideSubPieceConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CE00")]
    private const int PIN_INPUT_CONFIRM_OK = 1;
    [Token(Token = "0x400CE01")]
    private const int PIN_OUTPUT_CONFIRM_OK = 101;
    [Token(Token = "0x400CE02")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList TargetItemExhibitList;
    [Token(Token = "0x400CE03")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList SubPieceItemExhibitList;
    [Token(Token = "0x400CE04")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour SerializeValue;
    [Token(Token = "0x400CE05")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CE06")]
    [FieldOffset(Offset = "0x1C")]
    private BaseItemModel TargetItemModel;
    [Token(Token = "0x400CE07")]
    [FieldOffset(Offset = "0x20")]
    private BaseItemModel SubPieceItemModel;
    [Token(Token = "0x400CE08")]
    [FieldOffset(Offset = "0x24")]
    private RunePrideSubPieceConfirmWindowModel mModel;

    [Token(Token = "0x600C11F")]
    [Address(RVA = "0x898F70", Offset = "0x897D70", VA = "0x10898F70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C120")]
    [Address(RVA = "0x899130", Offset = "0x897F30", VA = "0x10899130")]
    private void Start()
    {
    }

    [Token(Token = "0x600C121")]
    [Address(RVA = "0x899020", Offset = "0x897E20", VA = "0x10899020")]
    private void Draw()
    {
    }

    [Token(Token = "0x600C122")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideSubPieceConfirmWindow()
    {
    }
  }
}
