// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ShowTips
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200162F")]
  [FlowNode.NodeType("Tips/ShowTips", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ShowTips : FlowNode_GUI
  {
    [Token(Token = "0x4005060")]
    private const int PIN_ID_IN = 1;
    [Token(Token = "0x4005061")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private string Tips;

    [Token(Token = "0x6005B21")]
    [Address(RVA = "0x12FCC20", Offset = "0x12FBA20", VA = "0x112FCC20", Slot = "17")]
    protected override void OnCreatePinActive()
    {
    }

    [Token(Token = "0x6005B22")]
    [Address(RVA = "0x126B2F0", Offset = "0x126A0F0", VA = "0x1126B2F0")]
    public FlowNode_ShowTips()
    {
    }
  }
}
