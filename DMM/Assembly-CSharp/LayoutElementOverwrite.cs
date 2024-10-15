// Decompiled with JetBrains decompiler
// Type: LayoutElementOverwrite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002BA")]
[AddComponentMenu("UI/LayoutElementOverwrite")]
public class LayoutElementOverwrite : MonoBehaviour
{
  [Token(Token = "0x4000B46")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private LayoutElement TargetLayoutElement;
  [Token(Token = "0x4000B47")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private GameObject BaseGameObject;
  [Token(Token = "0x4000B48")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private bool minWidth;
  [Token(Token = "0x4000B49")]
  [FieldOffset(Offset = "0x15")]
  [SerializeField]
  private bool minHeight;
  [Token(Token = "0x4000B4A")]
  [FieldOffset(Offset = "0x16")]
  [SerializeField]
  private bool preferredWidth;
  [Token(Token = "0x4000B4B")]
  [FieldOffset(Offset = "0x17")]
  [SerializeField]
  private bool preferredHeight;
  [Token(Token = "0x4000B4C")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private bool flexibleWidth;
  [Token(Token = "0x4000B4D")]
  [FieldOffset(Offset = "0x19")]
  [SerializeField]
  private bool flexibleHeight;
  [Token(Token = "0x4000B4E")]
  [FieldOffset(Offset = "0x1C")]
  private Vector3 prevPos;

  [Token(Token = "0x6000E55")]
  [Address(RVA = "0x11D4020", Offset = "0x11D2E20", VA = "0x111D4020")]
  public void Refresh()
  {
  }

  [Token(Token = "0x6000E56")]
  [Address(RVA = "0x11D4380", Offset = "0x11D3180", VA = "0x111D4380")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E57")]
  [Address(RVA = "0x11D44B0", Offset = "0x11D32B0", VA = "0x111D44B0")]
  public LayoutElementOverwrite()
  {
  }
}
