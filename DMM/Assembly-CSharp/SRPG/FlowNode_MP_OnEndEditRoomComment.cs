// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_OnEndEditRoomComment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D7")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Edited", FlowNode.PinTypes.Output, 1)]
  [FlowNode.NodeType("MultiPlay/Room/OnEndEditRoomComment", 58751)]
  public class FlowNode_MP_OnEndEditRoomComment : FlowNodePersistent
  {
    [Token(Token = "0x40055CA")]
    private const int PIN_OUT_ON_EDITED = 1;
    [Token(Token = "0x40055CB")]
    [FieldOffset(Offset = "0x18")]
    [FlowNode.ShowInInfo]
    [SerializeField]
    [FlowNode.DropTarget(typeof (InputField), true)]
    public InputField Target;

    [Token(Token = "0x600608E")]
    [Address(RVA = "0x134E8C0", Offset = "0x134D6C0", VA = "0x1134E8C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600608F")]
    [Address(RVA = "0x134E700", Offset = "0x134D500", VA = "0x1134E700", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6006090")]
    [Address(RVA = "0x134E790", Offset = "0x134D590", VA = "0x1134E790")]
    private void OnEndEdit(InputField field)
    {
    }

    [Token(Token = "0x6006091")]
    [Address(RVA = "0x134E590", Offset = "0x134D390", VA = "0x1134E590")]
    private string GetComment() => (string) null;

    [Token(Token = "0x6006092")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_OnEndEditRoomComment()
    {
    }
  }
}
