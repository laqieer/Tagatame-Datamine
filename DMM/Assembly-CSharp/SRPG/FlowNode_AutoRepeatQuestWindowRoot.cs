// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AutoRepeatQuestWindowRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012E7")]
  [FlowNode.NodeType("AutoRepeatQuest/ProgressWindow", 32741)]
  [FlowNode.Pin(10, "自動周回中かチェック", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "OK", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "NG", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  public class FlowNode_AutoRepeatQuestWindowRoot : FlowNode
  {
    [Token(Token = "0x400465C")]
    private const int PIN_INPUT_CHECK = 10;
    [Token(Token = "0x400465D")]
    private const int PIN_OUTPUT_OK = 100;
    [Token(Token = "0x400465E")]
    private const int PIN_OUTPUT_NG = 110;
    [Token(Token = "0x400465F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string mPrefabPath;
    [Token(Token = "0x4004660")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool mConfirm;
    [Token(Token = "0x4004661")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    private bool mExit;
    [Token(Token = "0x4004662")]
    [FieldOffset(Offset = "0x1E")]
    [SerializeField]
    private bool mInit;

    [Token(Token = "0x6004FFB")]
    [Address(RVA = "0x124ECB0", Offset = "0x124DAB0", VA = "0x1124ECB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FFC")]
    [Address(RVA = "0x124EB20", Offset = "0x124D920", VA = "0x1124EB20")]
    private void CreateProgressWindow()
    {
    }

    [Token(Token = "0x6004FFD")]
    [Address(RVA = "0x124EA90", Offset = "0x124D890", VA = "0x1124EA90")]
    private void AutoRepeatProgressReset()
    {
    }

    [Token(Token = "0x6004FFE")]
    [Address(RVA = "0x124EEF0", Offset = "0x124DCF0", VA = "0x1124EEF0")]
    public FlowNode_AutoRepeatQuestWindowRoot()
    {
    }
  }
}
