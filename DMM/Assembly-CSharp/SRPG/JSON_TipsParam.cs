// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TipsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D56")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TipsParam
  {
    [Token(Token = "0x4007381")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007382")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x4007383")]
    [FieldOffset(Offset = "0x10")]
    public int order;
    [Token(Token = "0x4007384")]
    [FieldOffset(Offset = "0x14")]
    public string title;
    [Token(Token = "0x4007385")]
    [FieldOffset(Offset = "0x18")]
    public string text;
    [Token(Token = "0x4007386")]
    [FieldOffset(Offset = "0x1C")]
    public string[] images;
    [Token(Token = "0x4007387")]
    [FieldOffset(Offset = "0x20")]
    public int hide;
    [Token(Token = "0x4007388")]
    [FieldOffset(Offset = "0x24")]
    public string cond_text;

    [Token(Token = "0x600782C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TipsParam()
    {
    }
  }
}
