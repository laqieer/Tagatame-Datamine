// Decompiled with JetBrains decompiler
// Type: SRPG.ChallengeMissionItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200212D")]
  [AddComponentMenu("UI/ChallengeMissionItem")]
  public class ChallengeMissionItem : MonoBehaviour
  {
    [Token(Token = "0x4009022")]
    [FieldOffset(Offset = "0xC")]
    public ChallengeMissionItem.ButtonObject ButtonNormal;
    [Token(Token = "0x4009023")]
    [FieldOffset(Offset = "0x10")]
    public ChallengeMissionItem.ButtonObject ButtonHighlight;
    [Token(Token = "0x4009024")]
    [FieldOffset(Offset = "0x14")]
    public ChallengeMissionItem.ButtonObject ButtonSecret;
    [Token(Token = "0x4009025")]
    [FieldOffset(Offset = "0x18")]
    public Image ClearBadge;
    [Token(Token = "0x4009026")]
    [FieldOffset(Offset = "0x1C")]
    public UnityAction OnClick;

    [Token(Token = "0x6008B2E")]
    [Address(RVA = "0x4EA930", Offset = "0x4E9730", VA = "0x104EA930")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B2F")]
    [Address(RVA = "0x4E9BC0", Offset = "0x4E89C0", VA = "0x104E9BC0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008B30")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChallengeMissionItem()
    {
    }

    [Token(Token = "0x200212E")]
    private enum State
    {
      [Token(Token = "0x4009028")] Challenge,
      [Token(Token = "0x4009029")] Clear,
      [Token(Token = "0x400902A")] Ended,
    }

    [Token(Token = "0x200212F")]
    [Serializable]
    public class ButtonObject
    {
      [Token(Token = "0x400902B")]
      [FieldOffset(Offset = "0x8")]
      public Button button;
      [Token(Token = "0x400902C")]
      [FieldOffset(Offset = "0xC")]
      public Text title;
      [Token(Token = "0x400902D")]
      [FieldOffset(Offset = "0x10")]
      public Text reward;
      [Token(Token = "0x400902E")]
      [FieldOffset(Offset = "0x14")]
      public GameObject itemIcon;
      [Token(Token = "0x400902F")]
      [FieldOffset(Offset = "0x18")]
      public GameObject goldIcon;
      [Token(Token = "0x4009030")]
      [FieldOffset(Offset = "0x1C")]
      public GameObject staminaIcon;
      [Token(Token = "0x4009031")]
      [FieldOffset(Offset = "0x20")]
      public GameObject expIcon;
      [Token(Token = "0x4009032")]
      [FieldOffset(Offset = "0x24")]
      public ConceptCardIcon conceptCardIcon;
      [Token(Token = "0x4009033")]
      [FieldOffset(Offset = "0x28")]
      public GameObject unitIcon;
      [Token(Token = "0x4009034")]
      [FieldOffset(Offset = "0x2C")]
      public GameObject LockIcon;

      [Token(Token = "0x6008B31")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ButtonObject()
      {
      }
    }
  }
}
