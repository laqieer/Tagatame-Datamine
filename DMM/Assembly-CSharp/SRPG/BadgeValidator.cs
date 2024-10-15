// Decompiled with JetBrains decompiler
// Type: SRPG.BadgeValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200207C")]
  [DisallowMultipleComponent]
  [AddComponentMenu("UI/BadgeValidator")]
  public class BadgeValidator : MonoBehaviour
  {
    [Token(Token = "0x4008BFD")]
    [FieldOffset(Offset = "0xC")]
    [BitMask]
    public GameManager.BadgeTypes BadgeType;

    [Token(Token = "0x6008731")]
    [Address(RVA = "0x487DE0", Offset = "0x486BE0", VA = "0x10487DE0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008732")]
    [Address(RVA = "0x487DE0", Offset = "0x486BE0", VA = "0x10487DE0")]
    private void UpdateBadge()
    {
    }

    [Token(Token = "0x6008733")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BadgeValidator()
    {
    }
  }
}
