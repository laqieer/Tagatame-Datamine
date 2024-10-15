// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqInvalidSkillSetList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001744")]
  [FlowNode.NodeType("FlowNode_ReqInvalidSkillSetList", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqInvalidSkillSetList : FlowNode_Network
  {
    [Token(Token = "0x40053AA")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x40053AB")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x40053AC")]
    public const string KEY_INVALIDSKILL_UNIT_LIST = "KEY_INVALIDSKILL_UNIT_LIST";
    [Token(Token = "0x40053AD")]
    public const string KEY_INVALIDSKILLSETLIST_APPLY_TYPE = "KEY_INVALIDSKILLSETLIST_APPLY_TYPE";
    [Token(Token = "0x40053AE")]
    public const string KEY_EINVALIDSKILL_APPLYTYPE = "KEY_EINVALIDSKILL_APPLYTYPE";
    [Token(Token = "0x40053AF")]
    [FieldOffset(Offset = "0x20")]
    private EInvalidSkillApplyType apply_type;

    [Token(Token = "0x6005E98")]
    [Address(RVA = "0x133B400", Offset = "0x133A200", VA = "0x1133B400", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6005E99")]
    [Address(RVA = "0x133BCC0", Offset = "0x133AAC0", VA = "0x1133BCC0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005E9A")]
    [Address(RVA = "0x133B930", Offset = "0x133A730", VA = "0x1133B930", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005E9B")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqInvalidSkillSetList()
    {
    }
  }
}
