// Decompiled with JetBrains decompiler
// Type: SRPG.ShareStringList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D1A")]
  public class ShareStringList
  {
    [Token(Token = "0x400722A")]
    [FieldOffset(Offset = "0x8")]
    private short[] mIndexs;
    [Token(Token = "0x400722B")]
    [FieldOffset(Offset = "0xC")]
    private ShareString.Type mType;

    [Token(Token = "0x600776F")]
    [Address(RVA = "0x39F170", Offset = "0x39DF70", VA = "0x1039F170")]
    public ShareStringList(ShareString.Type type)
    {
    }

    [Token(Token = "0x17000FC5")]
    public int Length
    {
      [Token(Token = "0x6007770"), Address(RVA = "0x39F190", Offset = "0x39DF90", VA = "0x1039F190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007771")]
    [Address(RVA = "0x39F0F0", Offset = "0x39DEF0", VA = "0x1039F0F0")]
    public void Setup(int length)
    {
    }

    [Token(Token = "0x6007772")]
    [Address(RVA = "0x39ED50", Offset = "0x39DB50", VA = "0x1039ED50")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007773")]
    [Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")]
    public bool IsNotNull() => new bool();

    [Token(Token = "0x6007774")]
    [Address(RVA = "0x39ED80", Offset = "0x39DB80", VA = "0x1039ED80")]
    public string[] GetList() => (string[]) null;

    [Token(Token = "0x6007775")]
    [Address(RVA = "0x39EEC0", Offset = "0x39DCC0", VA = "0x1039EEC0")]
    public string Get(int index) => (string) null;

    [Token(Token = "0x6007776")]
    [Address(RVA = "0x39EF60", Offset = "0x39DD60", VA = "0x1039EF60")]
    public void Set(int index, string value)
    {
    }
  }
}
