// Decompiled with JetBrains decompiler
// Type: SRPG.TitleMenuWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B2B")]
  [FlowNode.Pin(102, "Finish", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "Error", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(3, "DeleteFinish", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "StartConfirm", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "ReceiveDeleteStart", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(104, "Cancel", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(100, "RequestConfirm", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "RequestApply", FlowNode.PinTypes.Output, 101)]
  public class TitleMenuWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400D2B8")]
    private const int PIN_IN_DELETE_RECEIVE = 1;
    [Token(Token = "0x400D2B9")]
    private const int PIN_IN_START_CONFIRM = 2;
    [Token(Token = "0x400D2BA")]
    private const int PIN_IN_DELETE_FINISH = 3;
    [Token(Token = "0x400D2BB")]
    private const int PIN_OUT_REQUEST_CONFIRM = 100;
    [Token(Token = "0x400D2BC")]
    private const int PIN_OUT_REQUEST_APPLY = 101;
    [Token(Token = "0x400D2BD")]
    private const int PIN_OUT_FINISH = 102;
    [Token(Token = "0x400D2BE")]
    private const int PIN_OUT_ERROR = 103;
    [Token(Token = "0x400D2BF")]
    private const int PIN_OUT_CANCEL = 104;
    [Token(Token = "0x400D2C0")]
    private const int CONFIRM_PROGRESS_MAX = 2;
    [Token(Token = "0x400D2C1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject AccountDeleteObject;
    [Token(Token = "0x400D2C2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button AccountDeleteButton;
    [Token(Token = "0x400D2C3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject LogoutObject;
    [Token(Token = "0x400D2C4")]
    [FieldOffset(Offset = "0x18")]
    private string deletion_flow_token;
    [Token(Token = "0x400D2C5")]
    [FieldOffset(Offset = "0x1C")]
    private int progress;

    [Token(Token = "0x600C589")]
    [Address(RVA = "0x8E1670", Offset = "0x8E0470", VA = "0x108E1670")]
    public void Start()
    {
    }

    [Token(Token = "0x600C58A")]
    [Address(RVA = "0x8E1090", Offset = "0x8DFE90", VA = "0x108E1090", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C58B")]
    [Address(RVA = "0x8E12A0", Offset = "0x8E00A0", VA = "0x108E12A0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C58C")]
    [Address(RVA = "0x8E1900", Offset = "0x8E0700", VA = "0x108E1900")]
    private void WriteToken()
    {
    }

    [Token(Token = "0x600C58D")]
    [Address(RVA = "0x8E18F0", Offset = "0x8E06F0", VA = "0x108E18F0")]
    private void UpdateProgress()
    {
    }

    [Token(Token = "0x600C58E")]
    [Address(RVA = "0x8E1440", Offset = "0x8E0240", VA = "0x108E1440")]
    private void RequestConfirm()
    {
    }

    [Token(Token = "0x600C58F")]
    [Address(RVA = "0x8E1310", Offset = "0x8E0110", VA = "0x108E1310")]
    private void RequestApply()
    {
    }

    [Token(Token = "0x600C590")]
    [Address(RVA = "0x8E19A0", Offset = "0x8E07A0", VA = "0x108E19A0")]
    public TitleMenuWindow()
    {
    }
  }
}
