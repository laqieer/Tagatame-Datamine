// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_UpdateItemBind
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001665")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/Util/BindItem", 32741)]
  [FlowNode.Pin(0, "Bind", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Binded", FlowNode.PinTypes.Output, 1)]
  public class FlowNode_UpdateItemBind : FlowNode
  {
    [Token(Token = "0x4005163")]
    private const int PIN_IN_BIND = 0;
    [Token(Token = "0x4005164")]
    private const int PIN_OTN_BINDED = 1;
    [Token(Token = "0x4005165")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string VariableName;
    [Token(Token = "0x4005166")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private FlowNode_UpdateItemBind.SelectBindType BindType;
    [Token(Token = "0x4005167")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FlowNode_UpdateItemBind.SelectUseType UseType;

    [Token(Token = "0x6005C06")]
    [Address(RVA = "0x1314CF0", Offset = "0x1313AF0", VA = "0x11314CF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C07")]
    [Address(RVA = "0x1314AB0", Offset = "0x13138B0", VA = "0x11314AB0")]
    private void Bind()
    {
    }

    [Token(Token = "0x6005C08")]
    [Address(RVA = "0x1314D20", Offset = "0x1313B20", VA = "0x11314D20")]
    public FlowNode_UpdateItemBind()
    {
    }

    [Token(Token = "0x2001666")]
    public enum SelectBindType
    {
      [Token(Token = "0x4005169")] ItemParam,
      [Token(Token = "0x400516A")] ItemData,
    }

    [Token(Token = "0x2001667")]
    public enum SelectUseType
    {
      [Token(Token = "0x400516C")] UseVariable,
    }
  }
}
