// Decompiled with JetBrains decompiler
// Type: SRPG.RuneSlotEx
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
  [Token(Token = "0x20029ED")]
  [FlowNode.Pin(11, "アニメーションの実行", FlowNode.PinTypes.Input, 11)]
  public class RuneSlotEx : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CBB5")]
    private const int PIN_IN_ANIMETION = 11;
    [Token(Token = "0x400CBB6")]
    private const string EQUIP_ANIMETION_KEY = "change";
    [Token(Token = "0x400CBB7")]
    [FieldOffset(Offset = "0xC")]
    private RuneSlotExModel mModel;
    [Token(Token = "0x400CBB8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400CBB9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool mIsEquipAnimation;
    [Token(Token = "0x400CBBA")]
    [FieldOffset(Offset = "0x15")]
    [SerializeField]
    private bool mIsParticle;
    [Token(Token = "0x400CBBB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400CBBC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mEquipEffect;

    [Token(Token = "0x600BF17")]
    [Address(RVA = "0x866610", Offset = "0x865410", VA = "0x10866610")]
    public void Initialize(BindRuneData runeData, RuneSlotIndex slotIndex)
    {
    }

    [Token(Token = "0x600BF18")]
    [Address(RVA = "0x866710", Offset = "0x865510", VA = "0x10866710")]
    public void Initialize(RuneSlotExModel model)
    {
    }

    [Token(Token = "0x600BF19")]
    [Address(RVA = "0x866340", Offset = "0x865140", VA = "0x10866340", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BF1A")]
    [Address(RVA = "0x866830", Offset = "0x865630", VA = "0x10866830")]
    private void Setup()
    {
    }

    [Token(Token = "0x600BF1B")]
    [Address(RVA = "0x8667D0", Offset = "0x8655D0", VA = "0x108667D0")]
    public void Setup(RuneSlotExModel model)
    {
    }

    [Token(Token = "0x600BF1C")]
    [Address(RVA = "0x866360", Offset = "0x865160", VA = "0x10866360")]
    public void EquipAnimation()
    {
    }

    [Token(Token = "0x600BF1D")]
    [Address(RVA = "0x8664C0", Offset = "0x8652C0", VA = "0x108664C0")]
    public void EquipAnimatorAnimation()
    {
    }

    [Token(Token = "0x600BF1E")]
    [Address(RVA = "0x866550", Offset = "0x865350", VA = "0x10866550")]
    public void EquipParticleAnimation()
    {
    }

    [Token(Token = "0x600BF1F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneSlotEx()
    {
    }
  }
}
