// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraConditionsItem
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
  [Token(Token = "0x2002D06")]
  [AddComponentMenu("UI/UnitTobiraConditionsItem")]
  public class UnitTobiraConditionsItem : MonoBehaviour
  {
    [Token(Token = "0x400DFFF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray m_ClearIcon;
    [Token(Token = "0x400E000")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_ConditionsText;
    [Token(Token = "0x400E001")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private UnitTobiraConditionsItem.TextColor m_TextColor;

    [Token(Token = "0x600D1A1")]
    [Address(RVA = "0x9CBD70", Offset = "0x9CAB70", VA = "0x109CBD70")]
    public void Setup(ConditionsResult conds)
    {
    }

    [Token(Token = "0x600D1A2")]
    [Address(RVA = "0x9CBCF0", Offset = "0x9CAAF0", VA = "0x109CBCF0")]
    public void SetConditionsText(string text)
    {
    }

    [Token(Token = "0x600D1A3")]
    [Address(RVA = "0x9CBC00", Offset = "0x9CAA00", VA = "0x109CBC00")]
    public void SetClearIcon(bool isClear)
    {
    }

    [Token(Token = "0x600D1A4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitTobiraConditionsItem()
    {
    }

    [Token(Token = "0x2002D07")]
    [Serializable]
    private class TextColor
    {
      [Token(Token = "0x400E002")]
      [FieldOffset(Offset = "0x8")]
      public Color m_Clear;
      [Token(Token = "0x400E003")]
      [FieldOffset(Offset = "0x18")]
      public Color m_NotClear;

      [Token(Token = "0x600D1A5")]
      [Address(RVA = "0x9C8490", Offset = "0x9C7290", VA = "0x109C8490")]
      public TextColor()
      {
      }
    }
  }
}
