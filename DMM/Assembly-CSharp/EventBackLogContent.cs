// Decompiled with JetBrains decompiler
// Type: EventBackLogContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001B2")]
[AddComponentMenu("Event/EventBackLogContent")]
public class EventBackLogContent : MonoBehaviour
{
  [Token(Token = "0x40007F6")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private UnityEngine.UI.Text m_LogName;
  [Token(Token = "0x40007F7")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private UnityEngine.UI.Text m_LogText;
  [Token(Token = "0x40007F8")]
  [FieldOffset(Offset = "0x0")]
  private static Regex pattern;

  [Token(Token = "0x6000A35")]
  [Address(RVA = "0xF46D60", Offset = "0xF45B60", VA = "0x10F46D60")]
  public void SetBackLogText(string name, string text)
  {
  }

  [Token(Token = "0x6000A36")]
  [Address(RVA = "0xF46AD0", Offset = "0xF458D0", VA = "0x10F46AD0")]
  private string ReplaceTag(string text) => (string) null;

  [Token(Token = "0x6000A37")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public EventBackLogContent()
  {
  }

  [Token(Token = "0x6000A38")]
  [Address(RVA = "0xF46DD0", Offset = "0xF45BD0", VA = "0x10F46DD0")]
  static EventBackLogContent()
  {
  }
}
