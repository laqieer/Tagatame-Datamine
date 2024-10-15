// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerSkipFloorSel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002726")]
  [FlowNode.Pin(1, "有効化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "セレクトした", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "キャンセル", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/Multi/MultiTower/MultiTowerSkipFloorSel")]
  public class MultiTowerSkipFloorSel : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B87D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Window;
    [Token(Token = "0x400B87E")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    [SerializeField]
    private SRPG_ScrollRect ScrollRectController;
    [Token(Token = "0x400B87F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject GoSelParent;
    [Token(Token = "0x400B880")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MultiTowerSkipFloorItem SelBaseItem;
    [Token(Token = "0x400B881")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Space(5f)]
    private SRPG_Button CancelBtn;
    [Token(Token = "0x400B882")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B883")]
    private const int PIN_OUT_SELECTED = 101;
    [Token(Token = "0x400B884")]
    private const int PIN_OUT_CANCEL = 102;
    [Token(Token = "0x400B885")]
    [FieldOffset(Offset = "0x0")]
    private static MultiTowerSkipFloorSel mInstance;
    [Token(Token = "0x400B886")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public int SelectFloor;

    [Token(Token = "0x1700183E")]
    public static MultiTowerSkipFloorSel Instance
    {
      [Token(Token = "0x600AF85"), Address(RVA = "0x739C40", Offset = "0x738A40", VA = "0x10739C40")] get
      {
        return (MultiTowerSkipFloorSel) null;
      }
    }

    [Token(Token = "0x600AF86")]
    [Address(RVA = "0x739B40", Offset = "0x738940", VA = "0x10739B40")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600AF87")]
    [Address(RVA = "0x739AC0", Offset = "0x7388C0", VA = "0x10739AC0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600AF88")]
    [Address(RVA = "0x739490", Offset = "0x738290", VA = "0x10739490")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AF89")]
    [Address(RVA = "0x739500", Offset = "0x738300", VA = "0x10739500")]
    private void Init()
    {
    }

    [Token(Token = "0x600AF8A")]
    [Address(RVA = "0x739BC0", Offset = "0x7389C0", VA = "0x10739BC0")]
    private void OnSelectFloor(MultiTowerSkipFloorItem sfi)
    {
    }

    [Token(Token = "0x600AF8B")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x600AF8C")]
    [Address(RVA = "0x739470", Offset = "0x738270", VA = "0x10739470", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AF8D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiTowerSkipFloorSel()
    {
    }
  }
}
