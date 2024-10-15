// Decompiled with JetBrains decompiler
// Type: SwitchByPlatform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D7")]
[AddComponentMenu("UI/SwitchByPlatform")]
public class SwitchByPlatform : MonoBehaviour
{
  [Token(Token = "0x4000BCB")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  public RuntimePlatform[] hides;
  [Token(Token = "0x4000BCC")]
  [FieldOffset(Offset = "0x10")]
  public bool hideGooglePlayPC;

  [Token(Token = "0x6000ED6")]
  [Address(RVA = "0x11DA860", Offset = "0x11D9660", VA = "0x111DA860")]
  private void Start()
  {
  }

  [Token(Token = "0x6000ED7")]
  [Address(RVA = "0x11DA8E0", Offset = "0x11D96E0", VA = "0x111DA8E0")]
  public SwitchByPlatform()
  {
  }
}
