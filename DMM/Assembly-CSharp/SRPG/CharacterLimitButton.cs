// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterLimitButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200213A")]
  [AddComponentMenu("CharacterLimitButton")]
  public class CharacterLimitButton : MonoBehaviour
  {
    [Token(Token = "0x40090A7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public CharacterLimitButton.InputfieldSet[] target_list;
    [Token(Token = "0x40090A8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public Button target_button;

    [Token(Token = "0x6008B70")]
    [Address(RVA = "0x4F6000", Offset = "0x4F4E00", VA = "0x104F6000")]
    private void Start()
    {
    }

    [Token(Token = "0x6008B71")]
    [Address(RVA = "0x4F5F30", Offset = "0x4F4D30", VA = "0x104F5F30")]
    public void OnInputFieldChange(string value)
    {
    }

    [Token(Token = "0x6008B72")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CharacterLimitButton()
    {
    }

    [Token(Token = "0x200213B")]
    [Serializable]
    public class InputfieldSet
    {
      [Token(Token = "0x40090A9")]
      [FieldOffset(Offset = "0x8")]
      public InputField input;
      [Token(Token = "0x40090AA")]
      [FieldOffset(Offset = "0xC")]
      public int min_length;
      [Token(Token = "0x40090AB")]
      [FieldOffset(Offset = "0x10")]
      public int max_length;

      [Token(Token = "0x6008B73")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public InputfieldSet()
      {
      }
    }
  }
}
