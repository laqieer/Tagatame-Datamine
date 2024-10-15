// Decompiled with JetBrains decompiler
// Type: SRPG.UnitIconEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C36")]
  [AddComponentMenu("UI/UnitIconEx")]
  public class UnitIconEx : UnitIcon
  {
    [Token(Token = "0x400DAF0")]
    [FieldOffset(Offset = "0x4C")]
    public string GeneralTooltipPath;
    [Token(Token = "0x400DAF1")]
    private const string DefaultTootTipPath = "UI/UnitTooltip.prefab";

    [Token(Token = "0x600CCCC")]
    [Address(RVA = "0x978820", Offset = "0x977620", VA = "0x10978820", Slot = "9")]
    protected override void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600CCCD")]
    [Address(RVA = "0x978490", Offset = "0x977290", VA = "0x10978490")]
    private void BindData(GameObject go, UnitData unitData)
    {
    }

    [Token(Token = "0x600CCCE")]
    [Address(RVA = "0x978980", Offset = "0x977780", VA = "0x10978980")]
    public UnitIconEx()
    {
    }
  }
}
