// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraFullMasterConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B2C")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "初期化成功", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "初期化失敗", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/TobiraFullMasterConfirmWindow")]
  public class TobiraFullMasterConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D2C6")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400D2C7")]
    private const int PIN_OUTPUT_INIT_SUCCESS = 101;
    [Token(Token = "0x400D2C8")]
    private const int PIN_OUTPUT_INIT_ERROR = 102;
    [Token(Token = "0x400D2C9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mContentText;

    [Token(Token = "0x600C597")]
    [Address(RVA = "0x8E19F0", Offset = "0x8E07F0", VA = "0x108E19F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C598")]
    [Address(RVA = "0x8E1A10", Offset = "0x8E0810", VA = "0x108E1A10")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600C599")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TobiraFullMasterConfirmWindow()
    {
    }
  }
}
