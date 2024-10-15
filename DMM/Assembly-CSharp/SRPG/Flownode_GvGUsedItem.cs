// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_GvGUsedItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20016F8")]
  [FlowNode.Pin(103, "Used Item", FlowNode.PinTypes.Output, 103)]
  [FlowNode.NodeType("GvG/GvGUsedItem", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Ok", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Start Check", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "Cancel", FlowNode.PinTypes.Output, 102)]
  public class Flownode_GvGUsedItem : FlowNode
  {
    [Token(Token = "0x40052ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Win_Btn_YN_FL_C YesNoDialog;
    [Token(Token = "0x40052EE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject Parent;
    [Token(Token = "0x40052EF")]
    private const int PIN_INPUT_CHECK = 1;
    [Token(Token = "0x40052F0")]
    private const int PIN_OUTPUT_OK = 101;
    [Token(Token = "0x40052F1")]
    private const int PIN_OUTPUT_CANCEL = 102;
    [Token(Token = "0x40052F2")]
    private const int PIN_OUTPUT_NOITEM = 103;
    [Token(Token = "0x40052F3")]
    [FieldOffset(Offset = "0x20")]
    private GameObject dialogObject;

    [Token(Token = "0x6005DAD")]
    [Address(RVA = "0x132E890", Offset = "0x132D690", VA = "0x1132E890", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005DAE")]
    [Address(RVA = "0x132E6C0", Offset = "0x132D4C0", VA = "0x1132E6C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005DAF")]
    [Address(RVA = "0x132E910", Offset = "0x132D710", VA = "0x1132E910")]
    private GameObject SetConfirmBox(
      string text,
      GameObject parent,
      UIUtility.DialogResultEvent okEventListener,
      UIUtility.DialogResultEvent cancelEventListener)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6005DB0")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_GvGUsedItem()
    {
    }
  }
}
