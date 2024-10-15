// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PremiumSpriteSheet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001463")]
  [FlowNode.NodeType("Common/SpriteSheet", 32741)]
  [FlowNode.Pin(0, "show", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "output", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_PremiumSpriteSheet : FlowNode
  {
    [Token(Token = "0x4004B6B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string m_SpriteSheetName;
    [Token(Token = "0x4004B6C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image m_Image;

    [Token(Token = "0x600553E")]
    [Address(RVA = "0x1299550", Offset = "0x1298350", VA = "0x11299550", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600553F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PremiumSpriteSheet()
    {
    }
  }
}
