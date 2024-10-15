// Decompiled with JetBrains decompiler
// Type: SRPG.ChatChannelParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002192")]
  public class ChatChannelParam
  {
    [Token(Token = "0x40092BE")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40092BF")]
    [FieldOffset(Offset = "0xC")]
    public int fever_level;
    [Token(Token = "0x40092C0")]
    [FieldOffset(Offset = "0x10")]
    public int category_id;
    [Token(Token = "0x40092C1")]
    [FieldOffset(Offset = "0x14")]
    public string name;

    [Token(Token = "0x6008D33")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatChannelParam()
    {
    }
  }
}
