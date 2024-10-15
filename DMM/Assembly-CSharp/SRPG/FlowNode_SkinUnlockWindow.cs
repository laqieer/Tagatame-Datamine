// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SkinUnlockWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001630")]
  [FlowNode.Pin(1, "Closed", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("UI/SkinUnlockWindow", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("")]
  public class FlowNode_SkinUnlockWindow : FlowNode
  {
    [Token(Token = "0x6005B23")]
    [Address(RVA = "0x12FCD20", Offset = "0x12FBB20", VA = "0x112FCD20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B24")]
    [Address(RVA = "0x12FCEF0", Offset = "0x12FBCF0", VA = "0x112FCEF0")]
    private IEnumerator OnOpenAsync(List<ItemParam> showItems) => (IEnumerator) null;

    [Token(Token = "0x6005B25")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SkinUnlockWindow()
    {
    }
  }
}
