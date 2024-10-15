// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_MultiTowerSkipFloorConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017B0")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("MultiPlay/MultiTower/SkipFloorConfirm", 32741)]
  [FlowNode.Pin(1, "Open Popup", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Skipped", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "Lack Coins", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(110, "Canceld", FlowNode.PinTypes.Output, 110)]
  public class FlowNode_MP_MultiTowerSkipFloorConfirm : FlowNode
  {
    [Token(Token = "0x4005558")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string ResourcePath;
    [Token(Token = "0x4005559")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool systemModal;
    [Token(Token = "0x400555A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int systemModalPriority;
    [Token(Token = "0x400555B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject parent;
    [Token(Token = "0x400555C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string parentName;
    [Token(Token = "0x400555D")]
    private const int PIN_IN_OPEN = 1;
    [Token(Token = "0x400555E")]
    private const int PIN_OUT_OK = 101;
    [Token(Token = "0x400555F")]
    private const int PIN_OUT_LACK_COINS = 102;
    [Token(Token = "0x4005560")]
    private const int PIN_OUT_CANCEL = 110;
    [Token(Token = "0x4005561")]
    [FieldOffset(Offset = "0x2C")]
    private GameObject mGoPopup;
    [Token(Token = "0x4005562")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsLackCoins;

    [Token(Token = "0x6006010")]
    [Address(RVA = "0x134DFF0", Offset = "0x134CDF0", VA = "0x1134DFF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006011")]
    [Address(RVA = "0x134E350", Offset = "0x134D150", VA = "0x1134E350")]
    private void OnConfirmOK(GameObject go)
    {
    }

    [Token(Token = "0x6006012")]
    [Address(RVA = "0x134E320", Offset = "0x134D120", VA = "0x1134E320")]
    private void OnConfirmCancel(GameObject go)
    {
    }

    [Token(Token = "0x6006013")]
    [Address(RVA = "0x134DC90", Offset = "0x134CA90", VA = "0x1134DC90")]
    private GameObject CreatePrefab(
      string resource_path,
      string text,
      int have_coin,
      UIUtility.DialogResultEvent ok_event_listener,
      UIUtility.DialogResultEvent cancel_event_listener,
      GameObject go_parent,
      bool system_modal,
      int system_modal_priority)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6006014")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_MultiTowerSkipFloorConfirm()
    {
    }
  }
}
