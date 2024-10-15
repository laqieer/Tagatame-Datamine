// Decompiled with JetBrains decompiler
// Type: SRPG.SkillRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BC5")]
  public struct SkillRange
  {
    [Token(Token = "0x4001DCA")]
    [FieldOffset(Offset = "0x0")]
    private int w;
    [Token(Token = "0x4001DCB")]
    [FieldOffset(Offset = "0x4")]
    private int h;
    [Token(Token = "0x4001DCC")]
    [FieldOffset(Offset = "0x8")]
    private int[] bit;
    [Token(Token = "0x4001DCD")]
    [FieldOffset(Offset = "0xC")]
    private int count;

    [Token(Token = "0x6002F32")]
    [Address(RVA = "0xFCD850", Offset = "0xFCC650", VA = "0x10FCD850")]
    public SkillRange(int _w, int _h)
    {
    }

    [Token(Token = "0x6002F33")]
    [Address(RVA = "0xFCD630", Offset = "0xFCC430", VA = "0x10FCD630")]
    public void Clear()
    {
    }

    [Token(Token = "0x6002F34")]
    [Address(RVA = "0xFCD770", Offset = "0xFCC570", VA = "0x10FCD770")]
    public void Set(int x, int y)
    {
    }

    [Token(Token = "0x6002F35")]
    [Address(RVA = "0xFCD690", Offset = "0xFCC490", VA = "0x10FCD690")]
    public bool Get(int x, int y) => new bool();

    [Token(Token = "0x6002F36")]
    [Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")]
    public int Count() => new int();
  }
}
