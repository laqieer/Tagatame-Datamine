// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckStamina
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200138B")]
  [FlowNode.NodeType("System/Check/CheckStamina", 32741)]
  [FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Pass", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(101, "Restore", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(102, "IAP", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(103, "HEALAP", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_CheckStamina : FlowNode
  {
    [Token(Token = "0x4004836")]
    public const int PINID_IN = 0;
    [Token(Token = "0x4004837")]
    public const int PINID_PASS = 100;
    [Token(Token = "0x4004838")]
    public const int PINID_RESTORE = 101;
    [Token(Token = "0x4004839")]
    public const int PINID_IAP = 102;
    [Token(Token = "0x400483A")]
    public const int PINID_HEALAP = 103;
    [Token(Token = "0x400483B")]
    [FieldOffset(Offset = "0x18")]
    public string DebugQuestID;

    [Token(Token = "0x60051EF")]
    [Address(RVA = "0x126D110", Offset = "0x126BF10", VA = "0x1126D110", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x170008FA")]
    private int RestoreCost
    {
      [Token(Token = "0x60051F0"), Address(RVA = "0x126D550", Offset = "0x126C350", VA = "0x1126D550")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170008FB")]
    private QuestParam SelectedQuest
    {
      [Token(Token = "0x60051F1"), Address(RVA = "0x126D5A0", Offset = "0x126C3A0", VA = "0x1126D5A0")] get
      {
        return (QuestParam) null;
      }
    }

    [Token(Token = "0x60051F2")]
    [Address(RVA = "0x126D370", Offset = "0x126C170", VA = "0x1126D370")]
    private void OnRestoreStamina(GameObject go)
    {
    }

    [Token(Token = "0x60051F3")]
    [Address(RVA = "0x126D300", Offset = "0x126C100", VA = "0x1126D300")]
    private void OnBuyCoin(GameObject go)
    {
    }

    [Token(Token = "0x60051F4")]
    [Address(RVA = "0x126D320", Offset = "0x126C120", VA = "0x1126D320")]
    private void OnCancel(GameObject go)
    {
    }

    [Token(Token = "0x60051F5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckStamina()
    {
    }
  }
}
