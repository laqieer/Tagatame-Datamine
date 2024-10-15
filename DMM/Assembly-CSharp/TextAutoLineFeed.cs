// Decompiled with JetBrains decompiler
// Type: TextAutoLineFeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002DC")]
[AddComponentMenu("UI/TextAutoLineFeed")]
public class TextAutoLineFeed : MonoBehaviour
{
  [Token(Token = "0x4000BD5")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private int LineMaxLength;
  [Token(Token = "0x4000BD6")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private string[] BeforeInsert;
  [Token(Token = "0x4000BD7")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private string[] LaterInsert;
  [Token(Token = "0x4000BD8")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private bool IgnoreEmptyLine;
  [Token(Token = "0x4000BD9")]
  [FieldOffset(Offset = "0x1C")]
  private Text mTargetText;
  [Token(Token = "0x4000BDA")]
  [FieldOffset(Offset = "0x20")]
  private string mPreText;

  [Token(Token = "0x6000EE4")]
  [Address(RVA = "0x11DB210", Offset = "0x11DA010", VA = "0x111DB210")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EE5")]
  [Address(RVA = "0x11DB260", Offset = "0x11DA060", VA = "0x111DB260")]
  private void Update()
  {
  }

  [Token(Token = "0x6000EE6")]
  [Address(RVA = "0x11DB0A0", Offset = "0x11D9EA0", VA = "0x111DB0A0")]
  private string InsertLineFeed(string text) => (string) null;

  [Token(Token = "0x6000EE7")]
  [Address(RVA = "0x11DB050", Offset = "0x11D9E50", VA = "0x111DB050")]
  private string DeleteEmptyLine(string text) => (string) null;

  [Token(Token = "0x6000EE8")]
  [Address(RVA = "0x11DB420", Offset = "0x11DA220", VA = "0x111DB420")]
  public TextAutoLineFeed()
  {
  }
}
