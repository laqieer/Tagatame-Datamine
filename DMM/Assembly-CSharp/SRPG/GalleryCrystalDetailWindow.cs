// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryCrystalDetailWindow
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
  [Token(Token = "0x20022A4")]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "エラー", FlowNode.PinTypes.Output, 101)]
  public class GalleryCrystalDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40099E1")]
    private const int PIN_INPUT_INIT = 0;
    [Token(Token = "0x40099E2")]
    private const int PIN_OUTPUT_ERROR = 101;
    [Token(Token = "0x40099E3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40099E4")]
    [FieldOffset(Offset = "0x10")]
    private GalleryCrystalDetailModel mModel;

    [Token(Token = "0x600945B")]
    [Address(RVA = "0x579A80", Offset = "0x578880", VA = "0x10579A80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600945C")]
    [Address(RVA = "0x579BF0", Offset = "0x5789F0", VA = "0x10579BF0")]
    private void Init()
    {
    }

    [Token(Token = "0x600945D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GalleryCrystalDetailWindow()
    {
    }
  }
}
