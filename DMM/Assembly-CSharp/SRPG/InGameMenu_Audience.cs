// Decompiled with JetBrains decompiler
// Type: SRPG.InGameMenu_Audience
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002645")]
  [AddComponentMenu("UI/InGameMenu_Audience")]
  [FlowNode.Pin(100, "Close Give Up Window", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Give Up", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Start Debug", FlowNode.PinTypes.Input, 0)]
  public class InGameMenu_Audience : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B2C2")]
    public const int PINID_DEBUG = 1;
    [Token(Token = "0x400B2C3")]
    public const int PINID_GIVEUP = 2;
    [Token(Token = "0x400B2C4")]
    public const int PINID_CLOSE_GIVEUP_WINDOW = 100;
    [Token(Token = "0x400B2C5")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ExitButton;
    [Token(Token = "0x400B2C6")]
    [FieldOffset(Offset = "0x10")]
    public GenericSlot[] Units_1P;
    [Token(Token = "0x400B2C7")]
    [FieldOffset(Offset = "0x14")]
    public GenericSlot[] Units_2P;
    [Token(Token = "0x400B2C8")]
    [FieldOffset(Offset = "0x18")]
    public Text Name1P;
    [Token(Token = "0x400B2C9")]
    [FieldOffset(Offset = "0x1C")]
    public Text Name2P;
    [Token(Token = "0x400B2CA")]
    [FieldOffset(Offset = "0x20")]
    public Text TotalAtk1P;
    [Token(Token = "0x400B2CB")]
    [FieldOffset(Offset = "0x24")]
    public Text TotalAtk2P;
    [Token(Token = "0x400B2CC")]
    [FieldOffset(Offset = "0x28")]
    public Text Lv1P;
    [Token(Token = "0x400B2CD")]
    [FieldOffset(Offset = "0x2C")]
    public Text Lv2P;
    [Token(Token = "0x400B2CE")]
    [FieldOffset(Offset = "0x30")]
    private GameObject mExitWindow;
    [Token(Token = "0x400B2CF")]
    [FieldOffset(Offset = "0x34")]
    private List<InGameMenu_Audience.DispUnit> mDispUnitList;
    [Token(Token = "0x400B2D0")]
    [FieldOffset(Offset = "0x38")]
    private uint FrameCtr;

    [Token(Token = "0x600AAD5")]
    [Address(RVA = "0x6E3050", Offset = "0x6E1E50", VA = "0x106E3050")]
    private void Start()
    {
    }

    [Token(Token = "0x600AAD6")]
    [Address(RVA = "0x6E2D20", Offset = "0x6E1B20", VA = "0x106E2D20")]
    private Unit FindDynamicTransformUnit(Unit act_unit) => (Unit) null;

    [Token(Token = "0x600AAD7")]
    [Address(RVA = "0x6E2DC0", Offset = "0x6E1BC0", VA = "0x106E2DC0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AAD8")]
    [Address(RVA = "0x6E3030", Offset = "0x6E1E30", VA = "0x106E3030")]
    private void OnQuestEnd()
    {
    }

    [Token(Token = "0x600AAD9")]
    [Address(RVA = "0x6E2BA0", Offset = "0x6E19A0", VA = "0x106E2BA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AADA")]
    [Address(RVA = "0x6E2F00", Offset = "0x6E1D00", VA = "0x106E2F00")]
    private void OnGiveUp(GameObject go)
    {
    }

    [Token(Token = "0x600AADB")]
    [Address(RVA = "0x6E36D0", Offset = "0x6E24D0", VA = "0x106E36D0")]
    private void Update()
    {
    }

    [Token(Token = "0x600AADC")]
    [Address(RVA = "0x6E38C0", Offset = "0x6E26C0", VA = "0x106E38C0")]
    public InGameMenu_Audience()
    {
    }

    [Token(Token = "0x2002646")]
    private class DispUnit
    {
      [Token(Token = "0x400B2D1")]
      [FieldOffset(Offset = "0x8")]
      public GenericSlot mSlot;
      [Token(Token = "0x400B2D2")]
      [FieldOffset(Offset = "0xC")]
      public Unit mCurrentUnit;
      [Token(Token = "0x400B2D3")]
      [FieldOffset(Offset = "0x10")]
      public Unit mActiveUnit;
      [Token(Token = "0x400B2D4")]
      [FieldOffset(Offset = "0x14")]
      public GameObject mButtonObj;

      [Token(Token = "0x600AADD")]
      [Address(RVA = "0x6DE410", Offset = "0x6DD210", VA = "0x106DE410")]
      public DispUnit(
        GenericSlot slot,
        Unit current_unit,
        Unit active_unit,
        GameObject button_obj)
      {
      }
    }
  }
}
