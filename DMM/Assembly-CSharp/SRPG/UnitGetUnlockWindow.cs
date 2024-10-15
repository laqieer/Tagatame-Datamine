// Decompiled with JetBrains decompiler
// Type: SRPG.UnitGetUnlockWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C2D")]
  [FlowNode.Pin(101, "Selected Quest", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "Confirmbox Ok", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/UnitGetUnlockWindow")]
  [FlowNode.Pin(100, "Unlock", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(2, "Piece Convert Check", FlowNode.PinTypes.Input, 2)]
  public class UnitGetUnlockWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DAAE")]
    private const int REFRESH = 1;
    [Token(Token = "0x400DAAF")]
    private const int PIECE_CONVERT_CHECK = 2;
    [Token(Token = "0x400DAB0")]
    private const int UNLOCK = 100;
    [Token(Token = "0x400DAB1")]
    private const int SELECTED_QUEST = 101;
    [Token(Token = "0x400DAB2")]
    private const int CONFIRMBOX_OK = 102;
    [Token(Token = "0x400DAB3")]
    [FieldOffset(Offset = "0xC")]
    private UnitParam UnlockUnit;
    [Token(Token = "0x400DAB4")]
    [FieldOffset(Offset = "0x10")]
    public Text UnitName;
    [Token(Token = "0x400DAB5")]
    [FieldOffset(Offset = "0x14")]
    public GameObject DecideButton;
    [Token(Token = "0x400DAB6")]
    [FieldOffset(Offset = "0x18")]
    private GameObject ConfirmBox;

    [Token(Token = "0x600CC9B")]
    [Address(RVA = "0x9775E0", Offset = "0x9763E0", VA = "0x109775E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CC9C")]
    [Address(RVA = "0x976FC0", Offset = "0x975DC0", VA = "0x10976FC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CC9D")]
    [Address(RVA = "0x977370", Offset = "0x976170", VA = "0x10977370")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600CC9E")]
    [Address(RVA = "0x977000", Offset = "0x975E00", VA = "0x10977000")]
    private void CheckPieceConvert()
    {
    }

    [Token(Token = "0x600CC9F")]
    [Address(RVA = "0x9772F0", Offset = "0x9760F0", VA = "0x109772F0")]
    private void OnClickOK(GameObject go)
    {
    }

    [Token(Token = "0x600CCA0")]
    [Address(RVA = "0x977280", Offset = "0x976080", VA = "0x10977280")]
    private void OnClickCancel(GameObject go)
    {
    }

    [Token(Token = "0x600CCA1")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitGetUnlockWindow()
    {
    }
  }
}
