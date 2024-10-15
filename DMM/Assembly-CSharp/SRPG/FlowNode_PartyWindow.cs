// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200144B")]
  [FlowNode.NodeType("UI/PartyWindow")]
  [AddComponentMenu("")]
  public class FlowNode_PartyWindow : FlowNode_GUI
  {
    [Token(Token = "0x4004B08")]
    [FieldOffset(Offset = "0x54")]
    public PartyWindow2.EditPartyTypes PartyType;
    [Token(Token = "0x4004B09")]
    [FieldOffset(Offset = "0x58")]
    public bool ShowQuestInfo;
    [Token(Token = "0x4004B0A")]
    [FieldOffset(Offset = "0x59")]
    public bool UseQuest;
    [Token(Token = "0x4004B0B")]
    [FieldOffset(Offset = "0x5A")]
    public bool ForceRefresh;
    [Token(Token = "0x4004B0C")]
    [FieldOffset(Offset = "0x5C")]
    public FlowNode_PartyWindow.TriBool BackButton;
    [Token(Token = "0x4004B0D")]
    [FieldOffset(Offset = "0x60")]
    public FlowNode_PartyWindow.TriBool ForwardButton;
    [Token(Token = "0x4004B0E")]
    [FieldOffset(Offset = "0x64")]
    public FlowNode_PartyWindow.TriBool ShowRaidInfo;
    [Token(Token = "0x4004B0F")]
    [FieldOffset(Offset = "0x68")]
    public FlowNode_PartyWindow.TriBool EnableTeamAssign;
    [Token(Token = "0x4004B10")]
    [FieldOffset(Offset = "0x6C")]
    public FlowNode_PartyWindow.TriBool IsShowDownloadPopup;

    [Token(Token = "0x60054CC")]
    [Address(RVA = "0x1293820", Offset = "0x1292620", VA = "0x11293820", Slot = "15")]
    protected override void OnInstanceCreate()
    {
    }

    [Token(Token = "0x60054CD")]
    [Address(RVA = "0x1293740", Offset = "0x1292540", VA = "0x11293740", Slot = "17")]
    protected override void OnCreatePinActive()
    {
    }

    [Token(Token = "0x60054CE")]
    [Address(RVA = "0x1293690", Offset = "0x1292490", VA = "0x11293690")]
    private void OffCanvas(PartyWindow2 pw)
    {
    }

    [Token(Token = "0x60054CF")]
    [Address(RVA = "0x1293940", Offset = "0x1292740", VA = "0x11293940")]
    public FlowNode_PartyWindow()
    {
    }

    [Token(Token = "0x200144C")]
    public enum TriBool
    {
      [Token(Token = "0x4004B12")] Unchanged,
      [Token(Token = "0x4004B13")] False,
      [Token(Token = "0x4004B14")] True,
    }
  }
}
