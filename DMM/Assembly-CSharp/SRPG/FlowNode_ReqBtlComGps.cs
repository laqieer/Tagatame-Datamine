// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlComGps
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014AA")]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "エリアクエスト無し", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(2, "Reset to Title", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(200, "StartMulti", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqBtlCom/ReqBtlComGps", 32741)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqBtlComGps : FlowNode_Network
  {
    [Token(Token = "0x600562C")]
    [Address(RVA = "0x12BC430", Offset = "0x12BB230", VA = "0x112BC430", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600562D")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600562E")]
    [Address(RVA = "0x1273D70", Offset = "0x1272B70", VA = "0x11273D70")]
    private void SuccessNotQuest()
    {
    }

    [Token(Token = "0x600562F")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005630")]
    [Address(RVA = "0x12BC620", Offset = "0x12BB420", VA = "0x112BC620", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005631")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlComGps()
    {
    }

    [Token(Token = "0x20014AB")]
    public class JSON_ReqBtlComGpsResponse
    {
      [Token(Token = "0x4004C08")]
      [FieldOffset(Offset = "0x8")]
      public JSON_QuestProgress[] quests;

      [Token(Token = "0x6005632")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ReqBtlComGpsResponse()
      {
      }
    }
  }
}
