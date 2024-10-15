// Decompiled with JetBrains decompiler
// Type: SRPG.SupportIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B0C")]
  [AddComponentMenu("UI/SupportIcon")]
  public class SupportIcon : UnitIcon
  {
    [Token(Token = "0x400D214")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject ConceptCardLSEnableEffect;
    [Token(Token = "0x400D215")]
    private const string TooltipPath = "UI/SupportTooltip";
    [Token(Token = "0x400D216")]
    [FieldOffset(Offset = "0x50")]
    public bool UseSelection;

    [Token(Token = "0x600C508")]
    [Address(RVA = "0x8DA6C0", Offset = "0x8D94C0", VA = "0x108DA6C0", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x600C509")]
    [Address(RVA = "0x8DA530", Offset = "0x8D9330", VA = "0x108DA530")]
    private SupportData GetSupportData() => (SupportData) null;

    [Token(Token = "0x600C50A")]
    [Address(RVA = "0x8DA510", Offset = "0x8D9310", VA = "0x108DA510", Slot = "13")]
    protected override UnitData GetInstanceData() => (UnitData) null;

    [Token(Token = "0x600C50B")]
    [Address(RVA = "0x8DA5C0", Offset = "0x8D93C0", VA = "0x108DA5C0", Slot = "9")]
    protected override void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600C50C")]
    [Address(RVA = "0x663710", Offset = "0x662510", VA = "0x10663710")]
    public SupportIcon()
    {
    }
  }
}
