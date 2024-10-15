// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalDetailWindow
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
  [Token(Token = "0x20022A8")]
  [FlowNode.Pin(300, "お気に入り", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(400, "一括解除", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(200, "更新", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(401, "一括解除へ", FlowNode.PinTypes.Output, 401)]
  public class CrystalDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40099FE")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x40099FF")]
    private const int PIN_INPUT_REFRESH = 200;
    [Token(Token = "0x4009A00")]
    private const int PIN_INPUT_BULK_RELEASE = 400;
    [Token(Token = "0x4009A01")]
    private const int PIN_OUTPUT_BULK_RELEASE = 401;
    [Token(Token = "0x4009A02")]
    private const int PIN_OUTPUT_ONFAVORITE = 300;
    [Token(Token = "0x4009A03")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList DetailWindowExhibitList;
    [Token(Token = "0x4009A04")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalIcon SelectIcon;
    [Token(Token = "0x4009A05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalStatusList StatusList;
    [Token(Token = "0x4009A06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle FavoriteToggle;
    [Token(Token = "0x4009A07")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject GradeUpEffectObj;
    [Token(Token = "0x4009A08")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsFrameDisp;
    [Token(Token = "0x4009A09")]
    [FieldOffset(Offset = "0x21")]
    [SerializeField]
    private bool IsHaving;
    [Token(Token = "0x4009A0A")]
    [FieldOffset(Offset = "0x22")]
    [SerializeField]
    private bool IsRankDisp;
    [Token(Token = "0x4009A0B")]
    [FieldOffset(Offset = "0x23")]
    [SerializeField]
    private bool IsPlusDisp;
    [Token(Token = "0x4009A0C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x4009A0D")]
    [FieldOffset(Offset = "0x28")]
    private CrystalData mData;
    [Token(Token = "0x4009A0E")]
    [FieldOffset(Offset = "0x2C")]
    private CrystalDetailWindowModel mDetailWindowModel;

    [Token(Token = "0x6009470")]
    [Address(RVA = "0x5697E0", Offset = "0x5685E0", VA = "0x105697E0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009471")]
    [Address(RVA = "0x568350", Offset = "0x567150", VA = "0x10568350", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009472")]
    [Address(RVA = "0x5691F0", Offset = "0x567FF0", VA = "0x105691F0")]
    public void SaveSVB()
    {
    }

    [Token(Token = "0x6009473")]
    [Address(RVA = "0x569300", Offset = "0x568100", VA = "0x10569300")]
    public void SetUp(
      CrystalData _data,
      CrystalDetailWindowModel.CystalIconAdditionalData _add_data,
      bool _is_icon_grayout = true)
    {
    }

    [Token(Token = "0x6009474")]
    [Address(RVA = "0x568F00", Offset = "0x567D00", VA = "0x10568F00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009475")]
    [Address(RVA = "0x568B50", Offset = "0x567950", VA = "0x10568B50")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009476")]
    [Address(RVA = "0x569830", Offset = "0x568630", VA = "0x10569830")]
    private void ToggleValueChanged(Toggle change)
    {
    }

    [Token(Token = "0x6009477")]
    [Address(RVA = "0x5685E0", Offset = "0x5673E0", VA = "0x105685E0")]
    private CrystalDetailWindowModel.CystalIconAdditionalData CreateCrystalIconAdditionalData(
      CrystalData _crystal_data = null)
    {
      return new CrystalDetailWindowModel.CystalIconAdditionalData();
    }

    [Token(Token = "0x6009478")]
    [Address(RVA = "0x568CA0", Offset = "0x567AA0", VA = "0x10568CA0")]
    private bool IsDisassembleInteractable(CrystalData _data) => new bool();

    [Token(Token = "0x6009479")]
    [Address(RVA = "0x568D70", Offset = "0x567B70", VA = "0x10568D70")]
    private bool IsGradeUpInteractable(CrystalData _data) => new bool();

    [Token(Token = "0x600947A")]
    [Address(RVA = "0x568E30", Offset = "0x567C30", VA = "0x10568E30")]
    private bool IsSetBonusInteractable(CrystalData _data, bool _is_main = false, bool _is_sub = false)
    {
      return new bool();
    }

    [Token(Token = "0x600947B")]
    [Address(RVA = "0x568BD0", Offset = "0x5679D0", VA = "0x10568BD0")]
    private bool IsAllUnequipInteractable(CrystalData _data) => new bool();

    [Token(Token = "0x600947C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalDetailWindow()
    {
    }
  }
}
