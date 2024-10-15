// Decompiled with JetBrains decompiler
// Type: TabGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002DA")]
[AddComponentMenu("UI/Tab Group")]
public class TabGroup : MonoBehaviour
{
  [Token(Token = "0x4000BD4")]
  [FieldOffset(Offset = "0xC")]
  [FlexibleArray]
  public Toggle[] Tabs;

  [Token(Token = "0x6000EDE")]
  [Address(RVA = "0x11DAE10", Offset = "0x11D9C10", VA = "0x111DAE10")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EDF")]
  [Address(RVA = "0x11DAC10", Offset = "0x11D9A10", VA = "0x111DAC10")]
  private void OnValueChange(bool value)
  {
  }

  [Token(Token = "0x6000EE0")]
  [Address(RVA = "0x11DAF40", Offset = "0x11D9D40", VA = "0x111DAF40")]
  public TabGroup()
  {
  }
}
