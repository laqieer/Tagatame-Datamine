// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_OnEndEditRoomID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D8")]
  [FlowNode.NodeType("MultiPlay/Room/OnEndEditRoomID", 58751)]
  [FlowNode.Pin(1, "Edited", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_MP_OnEndEditRoomID : FlowNodePersistent
  {
    [Token(Token = "0x40055CC")]
    private const int PIN_OUT_ON_EDITED = 1;
    [Token(Token = "0x40055CD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [FlowNode.ShowInInfo]
    [FlowNode.DropTarget(typeof (InputField), true)]
    public InputField Target;

    [Token(Token = "0x6006094")]
    [Address(RVA = "0x134ECA0", Offset = "0x134DAA0", VA = "0x1134ECA0")]
    private void Start()
    {
    }

    [Token(Token = "0x6006095")]
    [Address(RVA = "0x134EB70", Offset = "0x134D970", VA = "0x1134EB70", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6006096")]
    [Address(RVA = "0x134EC00", Offset = "0x134DA00", VA = "0x1134EC00")]
    private void OnEndEdit(InputField field)
    {
    }

    [Token(Token = "0x6006097")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_OnEndEditRoomID()
    {
    }
  }
}
