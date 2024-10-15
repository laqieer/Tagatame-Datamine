// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaHistoryLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200242F")]
  public class Json_GachaHistoryLog
  {
    [Token(Token = "0x400A3F0")]
    [FieldOffset(Offset = "0x8")]
    public string title;
    [Token(Token = "0x400A3F1")]
    [FieldOffset(Offset = "0xC")]
    public Json_GachaHistoryItem[] drops;
    [Token(Token = "0x400A3F2")]
    [FieldOffset(Offset = "0x10")]
    public long drop_at;

    [Token(Token = "0x6009DCC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GachaHistoryLog()
    {
    }
  }
}
