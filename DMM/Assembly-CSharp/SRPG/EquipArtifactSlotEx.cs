// Decompiled with JetBrains decompiler
// Type: SRPG.EquipArtifactSlotEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002354")]
  [AddComponentMenu("UI/EquipArtifactSlotEx")]
  public class EquipArtifactSlotEx : GenericSlotEx
  {
    [Token(Token = "0x4009E4A")]
    [FieldOffset(Offset = "0x24")]
    public SRPG_Button Lock;

    [Token(Token = "0x600984B")]
    [Address(RVA = "0x5B0280", Offset = "0x5AF080", VA = "0x105B0280")]
    private void Awake()
    {
    }

    [Token(Token = "0x600984C")]
    [Address(RVA = "0x5B03A0", Offset = "0x5AF1A0", VA = "0x105B03A0")]
    private void OnButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600984D")]
    [Address(RVA = "0x5B03E0", Offset = "0x5AF1E0", VA = "0x105B03E0")]
    private void OnLockClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600984E")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public EquipArtifactSlotEx()
    {
    }
  }
}
