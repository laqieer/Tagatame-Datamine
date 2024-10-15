// Decompiled with JetBrains decompiler
// Type: SRPG.TowerFeatureDescriptionDetail
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
  [Token(Token = "0x2002B3E")]
  [FlowNode.Pin(2, "前のページボタン", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "次のページボタン", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/TowerFeatureDescriptionDetail")]
  public class TowerFeatureDescriptionDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D343")]
    private const int PIN_NEXT_BUTTON = 1;
    [Token(Token = "0x400D344")]
    private const int PIN_PREV_BUTTON = 2;
    [Token(Token = "0x400D345")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray ImageData;
    [Token(Token = "0x400D346")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button PrevButton;
    [Token(Token = "0x400D347")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button NextButton;
    [Token(Token = "0x400D348")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ParentPageIcon;
    [Token(Token = "0x400D349")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject TemplatePageIcon;
    [Token(Token = "0x400D34A")]
    [FieldOffset(Offset = "0x20")]
    private List<Toggle> mToggleIconList;

    [Token(Token = "0x600C5E5")]
    [Address(RVA = "0x8E6FC0", Offset = "0x8E5DC0", VA = "0x108E6FC0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5E6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C5E7")]
    [Address(RVA = "0x8E6DF0", Offset = "0x8E5BF0", VA = "0x108E6DF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C5E8")]
    [Address(RVA = "0x8E6E70", Offset = "0x8E5C70", VA = "0x108E6E70")]
    private void SetButtonInteractable()
    {
    }

    [Token(Token = "0x600C5E9")]
    [Address(RVA = "0x8E6F00", Offset = "0x8E5D00", VA = "0x108E6F00")]
    private void SetTobbleIcon()
    {
    }

    [Token(Token = "0x600C5EA")]
    [Address(RVA = "0x8E7330", Offset = "0x8E6130", VA = "0x108E7330")]
    public TowerFeatureDescriptionDetail()
    {
    }
  }
}
