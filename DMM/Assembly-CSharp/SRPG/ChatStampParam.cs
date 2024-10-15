// Decompiled with JetBrains decompiler
// Type: SRPG.ChatStampParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002161")]
  public class ChatStampParam
  {
    [Token(Token = "0x40091A5")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40091A6")]
    [FieldOffset(Offset = "0xC")]
    public string img_id;
    [Token(Token = "0x40091A7")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x40091A8")]
    [FieldOffset(Offset = "0x14")]
    public bool IsPrivate;

    [Token(Token = "0x6008C55")]
    [Address(RVA = "0x500200", Offset = "0x4FF000", VA = "0x10500200")]
    public bool Deserialize(JSON_ChatStampParam json) => new bool();

    [Token(Token = "0x6008C56")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatStampParam()
    {
    }
  }
}
