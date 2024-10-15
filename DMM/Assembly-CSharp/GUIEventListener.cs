// Decompiled with JetBrains decompiler
// Type: GUIEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000FB")]
[AddComponentMenu("Common/GUIEventListener")]
public class GUIEventListener : MonoBehaviour
{
  [Token(Token = "0x40004C0")]
  [FieldOffset(Offset = "0xC")]
  public GUIEventListener.GUIEvent Listeners;

  [Token(Token = "0x600068E")]
  [Address(RVA = "0xB8A920", Offset = "0xB89720", VA = "0x10B8A920")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x600068F")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public GUIEventListener()
  {
  }

  [Token(Token = "0x20000FC")]
  public delegate void GUIEvent(GameObject go);
}
