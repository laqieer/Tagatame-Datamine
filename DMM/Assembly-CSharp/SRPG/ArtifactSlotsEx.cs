// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSlotsEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002038")]
  [FlowNode.Pin(0, "Job Change(True)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Job Change(False)", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Force Update", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(111, "更新", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(121, "武具変更API", FlowNode.PinTypes.Output, 121)]
  [AddComponentMenu("UI/ArtifactSlotsEx")]
  public class ArtifactSlotsEx : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40089C6")]
    private const int PIN_IN_JOBCHANGE_TRUE = 0;
    [Token(Token = "0x40089C7")]
    private const int PIN_IN_JOBCHANGE_FALSE = 1;
    [Token(Token = "0x40089C8")]
    private const int PIN_IN_FORCE_UPDATE = 2;
    [Token(Token = "0x40089C9")]
    private const int PIN_OUT_REFRESH = 111;
    [Token(Token = "0x40089CA")]
    private const int PIN_OUT_CHANGE_ARTIFACT = 121;
    [Token(Token = "0x40089CB")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ArtiSelectPath;
    [Token(Token = "0x40089CC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenericSlotEx[] mArtifactSlots;
    [Token(Token = "0x40089CD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ArtifactIconEx[] mArtifactIcons;
    [Token(Token = "0x40089CE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool mIsHideMode;
    [Token(Token = "0x40089CF")]
    [FieldOffset(Offset = "0x18")]
    private ArtifactSlotsExModel mModel;
    [Token(Token = "0x40089D0")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject RootObject;
    [Token(Token = "0x40089D1")]
    [FieldOffset(Offset = "0x20")]
    public UnitJobDropdown JobDropDown;
    [Token(Token = "0x40089D2")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mArtiSelector;

    [Token(Token = "0x6008563")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008564")]
    [Address(RVA = "0x460830", Offset = "0x45F630", VA = "0x10460830")]
    private void Start()
    {
    }

    [Token(Token = "0x6008565")]
    [Address(RVA = "0x460830", Offset = "0x45F630", VA = "0x10460830")]
    private void InitializeSlots()
    {
    }

    [Token(Token = "0x6008566")]
    [Address(RVA = "0x461960", Offset = "0x460760", VA = "0x10461960")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008567")]
    [Address(RVA = "0x460950", Offset = "0x45F750", VA = "0x10460950")]
    public void Initialize(UnitData unitData, bool editMode, bool isHide = false)
    {
    }

    [Token(Token = "0x6008568")]
    [Address(RVA = "0x4622A0", Offset = "0x4610A0", VA = "0x104622A0")]
    public void SetupModel(UnitData unitData, bool editMode, bool isHide = false)
    {
    }

    [Token(Token = "0x6008569")]
    [Address(RVA = "0x4621F0", Offset = "0x460FF0", VA = "0x104621F0")]
    public void Refresh(bool enable)
    {
    }

    [Token(Token = "0x600856A")]
    [Address(RVA = "0x462250", Offset = "0x461050", VA = "0x10462250")]
    public void Refresh(UnitData unitData, bool enable)
    {
    }

    [Token(Token = "0x600856B")]
    [Address(RVA = "0x461FD0", Offset = "0x460DD0", VA = "0x10461FD0")]
    private void RefreshSlots(bool enable = true)
    {
    }

    [Token(Token = "0x600856C")]
    [Address(RVA = "0x460B10", Offset = "0x45F910", VA = "0x10460B10")]
    public static bool IsLockedArtifactSlot(int slot, JobData job, UnitData unit) => new bool();

    [Token(Token = "0x600856D")]
    [Address(RVA = "0x460C00", Offset = "0x45FA00", VA = "0x10460C00")]
    private void OnClick(GenericSlotEx slot, bool interactable)
    {
    }

    [Token(Token = "0x600856E")]
    [Address(RVA = "0x460670", Offset = "0x45F470", VA = "0x10460670")]
    private ArtifactData[] GetViewArtifactList() => (ArtifactData[]) null;

    [Token(Token = "0x600856F")]
    [Address(RVA = "0x4619B0", Offset = "0x4607B0", VA = "0x104619B0")]
    private void OnSelect(ArtifactData artifact, ArtifactTypes type = ArtifactTypes.None)
    {
    }

    [Token(Token = "0x6008570")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactSlotsEx()
    {
    }

    [Token(Token = "0x6008571")]
    [Address(RVA = "0x462360", Offset = "0x461160", VA = "0x10462360")]
    static ArtifactSlotsEx()
    {
    }
  }
}
