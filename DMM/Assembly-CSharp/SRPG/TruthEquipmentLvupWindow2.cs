// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentLvupWindow2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B93")]
  public class TruthEquipmentLvupWindow2 : TruthEquipmentLvupWindow
  {
    [Token(Token = "0x400D5D3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private BitmapText NowLevelText;
    [Token(Token = "0x400D5D4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BitmapText SelectLevelText;
    [Token(Token = "0x400D5D5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button MinusButton;
    [Token(Token = "0x400D5D6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button PlusButton;
    [Token(Token = "0x400D5D7")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Slider LevelSlider;
    [Token(Token = "0x400D5D8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TruthEquipmentIcon TruthEquipmentIcon;
    [Token(Token = "0x400D5D9")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private ExhibitList AddStatusExhibitList;
    [Token(Token = "0x400D5DA")]
    [FieldOffset(Offset = "0x58")]
    private int mAddLevel;
    [Token(Token = "0x400D5DB")]
    [FieldOffset(Offset = "0x5C")]
    private TruthEquipmentAddStatusModel addStatusModel;

    [Token(Token = "0x600C809")]
    [Address(RVA = "0x90D830", Offset = "0x90C630", VA = "0x1090D830", Slot = "6")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C80A")]
    [Address(RVA = "0x90E330", Offset = "0x90D130", VA = "0x1090E330", Slot = "5")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C80B")]
    [Address(RVA = "0x90DD40", Offset = "0x90CB40", VA = "0x1090DD40", Slot = "7")]
    protected override void RefreshCautionEnable()
    {
    }

    [Token(Token = "0x600C80C")]
    [Address(RVA = "0x90DFC0", Offset = "0x90CDC0", VA = "0x1090DFC0")]
    private void SetSlider()
    {
    }

    [Token(Token = "0x600C80D")]
    [Address(RVA = "0x90D9A0", Offset = "0x90C7A0", VA = "0x1090D9A0")]
    private void OnSelectUseNumChanged(float value)
    {
    }

    [Token(Token = "0x600C80E")]
    [Address(RVA = "0x90D860", Offset = "0x90C660", VA = "0x1090D860")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x600C80F")]
    [Address(RVA = "0x90D900", Offset = "0x90C700", VA = "0x1090D900")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x600C810")]
    [Address(RVA = "0x90DE60", Offset = "0x90CC60", VA = "0x1090DE60")]
    private void SetBtnInteractable()
    {
    }

    [Token(Token = "0x600C811")]
    [Address(RVA = "0x90DC60", Offset = "0x90CA60", VA = "0x1090DC60")]
    private void RefreshAddStatus()
    {
    }

    [Token(Token = "0x600C812")]
    [Address(RVA = "0x90E510", Offset = "0x90D310", VA = "0x1090E510")]
    public TruthEquipmentLvupWindow2()
    {
    }
  }
}
