// Decompiled with JetBrains decompiler
// Type: SRPG.UIValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200117A")]
  [RequireComponent(typeof (Selectable))]
  [DisallowMultipleComponent]
  [AddComponentMenu("Common/UIValidator")]
  public class UIValidator : MonoBehaviour
  {
    [Token(Token = "0x4003F51")]
    [FieldOffset(Offset = "0x0")]
    public static List<UIValidator> Validators;
    [Token(Token = "0x4003F52")]
    [FieldOffset(Offset = "0xC")]
    [BitMask]
    public CriticalSections Mask;
    [Token(Token = "0x4003F53")]
    [FieldOffset(Offset = "0x10")]
    public InputField Input;
    [Token(Token = "0x4003F54")]
    [FieldOffset(Offset = "0x14")]
    [BitMask]
    public UIValidator.ToggleMasks ToggleMask;

    [Token(Token = "0x6004A92")]
    [Address(RVA = "0x12141E0", Offset = "0x1212FE0", VA = "0x112141E0")]
    public static void UpdateValidators(CriticalSections updateMask, CriticalSections activeMask)
    {
    }

    [Token(Token = "0x6004A93")]
    [Address(RVA = "0x1213F60", Offset = "0x1212D60", VA = "0x11213F60")]
    private void Start()
    {
    }

    [Token(Token = "0x6004A94")]
    [Address(RVA = "0x1214050", Offset = "0x1212E50", VA = "0x11214050")]
    private void UpdateInteractable(CriticalSections csMask)
    {
    }

    [Token(Token = "0x6004A95")]
    [Address(RVA = "0x1213D40", Offset = "0x1212B40", VA = "0x11213D40")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6004A96")]
    [Address(RVA = "0x1213CD0", Offset = "0x1212AD0", VA = "0x11213CD0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6004A97")]
    [Address(RVA = "0x1213C10", Offset = "0x1212A10", VA = "0x11213C10")]
    private bool IsEmoji(char a) => new bool();

    [Token(Token = "0x6004A98")]
    [Address(RVA = "0x1213AE0", Offset = "0x12128E0", VA = "0x11213AE0")]
    private bool IsEmojiWork(char a) => new bool();

    [Token(Token = "0x6004A99")]
    [Address(RVA = "0x1213DE0", Offset = "0x1212BE0", VA = "0x11213DE0")]
    private void OnInputFieldChange(string value)
    {
    }

    [Token(Token = "0x6004A9A")]
    [Address(RVA = "0x1214370", Offset = "0x1213170", VA = "0x11214370")]
    public UIValidator()
    {
    }

    [Token(Token = "0x6004A9B")]
    [Address(RVA = "0x12142F0", Offset = "0x12130F0", VA = "0x112142F0")]
    static UIValidator()
    {
    }

    [Token(Token = "0x200117B")]
    [Flags]
    public enum ToggleMasks
    {
      [Token(Token = "0x4003F56")] Interactable = 1,
      [Token(Token = "0x4003F57")] Enable = 2,
      [Token(Token = "0x4003F58")] BlockRaycast = 4,
    }
  }
}
