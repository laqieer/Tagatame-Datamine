// Decompiled with JetBrains decompiler
// Type: SRPG.ContentGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002258")]
  public struct ContentGrid
  {
    [Token(Token = "0x40098AD")]
    [FieldOffset(Offset = "0x0")]
    public int x;
    [Token(Token = "0x40098AE")]
    [FieldOffset(Offset = "0x4")]
    public int y;

    [Token(Token = "0x17001494")]
    public static ContentGrid zero
    {
      [Token(Token = "0x600929E"), Address(RVA = "0x27C370", Offset = "0x27B170", VA = "0x1027C370")] get
      {
        return new ContentGrid();
      }
    }

    [Token(Token = "0x17001495")]
    public float fx
    {
      [Token(Token = "0x600929F"), Address(RVA = "0x562620", Offset = "0x561420", VA = "0x10562620")] set
      {
      }
    }

    [Token(Token = "0x17001496")]
    public float fy
    {
      [Token(Token = "0x60092A0"), Address(RVA = "0x562690", Offset = "0x561490", VA = "0x10562690")] set
      {
      }
    }

    [Token(Token = "0x60092A1")]
    [Address(RVA = "0x290D40", Offset = "0x28FB40", VA = "0x10290D40")]
    public ContentGrid(int _ix, int _iy)
    {
    }

    [Token(Token = "0x60092A2")]
    [Address(RVA = "0x562560", Offset = "0x561360", VA = "0x10562560")]
    public ContentGrid(float _fx, float _fy)
    {
    }

    [Token(Token = "0x60092A3")]
    [Address(RVA = "0x2BA800", Offset = "0x2B9600", VA = "0x102BA800")]
    public static int FloatToInt(float value) => new int();

    [Token(Token = "0x60092A4")]
    [Address(RVA = "0x562310", Offset = "0x561110", VA = "0x10562310", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
