// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCollectEquipment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014C7")]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("FlowNode_ReqCollectEquipment", 32741)]
  public class FlowNode_ReqCollectEquipment : FlowNode_Network
  {
    [Token(Token = "0x4004C3A")]
    private const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x4004C3B")]
    private const int PIN_OUT_SUCCESS = 100;
    [Token(Token = "0x4004C3C")]
    public const string KEY_IS_CONCEPT = "KEY_IS_CONCEPT";
    [Token(Token = "0x4004C3D")]
    public const string KEY_CONCEPT_LAST_IID = "KEY_CONCEPT_LAST_IID";
    [Token(Token = "0x4004C3E")]
    public const string KEY_IS_RUNE = "KEY_IS_RUNE";
    [Token(Token = "0x4004C3F")]
    public const string KEY_RUNE_LAST_IID = "KEY_RUNE_LAST_IID";
    [Token(Token = "0x4004C40")]
    public const string KEY_IS_CRYSTAL = "KEY_IS_CRYSTAL";
    [Token(Token = "0x4004C41")]
    public const string KEY_CRYSTAL_LAST_IID = "KEY_CRYSTAL_LAST_IID";
    [Token(Token = "0x4004C42")]
    [FieldOffset(Offset = "0x20")]
    public bool is_concept;
    [Token(Token = "0x4004C43")]
    [FieldOffset(Offset = "0x21")]
    public bool is_rune;
    [Token(Token = "0x4004C44")]
    [FieldOffset(Offset = "0x22")]
    public bool is_crystal;
    [Token(Token = "0x4004C45")]
    [FieldOffset(Offset = "0x24")]
    private SerializeValueList valueList;
    [Token(Token = "0x4004C46")]
    [FieldOffset(Offset = "0x28")]
    private long concept_last_iid;
    [Token(Token = "0x4004C47")]
    [FieldOffset(Offset = "0x30")]
    private long rune_last_iid;
    [Token(Token = "0x4004C48")]
    [FieldOffset(Offset = "0x38")]
    private long crystal_last_iid;

    [Token(Token = "0x600568F")]
    [Address(RVA = "0x12C0570", Offset = "0x12BF370", VA = "0x112C0570", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005690")]
    [Address(RVA = "0x12C0DC0", Offset = "0x12BFBC0", VA = "0x112C0DC0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005691")]
    [Address(RVA = "0x12C06D0", Offset = "0x12BF4D0", VA = "0x112C06D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005692")]
    [Address(RVA = "0x12C0B80", Offset = "0x12BF980", VA = "0x112C0B80")]
    private void SetReqParam()
    {
    }

    [Token(Token = "0x6005693")]
    [Address(RVA = "0x12C0E30", Offset = "0x12BFC30", VA = "0x112C0E30")]
    public FlowNode_ReqCollectEquipment()
    {
    }
  }
}
