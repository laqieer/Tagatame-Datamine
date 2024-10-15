// Decompiled with JetBrains decompiler
// Type: SRPG.AutoEquipConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002056")]
  [AddComponentMenu("UI/AutoEquipConceptCard")]
  [FlowNode.Pin(121, "装備する準備終了", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(101, "初期化完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(11, "装備する準備開始", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(111, "詳細表示", FlowNode.PinTypes.Output, 111)]
  public class AutoEquipConceptCard : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008B06")]
    private const int PIN_IN_INIT = 0;
    [Token(Token = "0x4008B07")]
    private const int PIN_IN_EQUIP = 11;
    [Token(Token = "0x4008B08")]
    private const int PIN_OUT_INIT = 101;
    [Token(Token = "0x4008B09")]
    private const int PIN_OUT_SHOW_DETAIL = 111;
    [Token(Token = "0x4008B0A")]
    private const int PIN_OUT_EQUIP = 121;
    [Token(Token = "0x4008B0B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ConceptCardIcon IconTemplate;
    [Token(Token = "0x4008B0C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject IconParent;
    [Token(Token = "0x4008B0D")]
    [FieldOffset(Offset = "0x14")]
    private ConceptCardData mCurrentConceptCard;

    [Token(Token = "0x600865D")]
    [Address(RVA = "0x47C8E0", Offset = "0x47B6E0", VA = "0x1047C8E0")]
    private bool Init() => new bool();

    [Token(Token = "0x600865E")]
    [Address(RVA = "0x47B790", Offset = "0x47A590", VA = "0x1047B790", Slot = "4")]
    public void Activated(int PinID)
    {
    }

    [Token(Token = "0x600865F")]
    [Address(RVA = "0x47CDA0", Offset = "0x47BBA0", VA = "0x1047CDA0")]
    private void InvokeConceptCardEquipWindow_OnChangeAction()
    {
    }

    [Token(Token = "0x6008660")]
    [Address(RVA = "0x47BBA0", Offset = "0x47A9A0", VA = "0x1047BBA0")]
    public static List<ConceptCardData> CreateAutoEquipConceptCard(
      UnitData unit,
      int targetSlotIndex = -1,
      ConceptCardData[] ignorelist = null)
    {
      return (List<ConceptCardData>) null;
    }

    [Token(Token = "0x6008661")]
    [Address(RVA = "0x47B940", Offset = "0x47A740", VA = "0x1047B940")]
    private static int CompareConceptCardData(UnitData unit, ConceptCardData a, ConceptCardData b)
    {
      return new int();
    }

    [Token(Token = "0x6008662")]
    [Address(RVA = "0x47CF10", Offset = "0x47BD10", VA = "0x1047CF10")]
    public void OnClickItem(ConceptCardIcon icon)
    {
    }

    [Token(Token = "0x6008663")]
    [Address(RVA = "0x47C790", Offset = "0x47B590", VA = "0x1047C790")]
    private ConceptCardIcon CreateConceptCardIcon(ConceptCardData conceptCardData)
    {
      return (ConceptCardIcon) null;
    }

    [Token(Token = "0x6008664")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AutoEquipConceptCard()
    {
    }
  }
}
