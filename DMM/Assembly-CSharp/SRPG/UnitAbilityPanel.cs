// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilityPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BB1")]
  public class UnitAbilityPanel : MonoBehaviour
  {
    [Token(Token = "0x400D68F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400D690")]
    [FieldOffset(Offset = "0x10")]
    private UnitAbilityPanelModel mModel;

    [Token(Token = "0x17001A94")]
    public UnitData UnitData
    {
      [Token(Token = "0x600C8D0"), Address(RVA = "0x919970", Offset = "0x918770", VA = "0x10919970")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001A95")]
    public AbilityData AbilityData
    {
      [Token(Token = "0x600C8D1"), Address(RVA = "0x919930", Offset = "0x918730", VA = "0x10919930")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x17001A96")]
    public AbilityParam AbilityParam
    {
      [Token(Token = "0x600C8D2"), Address(RVA = "0x919950", Offset = "0x918750", VA = "0x10919950")] get
      {
        return (AbilityParam) null;
      }
    }

    [Token(Token = "0x600C8D3")]
    [Address(RVA = "0x9195A0", Offset = "0x9183A0", VA = "0x109195A0")]
    public void Initialize(
      UnitData unitData,
      AbilityData abilityData,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty,
      int slotIndex = 0,
      bool isHide = false)
    {
    }

    [Token(Token = "0x600C8D4")]
    [Address(RVA = "0x919630", Offset = "0x918430", VA = "0x10919630")]
    public void Initialize(
      UnitData unitData,
      AbilityParam abilityParam,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty,
      int slotIndex = 0,
      bool isHide = false)
    {
    }

    [Token(Token = "0x600C8D5")]
    [Address(RVA = "0x919830", Offset = "0x918630", VA = "0x10919830")]
    public void Setup(
      UnitData unitData,
      AbilityData abilityData,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty,
      int slotIndex = 0,
      bool isHide = false)
    {
    }

    [Token(Token = "0x600C8D6")]
    [Address(RVA = "0x9198B0", Offset = "0x9186B0", VA = "0x109198B0")]
    public void Setup(
      UnitData unitData,
      AbilityParam abilityParam,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty,
      int slotIndex = 0,
      bool isHide = false)
    {
    }

    [Token(Token = "0x600C8D7")]
    [Address(RVA = "0x919710", Offset = "0x918510", VA = "0x10919710")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C8D8")]
    [Address(RVA = "0x919790", Offset = "0x918590", VA = "0x10919790")]
    public void Refresh(
      UnitData unitData,
      AbilityData abilityData,
      UnitAbilityPanelModel.Mode mode = UnitAbilityPanelModel.Mode.Empty)
    {
    }

    [Token(Token = "0x600C8D9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitAbilityPanel()
    {
    }
  }
}
