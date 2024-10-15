// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalRecommendCheckWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022D1")]
  [FlowNode.Pin(1, "装備通信準備", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "装備通信へ", FlowNode.PinTypes.Output, 101)]
  public class CrystalRecommendCheckWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009B10")]
    private const int PIN_INPUT_EQUIP_CONNECT = 1;
    [Token(Token = "0x4009B11")]
    private const int PIN_OUTPUT_EQUIP_CONNECT = 101;
    [Token(Token = "0x4009B12")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<GameObject> IconObjList;
    [Token(Token = "0x4009B13")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<CrystalIcon> CrystalIconList;
    [Token(Token = "0x4009B14")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour EquipData;

    [Token(Token = "0x600958F")]
    [Address(RVA = "0x584480", Offset = "0x583280", VA = "0x10584480", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009590")]
    [Address(RVA = "0x584900", Offset = "0x583700", VA = "0x10584900")]
    private void Start()
    {
    }

    [Token(Token = "0x6009591")]
    [Address(RVA = "0x5844A0", Offset = "0x5832A0", VA = "0x105844A0")]
    private void StartEquipConnect()
    {
    }

    [Token(Token = "0x6009592")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalRecommendCheckWindow()
    {
    }
  }
}
