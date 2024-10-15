// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAutoRepeatQuestDataSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012EE")]
  [FlowNode.Pin(10, "Request(自動周回設定保存)", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "Success(自動周回設定保存)", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("AutoRepeatQuest/ReqStartSet", 32741)]
  public class FlowNode_ReqAutoRepeatQuestDataSet : FlowNode_Network
  {
    [Token(Token = "0x4004672")]
    private const int PIN_INPUT_REQUEST = 10;
    [Token(Token = "0x4004673")]
    private const int PIN_OUTPUT_SUCCESS = 110;
    [Token(Token = "0x4004674")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AutoRepeatQuestStart Target;

    [Token(Token = "0x6005014")]
    [Address(RVA = "0x1252690", Offset = "0x1251490", VA = "0x11252690", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005015")]
    [Address(RVA = "0x1252910", Offset = "0x1251710", VA = "0x11252910")]
    private bool Request() => new bool();

    [Token(Token = "0x6005016")]
    [Address(RVA = "0x1252A70", Offset = "0x1251870", VA = "0x11252A70")]
    private void Success()
    {
    }

    [Token(Token = "0x6005017")]
    [Address(RVA = "0x1252800", Offset = "0x1251600", VA = "0x11252800", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005018")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAutoRepeatQuestDataSet()
    {
    }
  }
}
