// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSlots
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002034")]
  [FlowNode.Pin(1, "Job Change(False)", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/ArtifactSlots")]
  [FlowNode.Pin(0, "Job Change(True)", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(2, "Force Update", FlowNode.PinTypes.Input, 2)]
  public class ArtifactSlots : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40089B8")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string ArtiSelectPath;
    [Token(Token = "0x40089B9")]
    [FieldOffset(Offset = "0xC")]
    public GenericSlot ArtifactSlot;
    [Token(Token = "0x40089BA")]
    [FieldOffset(Offset = "0x10")]
    public GenericSlot ArtifactSlot2;
    [Token(Token = "0x40089BB")]
    [FieldOffset(Offset = "0x14")]
    public GenericSlot ArtifactSlot3;
    [Token(Token = "0x40089BC")]
    [FieldOffset(Offset = "0x18")]
    public GameObject RootObject;
    [Token(Token = "0x40089BD")]
    [FieldOffset(Offset = "0x1C")]
    public UnitJobDropdown JobDropDown;
    [Token(Token = "0x40089BE")]
    [FieldOffset(Offset = "0x20")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x40089BF")]
    [FieldOffset(Offset = "0x24")]
    private GameObject mArtiSelector;

    [Token(Token = "0x600854E")]
    [Address(RVA = "0x4623B0", Offset = "0x4611B0", VA = "0x104623B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600854F")]
    [Address(RVA = "0x465010", Offset = "0x463E10", VA = "0x10465010")]
    private void Start()
    {
    }

    [Token(Token = "0x6008550")]
    [Address(RVA = "0x463D60", Offset = "0x462B60", VA = "0x10463D60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008551")]
    [Address(RVA = "0x4648C0", Offset = "0x4636C0", VA = "0x104648C0")]
    public void Refresh(bool enable)
    {
    }

    [Token(Token = "0x6008552")]
    [Address(RVA = "0x4647A0", Offset = "0x4635A0", VA = "0x104647A0")]
    private void RefreshSlots(
      GenericSlot slot,
      ArtifactData[] list,
      int index,
      int job_rank,
      bool is_locked = true,
      bool enable = true)
    {
    }

    [Token(Token = "0x6008553")]
    [Address(RVA = "0x462690", Offset = "0x461490", VA = "0x10462690")]
    public static bool IsLockedArtifactSlot(int slot, JobData job, UnitData unit) => new bool();

    [Token(Token = "0x6008554")]
    [Address(RVA = "0x462F10", Offset = "0x461D10", VA = "0x10462F10")]
    private void OnClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x6008555")]
    [Address(RVA = "0x462410", Offset = "0x461210", VA = "0x10462410")]
    private ArtifactData[] GetViewArtifactList() => (ArtifactData[]) null;

    [Token(Token = "0x6008556")]
    [Address(RVA = "0x463DB0", Offset = "0x462BB0", VA = "0x10463DB0")]
    private void OnSelect(ArtifactData artifact, ArtifactTypes type = ArtifactTypes.None)
    {
    }

    [Token(Token = "0x6008557")]
    [Address(RVA = "0x462DE0", Offset = "0x461BE0", VA = "0x10462DE0")]
    private void OnArtifactSetResult(WWWResult www)
    {
    }

    [Token(Token = "0x6008558")]
    [Address(RVA = "0x462AF0", Offset = "0x4618F0", VA = "0x10462AF0")]
    private void OnArtifactSetResult_Simple(WWWResult www)
    {
    }

    [Token(Token = "0x6008559")]
    [Address(RVA = "0x462780", Offset = "0x461580", VA = "0x10462780")]
    private void OnArtifactSetResult_OverWrite(WWWResult www)
    {
    }

    [Token(Token = "0x600855A")]
    [Address(RVA = "0x465190", Offset = "0x463F90", VA = "0x10465190")]
    private void UpdateRootObject()
    {
    }

    [Token(Token = "0x600855B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactSlots()
    {
    }

    [Token(Token = "0x600855C")]
    [Address(RVA = "0x465210", Offset = "0x464010", VA = "0x10465210")]
    static ArtifactSlots()
    {
    }

    [Token(Token = "0x2002035")]
    [MessagePackObject(true)]
    public class MP_ArtifactSet_OverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x40089C0")]
      [FieldOffset(Offset = "0x28")]
      public ReqArtifactSet_OverWrite.Response body;

      [Token(Token = "0x600855D")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_ArtifactSet_OverWriteResponse()
      {
      }
    }
  }
}
