// Decompiled with JetBrains decompiler
// Type: ButtonExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20000E9")]
[AddComponentMenu("Common/ButtonExt")]
[RequireComponent(typeof (Button))]
public class ButtonExt : MonoBehaviour
{
  [Token(Token = "0x400040D")]
  [FieldOffset(Offset = "0xC")]
  private ButtonExt.ButtonClickEvent mOnClick;

  [Token(Token = "0x6000586")]
  [Address(RVA = "0xC67C60", Offset = "0xC66A60", VA = "0x10C67C60")]
  private void Start()
  {
  }

  [Token(Token = "0x6000587")]
  [Address(RVA = "0xC67B90", Offset = "0xC66990", VA = "0x10C67B90")]
  private void OnClick()
  {
  }

  [Token(Token = "0x6000588")]
  [Address(RVA = "0xC67B00", Offset = "0xC66900", VA = "0x10C67B00")]
  public void AddListener(ButtonExt.ButtonClickEvent listener)
  {
  }

  [Token(Token = "0x6000589")]
  [Address(RVA = "0xC67BD0", Offset = "0xC669D0", VA = "0x10C67BD0")]
  public void RemoveListener(ButtonExt.ButtonClickEvent listener)
  {
  }

  [Token(Token = "0x600058A")]
  [Address(RVA = "0xC67D00", Offset = "0xC66B00", VA = "0x10C67D00")]
  public ButtonExt()
  {
  }

  [Token(Token = "0x20000EA")]
  public delegate void ButtonClickEvent(GameObject go);
}
