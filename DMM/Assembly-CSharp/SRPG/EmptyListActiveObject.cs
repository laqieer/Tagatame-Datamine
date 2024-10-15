// Decompiled with JetBrains decompiler
// Type: SRPG.EmptyListActiveObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002347")]
  [FlowNode.Pin(10, "Refreshed", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/EmptyListActiveObject")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  public class EmptyListActiveObject : MonoBehaviour, IFlowInterface, IGameParameter
  {
    [Token(Token = "0x4009DF2")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x4009DF3")]
    private const int PIN_OUT_EXIT = 10;
    [Token(Token = "0x4009DF4")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("中身が入る親オブジェクト(指定しなければ自分自身)")]
    [SerializeField]
    private Transform TargetListParent;
    [Token(Token = "0x4009DF5")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("リストが空のときに表示したいゲームオブジェクト")]
    [SerializeField]
    private GameObject EmptyTextObject;
    [Token(Token = "0x4009DF6")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("常に監視するか？")]
    [SerializeField]
    private bool AlwaysCheck;
    [Token(Token = "0x4009DF7")]
    [FieldOffset(Offset = "0x15")]
    [HeaderBar("LText強制初期化するか")]
    [SerializeField]
    private bool IsForceTextInit;
    [Token(Token = "0x4009DF8")]
    [FieldOffset(Offset = "0x16")]
    private bool mNeedCheck;

    [Token(Token = "0x6009803")]
    [Address(RVA = "0x5AA7C0", Offset = "0x5A95C0", VA = "0x105AA7C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009804")]
    [Address(RVA = "0x5AAC00", Offset = "0x5A9A00", VA = "0x105AAC00", Slot = "5")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x6009805")]
    [Address(RVA = "0x5AA790", Offset = "0x5A9590", VA = "0x105AA790", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009806")]
    [Address(RVA = "0x5AAA00", Offset = "0x5A9800", VA = "0x105AAA00")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6009807")]
    [Address(RVA = "0x5AA950", Offset = "0x5A9750", VA = "0x105AA950")]
    public void ForceUpdateText()
    {
    }

    [Token(Token = "0x6009808")]
    [Address(RVA = "0x5AAC10", Offset = "0x5A9A10", VA = "0x105AAC10")]
    public EmptyListActiveObject()
    {
    }
  }
}
