// Decompiled with JetBrains decompiler
// Type: SRPG.Json_Mail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001012")]
  [MessagePackObject(true)]
  public class Json_Mail
  {
    [Token(Token = "0x4003928")]
    [FieldOffset(Offset = "0x8")]
    public long mid;
    [Token(Token = "0x4003929")]
    [FieldOffset(Offset = "0x10")]
    public string msg;
    [Token(Token = "0x400392A")]
    [FieldOffset(Offset = "0x14")]
    public Json_Gift[] gifts;
    [Token(Token = "0x400392B")]
    [FieldOffset(Offset = "0x18")]
    public int read;
    [Token(Token = "0x400392C")]
    [FieldOffset(Offset = "0x20")]
    public long post_at;
    [Token(Token = "0x400392D")]
    [FieldOffset(Offset = "0x28")]
    public int period;

    [Token(Token = "0x6004276")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_Mail()
    {
    }
  }
}
