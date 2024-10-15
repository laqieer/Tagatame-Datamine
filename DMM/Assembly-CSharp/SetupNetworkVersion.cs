// Decompiled with JetBrains decompiler
// Type: SetupNetworkVersion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001AA")]
[AddComponentMenu("Debug/SetupNetworkVersion")]
public class SetupNetworkVersion : MonoBehaviour
{
  [Token(Token = "0x40007E9")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private GameObject uiRoot;
  [Token(Token = "0x40007EA")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private Toggle toggle;
  [Token(Token = "0x40007EB")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private SRPG_InputField versionInputField;
  [Token(Token = "0x40007EC")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Dropdown serverNameDropdown;
  [Token(Token = "0x40007ED")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private List<string> serverList;

  [Token(Token = "0x6000A19")]
  [Address(RVA = "0xF4FE70", Offset = "0xF4EC70", VA = "0x10F4FE70")]
  private void Start()
  {
  }

  [Token(Token = "0x6000A1A")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public SetupNetworkVersion()
  {
  }
}
