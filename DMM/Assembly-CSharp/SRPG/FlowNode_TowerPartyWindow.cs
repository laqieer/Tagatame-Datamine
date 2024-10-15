// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TowerPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200164B")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/TowerPartyWindow")]
  public class FlowNode_TowerPartyWindow : FlowNode_GUI
  {
    [Token(Token = "0x40050FE")]
    [FieldOffset(Offset = "0x54")]
    public PartyWindow2.EditPartyTypes PartyType;
    [Token(Token = "0x40050FF")]
    [FieldOffset(Offset = "0x58")]
    public bool ShowQuestInfo;
    [Token(Token = "0x4005100")]
    [FieldOffset(Offset = "0x5C")]
    public FlowNode_TowerPartyWindow.TriBool BackButton;
    [Token(Token = "0x4005101")]
    [FieldOffset(Offset = "0x60")]
    public FlowNode_TowerPartyWindow.TriBool ForwardButton;
    [Token(Token = "0x4005102")]
    [FieldOffset(Offset = "0x64")]
    public FlowNode_TowerPartyWindow.TriBool ShowRaidInfo;

    [Token(Token = "0x6005B9E")]
    [Address(RVA = "0x130FB60", Offset = "0x130E960", VA = "0x1130FB60", Slot = "15")]
    protected override void OnInstanceCreate()
    {
    }

    [Token(Token = "0x6005B9F")]
    [Address(RVA = "0x130FA60", Offset = "0x130E860", VA = "0x1130FA60", Slot = "17")]
    protected override void OnCreatePinActive()
    {
    }

    [Token(Token = "0x6005BA0")]
    [Address(RVA = "0x130FC40", Offset = "0x130EA40", VA = "0x1130FC40")]
    public FlowNode_TowerPartyWindow()
    {
    }

    [Token(Token = "0x200164C")]
    public enum TriBool
    {
      [Token(Token = "0x4005104")] Unchanged,
      [Token(Token = "0x4005105")] False,
      [Token(Token = "0x4005106")] True,
    }
  }
}
