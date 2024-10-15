// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C40")]
  [MessagePackObject(true)]
  public class JSON_QuestProgress
  {
    [Token(Token = "0x4006E4D")]
    [FieldOffset(Offset = "0x8")]
    public string i;
    [Token(Token = "0x4006E4E")]
    [FieldOffset(Offset = "0x10")]
    public long s;
    [Token(Token = "0x4006E4F")]
    [FieldOffset(Offset = "0x18")]
    public long e;
    [Token(Token = "0x4006E50")]
    [FieldOffset(Offset = "0x20")]
    public long n;
    [Token(Token = "0x4006E51")]
    [FieldOffset(Offset = "0x28")]
    public int c;
    [Token(Token = "0x4006E52")]
    [FieldOffset(Offset = "0x2C")]
    public int t;
    [Token(Token = "0x4006E53")]
    [FieldOffset(Offset = "0x30")]
    public int m;
    [Token(Token = "0x4006E54")]
    [FieldOffset(Offset = "0x34")]
    public JSON_QuestCount d;
    [Token(Token = "0x4006E55")]
    [FieldOffset(Offset = "0x38")]
    public int b;

    [Token(Token = "0x6007412")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestProgress()
    {
    }
  }
}
