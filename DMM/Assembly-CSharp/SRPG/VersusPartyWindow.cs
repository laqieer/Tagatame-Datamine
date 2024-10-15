// Decompiled with JetBrains decompiler
// Type: SRPG.VersusPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200274F")]
  [AddComponentMenu("UI/Multi/Versus/VersusPartyWindow")]
  [FlowNode.Pin(10200, "ユニット配置 失敗", FlowNode.PinTypes.Output, 10200)]
  [FlowNode.Pin(10010, "ユニット配置ボタン押下", FlowNode.PinTypes.Input, 10010)]
  [FlowNode.Pin(10100, "ユニット配置 成功", FlowNode.PinTypes.Output, 10100)]
  public class VersusPartyWindow : PartyWindow2
  {
    [Token(Token = "0x400B997")]
    [FieldOffset(Offset = "0x2D4")]
    [SerializeField]
    private GameObject mLimitUnit;
    [Token(Token = "0x400B998")]
    [FieldOffset(Offset = "0x2D8")]
    [SerializeField]
    private bool mRankmatchBack;
    [Token(Token = "0x400B999")]
    [FieldOffset(Offset = "0x2DC")]
    [SerializeField]
    private GameObject mDetailButton;
    [Token(Token = "0x400B99A")]
    [FieldOffset(Offset = "0x2E0")]
    [SerializeField]
    private GameObject mRankMatchWebButton;

    [Token(Token = "0x600B063")]
    [Address(RVA = "0x750360", Offset = "0x74F160", VA = "0x10750360", Slot = "6")]
    protected override void Init()
    {
    }

    [Token(Token = "0x600B064")]
    [Address(RVA = "0x750330", Offset = "0x74F130", VA = "0x10750330", Slot = "32")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x17001858")]
    protected override int AvailableMainMemberSlots
    {
      [Token(Token = "0x600B065"), Address(RVA = "0x750AB0", Offset = "0x74F8B0", VA = "0x10750AB0", Slot = "31")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B066")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "12")]
    protected override void OnItemSlotsChange()
    {
    }

    [Token(Token = "0x600B067")]
    [Address(RVA = "0x6CC510", Offset = "0x6CB310", VA = "0x106CC510", Slot = "14")]
    protected override void SetItemSlot(int slotIndex, ItemData item)
    {
    }

    [Token(Token = "0x600B068")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B069")]
    [Address(RVA = "0x7506E0", Offset = "0x74F4E0", VA = "0x107506E0", Slot = "23")]
    protected override void PostForwardPressed()
    {
    }

    [Token(Token = "0x600B06A")]
    [Address(RVA = "0x750530", Offset = "0x74F330", VA = "0x10750530")]
    private void OnClickEdit()
    {
    }

    [Token(Token = "0x600B06B")]
    [Address(RVA = "0x750A90", Offset = "0x74F890", VA = "0x10750A90")]
    public VersusPartyWindow()
    {
    }
  }
}
