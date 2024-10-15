// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TutorialMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001890")]
  [AddComponentMenu("")]
  [FlowNode.Pin(102, "OPEND", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1, "CREATE", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Tutorial/Mask", 32741)]
  [FlowNode.Pin(101, "DESTORY", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_TutorialMask : FlowNode
  {
    [Token(Token = "0x400581D")]
    private const int PIN_IN_CREATE = 1;
    [Token(Token = "0x400581E")]
    private const int PIN_OUT_DESTORY = 101;
    [Token(Token = "0x400581F")]
    private const int PIN_OUT_OPEND = 102;
    [Token(Token = "0x4005820")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_TutorialMask.eComponentId ComponentId;
    [Token(Token = "0x4005821")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject Mask;
    [Token(Token = "0x4005822")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float NoResponseTime;
    [Token(Token = "0x4005823")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string MaskPath;
    [Token(Token = "0x4005824")]
    [FieldOffset(Offset = "0x28")]
    private Vector3 mWorldPosition;
    [Token(Token = "0x4005825")]
    [FieldOffset(Offset = "0x34")]
    private TutorialMask.eActionType mActionType;
    [Token(Token = "0x4005826")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsWorld2Screen;
    [Token(Token = "0x4005827")]
    [FieldOffset(Offset = "0x3C")]
    private string mText;
    [Token(Token = "0x4005828")]
    [FieldOffset(Offset = "0x40")]
    private Vector2 mSize;

    [Token(Token = "0x60062E6")]
    [Address(RVA = "0x316150", Offset = "0x314F50", VA = "0x10316150", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60062E7")]
    [Address(RVA = "0x316230", Offset = "0x315030", VA = "0x10316230")]
    public void Setup(
      TutorialMask.eActionType act_type,
      Vector3 world_pos,
      bool is_world2screen,
      string text = null)
    {
    }

    [Token(Token = "0x60062E8")]
    [Address(RVA = "0x316210", Offset = "0x315010", VA = "0x10316210")]
    public void SetupMaskSize(float width, float height)
    {
    }

    [Token(Token = "0x60062E9")]
    [Address(RVA = "0x3160E0", Offset = "0x314EE0", VA = "0x103160E0")]
    private IEnumerator CreateMask() => (IEnumerator) null;

    [Token(Token = "0x60062EA")]
    [Address(RVA = "0x3161F0", Offset = "0x314FF0", VA = "0x103161F0")]
    private void OnOpendMask()
    {
    }

    [Token(Token = "0x60062EB")]
    [Address(RVA = "0x3161D0", Offset = "0x314FD0", VA = "0x103161D0")]
    private void OnDestroyMask()
    {
    }

    [Token(Token = "0x60062EC")]
    [Address(RVA = "0x316290", Offset = "0x315090", VA = "0x10316290")]
    public FlowNode_TutorialMask()
    {
    }

    [Token(Token = "0x2001891")]
    public enum eComponentId
    {
      [Token(Token = "0x400582A")] MOVE_UNIT,
      [Token(Token = "0x400582B")] ATTACK_TARGET_DESC,
      [Token(Token = "0x400582C")] NORMAL_ATTACK_DESC,
      [Token(Token = "0x400582D")] ABILITY_DESC,
      [Token(Token = "0x400582E")] TAP_NORMAL_ATTACK,
      [Token(Token = "0x400582F")] EXEC_NORMAL_ATTACK,
      [Token(Token = "0x4005830")] SELECT_DIR,
      [Token(Token = "0x4005831")] CLOSE_BATTLE_INFO,
    }
  }
}
