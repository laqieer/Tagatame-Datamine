// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReleaseAllConfirmWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022EC")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "実行ボタンon", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "装備解除実行", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1001, "例外エラー", FlowNode.PinTypes.Output, 1001)]
  public class CrystalReleaseAllConfirmWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009BAC")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009BAD")]
    private const int PIN_INPUT_OK = 100;
    [Token(Token = "0x4009BAE")]
    private const int PIN_OUTPUT_EXECUTE = 101;
    [Token(Token = "0x4009BAF")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x4009BB0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit ContentExhibit;
    [Token(Token = "0x4009BB1")]
    [FieldOffset(Offset = "0x10")]
    private List<CrystalReleaseAllConfirmWindowModel> mWindowModels;
    [Token(Token = "0x4009BB2")]
    [FieldOffset(Offset = "0x18")]
    private long mCrystalIid;

    [Token(Token = "0x6009616")]
    [Address(RVA = "0x587450", Offset = "0x586250", VA = "0x10587450", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009617")]
    [Address(RVA = "0x587B20", Offset = "0x586920", VA = "0x10587B20")]
    public void SetUp()
    {
    }

    [Token(Token = "0x6009618")]
    [Address(RVA = "0x587500", Offset = "0x586300", VA = "0x10587500")]
    private void ModelSetUp(List<long> owners, CrystalWindow.CrystalUseContents ids)
    {
    }

    [Token(Token = "0x6009619")]
    [Address(RVA = "0x587480", Offset = "0x586280", VA = "0x10587480")]
    private void Draw()
    {
    }

    [Token(Token = "0x600961A")]
    [Address(RVA = "0x5878D0", Offset = "0x5866D0", VA = "0x105878D0")]
    private void OnCheckLeagueMatchMatching()
    {
    }

    [Token(Token = "0x600961B")]
    [Address(RVA = "0x587A90", Offset = "0x586890", VA = "0x10587A90")]
    private void OnExecute()
    {
    }

    [Token(Token = "0x600961C")]
    [Address(RVA = "0x588150", Offset = "0x586F50", VA = "0x10588150")]
    public CrystalReleaseAllConfirmWindow()
    {
    }
  }
}
