// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsClickableButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200140B")]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "Is Not Clickable", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(2, "Is Clickable", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("UI/IsClickableButton", 58751)]
  [FlowNode.Pin(10, "Error", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_IsClickableButton : FlowNode
  {
    [Token(Token = "0x4004A39")]
    private const int PININ_CHECK = 1;
    [Token(Token = "0x4004A3A")]
    private const int PINOUT_IS_CLICKABLE = 2;
    [Token(Token = "0x4004A3B")]
    private const int PINOUT_IS_NOT_CLICKABLE = 3;
    [Token(Token = "0x4004A3C")]
    private const int PINOUT_ERROR = 10;
    [Token(Token = "0x4004A3D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Canvas targetCanvas;
    [Token(Token = "0x4004A3E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button targetButton;
    [Token(Token = "0x4004A3F")]
    [FieldOffset(Offset = "0x20")]
    private RectTransform targetRect;
    [Token(Token = "0x4004A40")]
    [FieldOffset(Offset = "0x24")]
    private List<RaycastResult> raycastResults;

    [Token(Token = "0x60053D0")]
    [Address(RVA = "0x1285600", Offset = "0x1284400", VA = "0x11285600", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053D1")]
    [Address(RVA = "0x12858F0", Offset = "0x12846F0", VA = "0x112858F0")]
    public FlowNode_IsClickableButton()
    {
    }
  }
}
