// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SaveSelectedQuestId
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001699")]
  [FlowNode.Pin(21, "Failed", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/PlayerPrefs/SaveSelectedQuestId")]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "Success", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_SaveSelectedQuestId : FlowNode
  {
    [Token(Token = "0x400521F")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005220")]
    private const int PIN_OUT_SUCCESS = 11;
    [Token(Token = "0x4005221")]
    private const int PIN_OUT_FAILED = 21;
    [Token(Token = "0x4005222")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string mKeyName;

    [Token(Token = "0x6005CAA")]
    [Address(RVA = "0x130EC90", Offset = "0x130DA90", VA = "0x1130EC90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CAB")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SaveSelectedQuestId()
    {
    }
  }
}
