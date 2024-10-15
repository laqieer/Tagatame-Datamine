// Decompiled with JetBrains decompiler
// Type: SRPG.BadgeValidatorEx
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200207D")]
  [DisallowMultipleComponent]
  [AddComponentMenu("UI/BadgeValidatorEx")]
  public class BadgeValidatorEx : BadgeValidator
  {
    [Token(Token = "0x4008BFE")]
    [FieldOffset(Offset = "0x10")]
    [BitMask]
    public GameManager.BadgeTypes PriorityBadgeType;

    [Token(Token = "0x6008734")]
    [Address(RVA = "0x487CD0", Offset = "0x486AD0", VA = "0x10487CD0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008735")]
    [Address(RVA = "0x487CD0", Offset = "0x486AD0", VA = "0x10487CD0")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x6008736")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BadgeValidatorEx()
    {
    }
  }
}
