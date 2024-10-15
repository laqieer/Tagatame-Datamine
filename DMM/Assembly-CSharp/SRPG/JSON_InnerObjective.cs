// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_InnerObjective
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BFA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_InnerObjective
  {
    [Token(Token = "0x4006C4A")]
    [FieldOffset(Offset = "0x8")]
    public int type;
    [Token(Token = "0x4006C4B")]
    [FieldOffset(Offset = "0xC")]
    public string val;
    [Token(Token = "0x4006C4C")]
    [FieldOffset(Offset = "0x10")]
    public string item;
    [Token(Token = "0x4006C4D")]
    [FieldOffset(Offset = "0x14")]
    public int num;
    [Token(Token = "0x4006C4E")]
    [FieldOffset(Offset = "0x18")]
    public int item_type;
    [Token(Token = "0x4006C4F")]
    [FieldOffset(Offset = "0x1C")]
    public int is_takeover_progress;

    [Token(Token = "0x17000E48")]
    public bool IsTakeoverProgress
    {
      [Token(Token = "0x600733A"), Address(RVA = "0x3784F0", Offset = "0x3772F0", VA = "0x103784F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600733B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_InnerObjective()
    {
    }
  }
}
