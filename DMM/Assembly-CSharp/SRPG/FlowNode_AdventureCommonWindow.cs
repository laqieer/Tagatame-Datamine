// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdventureCommonWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D5")]
  [FlowNode.NodeType("Adventure/AdventureCommonWindow", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_AdventureCommonWindow : FlowNode_GUIEx
  {
    [Token(Token = "0x400462C")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private FlowNode_AdventureCommonWindow.eAdventureWindowType WindowType;

    [Token(Token = "0x6004FC7")]
    [Address(RVA = "0x1249D20", Offset = "0x1248B20", VA = "0x11249D20", Slot = "15")]
    protected override void OnInstanceCreate()
    {
    }

    [Token(Token = "0x6004FC8")]
    [Address(RVA = "0x1249F60", Offset = "0x1248D60", VA = "0x11249F60")]
    public FlowNode_AdventureCommonWindow()
    {
    }

    [Token(Token = "0x20012D6")]
    public enum eAdventureWindowType
    {
      [Token(Token = "0x400462E")] NONE,
      [Token(Token = "0x400462F")] CHECK_SAVE_ITEM,
      [Token(Token = "0x4004630")] ADVENTURE_START,
      [Token(Token = "0x4004631")] ADVENTURE_END_ADD_AREA,
      [Token(Token = "0x4004632")] ADVENTURE_END_ADD_PARTY,
      [Token(Token = "0x4004633")] ADVENTURE_CANCEL_CHECK,
      [Token(Token = "0x4004634")] ADVENTURE_CANCEL_CONNECT_END,
      [Token(Token = "0x4004635")] ADVENTURE_NOT_START,
      [Token(Token = "0x4004636")] ADVENTURE_RECOMMEND_CHECK,
    }
  }
}
