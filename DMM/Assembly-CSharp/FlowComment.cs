// Decompiled with JetBrains decompiler
// Type: FlowComment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001B3")]
[AddComponentMenu("Flow/FlowComment")]
[ExecuteInEditMode]
public class FlowComment : MonoBehaviour
{
  [Token(Token = "0x40007F9")]
  [FieldOffset(Offset = "0xC")]
  public List<FlowComment.Comment> Comments;

  [Token(Token = "0x6000A39")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000A3A")]
  [Address(RVA = "0xF47420", Offset = "0xF46220", VA = "0x10F47420")]
  public FlowComment()
  {
  }

  [Token(Token = "0x20001B4")]
  [Serializable]
  public struct Comment
  {
    [Token(Token = "0x40007FA")]
    [FieldOffset(Offset = "0x0")]
    public Vector2 Position;
    [Token(Token = "0x40007FB")]
    [FieldOffset(Offset = "0x8")]
    public string Text;
    [Token(Token = "0x40007FC")]
    [FieldOffset(Offset = "0xC")]
    public Color Color;
    [Token(Token = "0x40007FD")]
    [FieldOffset(Offset = "0x1C")]
    public Color Background;
    [Token(Token = "0x40007FE")]
    [FieldOffset(Offset = "0x2C")]
    public int FontSize;

    [Token(Token = "0x6000A3B")]
    [Address(RVA = "0xF46530", Offset = "0xF45330", VA = "0x10F46530")]
    public Comment(Vector2 pos, string text)
    {
    }
  }
}
